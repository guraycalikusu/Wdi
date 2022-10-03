using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Wdi.Core.Application.DTO.Request;
using Wdi.Core.Application.Interfaces.Common;
using Wdi.Core.Domain.Interfaces;
using Wdi.Infrastructure.Persistence.Context;

namespace Wdi.Infrastructure.Persistence.Repositories.Concrete.Common
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Veri Tabanı Tablosu</typeparam>
    /// <typeparam name="TKey">Kimlik Numarası Veri Tipi</typeparam>
    public abstract partial class GenericRepository<T, TKey> : IGenericRepository<T, TKey> where T : class, IEntity where TKey : IEquatable<TKey>
    {
        private readonly WdiContext _context;
        /// <summary>
        /// Veri Tabanı Bağlayıcısı
        /// </summary>
        protected readonly DbSet<T> Connector;
        public GenericRepository(WdiContext _context)
        {
            this._context = _context;
            Connector = _context.Set<T>();
        }
        private bool _disposed = false;
        protected virtual async ValueTask DisposeAsync(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                await _context.DisposeAsync();
            }
            _disposed = true;
        }
        public async ValueTask DisposeAsync()
        {
            await DisposeAsync(true);
            GC.SuppressFinalize(this);
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Veri Tabanı Tablosu</typeparam>
    /// <typeparam name="TKey">Kimlik Numarası Veri Tipi</typeparam>
    public abstract partial class GenericRepository<T, TKey> : IGenericRepository<T, TKey> where T : class, IEntity where TKey : IEquatable<TKey>
    {
        #region Add
        /// <summary>
        /// Tablo Ekler
        /// </summary>
        /// <param name="entity">Tablo</param>
        public virtual void Insert(T entity) => Connector.Add(entity);
        /// <summary>
        /// Tablo Ekler
        /// </summary>
        /// <param name="entity">Tablo</param>
        /// <returns></returns>
        public virtual async Task InsertAsync(T entity) => await Connector.AddAsync(entity);
        /// <summary>
        /// Tabloları Ekler
        /// </summary>
        /// <param name="collection">Tablolar</param>
        public virtual void Insert(ICollection<T> collection) => Connector.AddRange(collection);
        /// <summary>
        /// Tabloları Ekler
        /// </summary>
        /// <param name="collection">Tablolar</param>
        /// <returns></returns>
        public virtual async Task InsertAsync(ICollection<T> collection) => await Connector.AddRangeAsync(collection);
        #endregion

        #region Update
        /// <summary>
        /// Tablo Günceller
        /// </summary>
        /// <param name="entity">Tablo</param>
        public virtual void Exchange(T entity) => Connector.Update(entity);
        /// <summary>
        /// Tabloları Günceller
        /// </summary>
        /// <param name="collection">Tablolar</param>
        public virtual void Exchange(ICollection<T> collection) => Connector.UpdateRange(collection);
        #endregion

        #region Delete
        /// <summary>
        /// Tablo Siler
        /// </summary>
        /// <param name="entity">Tablo</param>
        public virtual void Terminate(T entity) => Connector.Remove(entity);
        /// <summary>
        /// Tabloları Siler
        /// </summary>
        /// <param name="collection">Tablolar</param>
        public virtual void Terminate(ICollection<T> collection) => Connector.RemoveRange(collection);
        /// <summary>
        /// Tablo Siler
        /// </summary>
        /// <param name="key">Kimlik Numarası</param>
        public virtual void Terminate(TKey key)
        {
            var data = Connector.Find(key);
            if (data != null)
                Connector.Remove(data);
        }
        /// <summary>
        /// Tablo Siler
        /// </summary>
        /// <param name="key">Kimlik Numarası</param>
        public virtual async Task TerminateAsync(TKey key)
        {
            var data = await Connector.FindAsync(key);
            if (data != null)
                Connector.Remove(data);
        }
        /// <summary>
        /// Tabloları Siler
        /// </summary>
        /// <param name="collection">Kimlik Numaraları</param>
        public virtual void Terminate(ICollection<TKey> collection)
        {
            ICollection<T> entities = new List<T>();
            foreach (var key in collection)
            {
                var data = Connector.Find(key);
                if (data != null)
                    entities.Add(data);
            }
            Connector.RemoveRange(entities);
        }
        /// <summary>
        /// Tabloları Siler
        /// </summary>
        /// <param name="collection">Kimlik Numaraları</param>
        public virtual async Task TerminateAsync(ICollection<TKey> collection)
        {
            ICollection<T> entities = new List<T>();
            foreach (var key in collection)
            {
                var data = await Connector.FindAsync(key);
                if (data != null)
                    entities.Add(data);
            }
            Connector.RemoveRange(entities);
        }
        #endregion

        #region Get
        /// <summary>
        /// Tablo Getirir
        /// </summary>
        /// <param name="key">Kimlik Numarası</param>
        /// <returns></returns>
        public virtual T Read(TKey key) => Connector.Find(key);
        /// <summary>
        /// Tablo Getirir
        /// </summary>
        /// <param name="key">Kimlik Numarası</param>
        /// <returns></returns>
        public virtual async Task<T> ReadAsync(TKey key) => await Connector.FindAsync(key);
        /// <summary>
        /// Sorguya Göre Tablo Getirir
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual T Read(Expression<Func<T, bool>> include, bool tracking)
        {
            if (tracking)
                return Connector.Where(include).FirstOrDefault();
            else
                return Connector.AsNoTracking().Where(include).FirstOrDefault();
        }
        /// <summary>
        /// Sorguya Göre Tablo Getirir
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual async Task<T> ReadAsync(Expression<Func<T, bool>> include, bool tracking)
        {
            if (tracking)
                return await Connector.Where(include).FirstOrDefaultAsync();
            else
                return await Connector.AsNoTracking().Where(include).FirstOrDefaultAsync();
        }
        /// <summary>
        /// Seçilen Tablo Sütunlarını Getirir
        /// </summary>
        /// <typeparam name="Selected">Seçilenler</typeparam>
        /// <typeparam name="TSource">Sıralama Yapılacak Sütunun Veri Tipi</typeparam>
        /// <param name="include">Sorgu</param>
        /// <param name="selected">Seçilecekler</param>
        /// <param name="source">Sıralama Yapılacak Sütun</param>
        /// <param name="ascending">Sıralama Büyükten-Küçüğe mi Olsun?</param>
        /// <returns></returns>
        public virtual IQueryable<Selected> Read<Selected, TSource>(Expression<Func<T, bool>> include, Expression<Func<T, Selected>> selected, Expression<Func<T, TSource>> source, bool ascending)
        {
            if (ascending)
                return Connector.AsNoTracking().Where(include).OrderBy(source).Select(selected);
            else
                return Connector.AsNoTracking().Where(include).OrderByDescending(source).Select(selected);
        }
        /// <summary>
        /// Seçilen Tablo Sütunlarını Getirir
        /// </summary>
        /// <typeparam name="Selected">Seçilenler</typeparam>
        /// <typeparam name="TSource">Sıralama Yapılacak Sütunun Veri Tipi</typeparam>
        /// <param name="include">Sorgu</param>
        /// <param name="selected">Seçilecekler</param>
        /// <param name="source">Sıralama Yapılacak Sütun</param>
        /// <param name="ascending">Sıralama Büyükten-Küçüğe mi Olsun?</param>
        /// <returns></returns>
        public virtual async Task<Selected> ReadAsync<Selected, TSource>(Expression<Func<T, bool>> include, Expression<Func<T, Selected>> selected, Expression<Func<T, TSource>> source, bool ascending)
        {
            if (ascending)
                return await Connector.AsNoTracking().Where(include).OrderBy(source).Select(selected).FirstOrDefaultAsync();
            else
                return await Connector.AsNoTracking().Where(include).OrderByDescending(source).Select(selected).FirstOrDefaultAsync();
        }
        #endregion

        #region List
        /// <summary>
        /// Tablo Listeler
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual IEnumerable<T> Catalog(bool tracking)
        {
            if (tracking)
                return Connector.ToList();
            else
                return Connector.AsNoTracking().ToList();
        }
        /// <summary>
        /// Tablo Listeler
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<T>> CatalogAsync(bool tracking)
        {
            if (tracking)
                return await Connector.ToListAsync();
            else
                return await Connector.AsNoTracking().ToListAsync();
        }
        /// <summary>
        /// Tabloyu Sorguya Göre Listeler
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual IQueryable<T> Catalog(Expression<Func<T, bool>> include, bool tracking)
        {
            if (tracking)
                return Connector.Where(include);
            else
                return Connector.AsNoTracking().Where(include);
        }
        /// <summary>
        /// Tabloyu Sorguya Göre Listeler
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<T>> CatalogAsync(Expression<Func<T, bool>> include, bool tracking)
        {
            if (tracking)
                return await Connector.Where(include).ToListAsync();
            else
                return await Connector.AsNoTracking().Where(include).ToListAsync();
        }
        /// <summary>
        /// Seçilen Tablo Sütunlarını Listeler
        /// </summary>
        /// <typeparam name="Selected">Seçilenler</typeparam>
        /// <typeparam name="TSource">Sıralama Yapılacak Sütunun Veri Tipi</typeparam>
        /// <param name="include">Sorgu</param>
        /// <param name="selected">Seçilenler</param>
        /// <param name="source">Sıralama Yapılacak Sütun</param>
        /// <param name="request">İstek Detayları</param>
        /// <returns></returns>
        public virtual IQueryable<Selected> Catalog<Selected, TSource>(Expression<Func<T, bool>> include, Expression<Func<T, Selected>> selected, Expression<Func<T, TSource>> source, RequestParameters request)
        {
            if (request.SortAscending)
            {
                if (request.Paging)
                    return Connector.AsNoTracking().Where(include).OrderBy(source).Select(selected).Skip(request.Page * request.PageSize).Take(request.PageSize);
                else
                    return Connector.AsNoTracking().Where(include).OrderBy(source).Select(selected);
            }
            else
            {
                if (request.Paging)
                    return Connector.AsNoTracking().Where(include).OrderByDescending(source).Select(selected).Skip(request.Page * request.PageSize).Take(request.PageSize);
                else
                    return Connector.AsNoTracking().Where(include).OrderByDescending(source).Select(selected);
            }
        }
        /// <summary>
        /// Seçilen Tablo Sütunlarını Listeler
        /// </summary>
        /// <typeparam name="Selected">Seçilenler</typeparam>
        /// <typeparam name="TSource">Sıralama Yapılacak Sütunun Veri Tipi</typeparam>
        /// <param name="include">Sorgu</param>
        /// <param name="selected">Seçilenler</param>
        /// <param name="source">Sıralama Yapılacak Sütun</param>
        /// <param name="request">İstek Detayları</param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<Selected>> CatalogAsync<Selected, TSource>(Expression<Func<T, bool>> include, Expression<Func<T, Selected>> selected, Expression<Func<T, TSource>> source, RequestParameters request)
        {
            if (request.SortAscending)
            {
                if (request.Paging)
                    return await Connector.AsNoTracking().Where(include).OrderBy(source).Select(selected).Skip(request.Page * request.PageSize).Take(request.PageSize).ToListAsync();
                else
                    return await Connector.AsNoTracking().Where(include).OrderBy(source).Select(selected).ToListAsync();
            }
            else
            {
                if (request.Paging)
                    return await Connector.AsNoTracking().Where(include).OrderByDescending(source).Select(selected).Skip(request.Page * request.PageSize).Take(request.PageSize).ToListAsync();
                else
                    return await Connector.AsNoTracking().Where(include).OrderByDescending(source).Select(selected).ToListAsync();
            }
        }
        #endregion

        #region Any
        /// <summary>
        /// Kayıt Mevcut mu?
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual bool Store(bool tracking)
        {
            if (tracking)
                return Connector.Any();
            else
                return Connector.AsNoTracking().Any();
        }
        /// <summary>
        /// Kayıt Mevcut mu?
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual async Task<bool> StoreAsync(bool tracking)
        {
            if (tracking)
                return await Connector.AnyAsync();
            else
                return await Connector.AsNoTracking().AnyAsync();
        }
        /// <summary>
        /// Sorguya Göre Kayıt Mevcut mu?
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual bool Store(Expression<Func<T, bool>> include, bool tracking)
        {
            if (tracking)
                return Connector.Any(include);
            else
                return Connector.AsNoTracking().Any(include);
        }
        /// <summary>
        /// Sorguya Göre Kayıt Mevcut mu?
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual async Task<bool> StoreAsync(Expression<Func<T, bool>> include, bool tracking)
        {
            if (tracking)
                return await Connector.AnyAsync(include);
            else
                return await Connector.AsNoTracking().AnyAsync(include);
        }
        #endregion

        #region Count
        /// <summary>
        /// Kayıt Toplamını Verir
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual int Total(bool tracking)
        {
            if (tracking)
                return Connector.Count();
            else
                return Connector.AsNoTracking().Count();
        }
        /// <summary>
        /// Kayıt Toplamını Verir
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual async Task<int> TotalAsync(bool tracking)
        {
            if (tracking)
                return await Connector.CountAsync();
            else
                return await Connector.AsNoTracking().CountAsync();
        }
        /// <summary>
        /// Sorguya Göre Kayıt Toplamını Verir
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual int Total(Expression<Func<T, bool>> include, bool tracking)
        {
            if (tracking)
                return Connector.Count(include);
            else
                return Connector.AsNoTracking().Count(include);
        }
        /// <summary>
        /// Sorguya Göre Kayıt Toplamını Verir
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual async Task<int> TotalAsync(Expression<Func<T, bool>> include, bool tracking)
        {
            if (tracking)
                return await Connector.CountAsync(include);
            else
                return await Connector.AsNoTracking().CountAsync(include);
        }
        #endregion

        #region Min
        /// <summary>
        /// Seçilen Sütuna Göre En Küçük Kaydı Verir
        /// </summary>
        /// <typeparam name="TSource">Seçilecek Sütunun Veri Tipi</typeparam>
        /// <param name="source">Seçilecek Sütun</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual TSource Weest<TSource>(Expression<Func<T, TSource>> source, bool tracking)
        {
            if (tracking)
                return Connector.Min(source);
            else
                return Connector.AsNoTracking().Min(source);
        }
        /// <summary>
        /// Seçilen Sütuna Göre En Küçük Kaydı Verir
        /// </summary>
        /// <typeparam name="TSource">Seçilecek Sütunun Veri Tipi</typeparam>
        /// <param name="source">Seçilecek Sütun</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual async Task<TSource> WeestAsync<TSource>(Expression<Func<T, TSource>> source, bool tracking)
        {
            if (tracking)
                return await Connector.MinAsync(source);
            else
                return await Connector.AsNoTracking().MinAsync(source);
        }
        #endregion

        #region Max
        /// <summary>
        /// Seçilen Sütuna Göre En Büyük Kaydı Verir
        /// </summary>
        /// <typeparam name="TSource">Seçilecek Sütunun Veri Tipi</typeparam>
        /// <param name="source">Seçilecek Sütun</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual TSource Supreme<TSource>(Expression<Func<T, TSource>> source, bool tracking)
        {
            if (tracking)
                return Connector.Max(source);
            else
                return Connector.AsNoTracking().Max(source);
        }
        /// <summary>
        /// Seçilen Sütuna Göre En Büyük Kaydı Verir
        /// </summary>
        /// <typeparam name="TSource">Seçilecek Sütunun Veri Tipi</typeparam>
        /// <param name="source">Seçilecek Sütun</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        public virtual async Task<TSource> SupremeAsync<TSource>(Expression<Func<T, TSource>> source, bool tracking)
        {
            if (tracking)
                return await Connector.MaxAsync(source);
            else
                return await Connector.AsNoTracking().MaxAsync(source);
        }
        #endregion
    }
}
