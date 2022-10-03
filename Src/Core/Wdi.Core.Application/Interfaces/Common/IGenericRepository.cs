using System.Linq.Expressions;
using Wdi.Core.Application.DTO.Request;
using Wdi.Core.Domain.Interfaces;

namespace Wdi.Core.Application.Interfaces.Common
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Veri Tabanı Tablosu</typeparam>
    /// <typeparam name="TKey">Kimlik Numarası Veri Tipi</typeparam>
    public interface IGenericRepository<T, TKey> : IAsyncDisposable where T : class, IEntity  where TKey : IEquatable<TKey>
    {
        #region Add
        /// <summary>
        /// Tablo Ekler
        /// </summary>
        /// <param name="entity">Tablo</param>
        void Insert(T entity);
        /// <summary>
        /// Tablo Ekler
        /// </summary>
        /// <param name="entity">Tablo</param>
        Task InsertAsync(T entity);
        /// <summary>
        /// Tabloları Ekler
        /// </summary>
        /// <param name="collection">Tablolar</param>
        void Insert(ICollection<T> collection);
        /// <summary>
        /// Tabloları Ekler
        /// </summary>
        /// <param name="collection">Tablolar</param>
        Task InsertAsync(ICollection<T> collection);
        #endregion

        #region Update
        /// <summary>
        /// Tablo Günceller
        /// </summary>
        /// <param name="entity">Tablo</param>
        void Exchange(T entity);
        /// <summary>
        /// Tabloları Günceller
        /// </summary>
        /// <param name="collection">Tablolar</param>
        void Exchange(ICollection<T> collection);
        #endregion

        #region Delete
        /// <summary>
        /// Tablo Siler
        /// </summary>
        /// <param name="entity">Tablo</param>
        void Terminate(T entity);
        /// <summary>
        /// Tabloları Siler
        /// </summary>
        /// <param name="collection">Tablolar</param>
        void Terminate(ICollection<T> collection);
        /// <summary>
        /// Tablo Siler
        /// </summary>
        /// <param name="key">Kimlik Numarası</param>
        void Terminate(TKey key);
        /// <summary>
        /// Tablo Siler
        /// </summary>
        /// <param name="key">Kimlik Numarası</param>
        Task TerminateAsync(TKey key);
        /// <summary>
        /// Tabloları Siler
        /// </summary>
        /// <param name="collection">Kimlik Numaraları</param>
        void Terminate(ICollection<TKey> collection);
        /// <summary>
        /// Tabloları Siler
        /// </summary>
        /// <param name="collection">Kimlik Numaraları</param>
        Task TerminateAsync(ICollection<TKey> collection);
        #endregion

        #region Get
        /// <summary>
        /// Tablo Getirir
        /// </summary>
        /// <param name="key">Kimlik Numarası</param>
        /// <returns></returns>
        T Read(TKey key);
        /// <summary>
        /// Tablo Getirir
        /// </summary>
        /// <param name="key">Kimlik Numarası</param>
        /// <returns></returns>
        Task<T> ReadAsync(TKey key);
        /// <summary>
        /// Sorguya Göre Tablo Getirir
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        T Read(Expression<Func<T, bool>> include, bool tracking);
        /// <summary>
        /// Sorguya Göre Tablo Getirir
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        Task<T> ReadAsync(Expression<Func<T, bool>> include, bool tracking);
        /// <summary>
        /// Seçilen Tablo Sütunlarını Getirir
        /// </summary>
        /// <typeparam name="Selected">Seçilenler</typeparam>
        /// <typeparam name="TSource">Sıralama Yapılacak Sütunun Veri Tipi</typeparam>
        /// <param name="include">Sorgu</param>
        /// <param name="selected">Seçilecekler</param>
        /// <param name="source">Sıralama Yapılacak Sütun</param>
        /// <param name="ascending">Sıralama Küçükten-Büyüğe mi Olsun?</param>
        /// <returns></returns>
        IQueryable<Selected> Read<Selected, TSource>(Expression<Func<T, bool>> include, Expression<Func<T, Selected>> selected, Expression<Func<T, TSource>> source, bool ascending);
        /// <summary>
        /// Seçilen Tablo Sütunlarını Getirir
        /// </summary>
        /// <typeparam name="Selected">Seçilenler</typeparam>
        /// <typeparam name="TSource">Sıralama Yapılacak Sütunun Veri Tipi</typeparam>
        /// <param name="include">Sorgu</param>
        /// <param name="selected">Seçilecekler</param>
        /// <param name="source">Sıralama Yapılacak Sütun</param>
        /// <param name="ascending">Sıralama Küçükten-Büyüğe mi Olsun?</param>
        /// <returns></returns>
        Task<Selected> ReadAsync<Selected, TSource>(Expression<Func<T, bool>> include, Expression<Func<T, Selected>> selected, Expression<Func<T, TSource>> source, bool ascending);
        #endregion

        #region List
        /// <summary>
        /// Tablo Listeler
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        IEnumerable<T> Catalog(bool tracking);
        /// <summary>
        /// Tablo Listeler
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        Task<IEnumerable<T>> CatalogAsync(bool tracking);
        /// <summary>
        /// Tabloyu Sorguya Göre Listeler
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        IQueryable<T> Catalog(Expression<Func<T, bool>> include, bool tracking);
        /// <summary>
        /// Tabloyu Sorguya Göre Listeler
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        Task<IEnumerable<T>> CatalogAsync(Expression<Func<T, bool>> include, bool tracking);
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
        IQueryable<Selected> Catalog<Selected, TSource>(Expression<Func<T, bool>> include, Expression<Func<T, Selected>> selected, Expression<Func<T, TSource>> source, RequestParameters request);
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
        Task<IEnumerable<Selected>> CatalogAsync<Selected, TSource>(Expression<Func<T, bool>> include, Expression<Func<T, Selected>> selected, Expression<Func<T, TSource>> source, RequestParameters request);
        #endregion

        #region Any
        /// <summary>
        /// Kayıt Mevcut mu?
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        bool Store(bool tracking);
        /// <summary>
        /// Kayıt Mevcut mu?
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        Task<bool> StoreAsync(bool tracking);
        /// <summary>
        /// Sorguya Göre Kayıt Mevcut mu?
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        bool Store(Expression<Func<T, bool>> include, bool tracking);
        /// <summary>
        /// Sorguya Göre Kayıt Mevcut mu?
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        Task<bool> StoreAsync(Expression<Func<T, bool>> include, bool tracking);
        #endregion

        #region Count
        /// <summary>
        /// Kayıt Toplamını Verir
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        int Total(bool tracking);
        /// <summary>
        /// Kayıt Toplamını Verir
        /// </summary>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        Task<int> TotalAsync(bool tracking);
        /// <summary>
        /// Sorguya Göre Kayıt Toplamını Verir
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        int Total(Expression<Func<T, bool>> include, bool tracking);
        /// <summary>
        /// Sorguya Göre Kayıt Toplamını Verir
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        Task<int> TotalAsync(Expression<Func<T, bool>> include, bool tracking);
        #endregion

        #region Min
        /// <summary>
        /// Seçilen Sütuna Göre En Küçük Kaydı Verir
        /// </summary>
        /// <typeparam name="TSource">Seçilecek Sütunun Veri Tipi</typeparam>
        /// <param name="source">Seçilecek Sütun</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        TSource Weest<TSource>(Expression<Func<T, TSource>> source, bool tracking);
        /// <summary>
        /// Seçilen Sütuna Göre En Küçük Kaydı Verir
        /// </summary>
        /// <typeparam name="TSource">Seçilecek Sütunun Veri Tipi</typeparam>
        /// <param name="source">Seçilecek Sütun</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        Task<TSource> WeestAsync<TSource>(Expression<Func<T, TSource>> source, bool tracking);
        #endregion

        #region Max
        /// <summary>
        /// Seçilen Sütuna Göre En Büyük Kaydı Verir
        /// </summary>
        /// <typeparam name="TSource">Seçilecek Sütunun Veri Tipi</typeparam>
        /// <param name="source">Seçilecek Sütun</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        TSource Supreme<TSource>(Expression<Func<T, TSource>> source, bool tracking);
        /// <summary>
        /// Seçilen Sütuna Göre En Büyük Kaydı Verir
        /// </summary>
        /// <typeparam name="TSource">Seçilecek Sütunun Veri Tipi</typeparam>
        /// <param name="source">Seçilecek Sütun</param>
        /// <param name="tracking">İzleme Açık Olsun mu?</param>
        /// <returns></returns>
        Task<TSource> SupremeAsync<TSource>(Expression<Func<T, TSource>> source, bool tracking);
        #endregion

        #region Entity State

        #endregion
    }
}
