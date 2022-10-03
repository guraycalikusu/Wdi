using System.Linq.Expressions;
using Wdi.Core.Application.DTO.Common;
using Wdi.Core.Application.DTO.Request;
using Wdi.Core.Domain.Interfaces;

namespace Wdi.Core.Application.Interfaces.Common
{
    /// <summary>
    /// Ana Servis Ara Yüzü
    /// </summary>
    /// <typeparam name="TEntity">Veri Tabanı Modeli</typeparam>
    /// <typeparam name="TInsert">Kayıt Modeli</typeparam>
    /// <typeparam name="TExchange">Güncelleme Modeli</typeparam>
    /// <typeparam name="TRead">Okuma Modeli</typeparam>
    /// <typeparam name="TList">Listeleme Modeli</typeparam>
    /// <typeparam name="TSelectedList">Seçilen Alanlardan Oluşan Listeleme Modeli</typeparam>
    /// <typeparam name="TError">Hata Modeli</typeparam>
    /// <typeparam name="TDeleteReport">Silme Raporu</typeparam>
    /// <typeparam name="TKey">Kimlik Numarası Veri Tipi</typeparam>
    public interface IAppService<TEntity, TInsert, TExchange, TRead, TList, TSelectedList, TError, TDeleteReport, TKey> : IAsyncDisposable where TEntity : class, IEntity, new() where TInsert : class, new() where TExchange : class, new() where TRead : class, new() where TList : class, new() where TSelectedList : class, new() where TError : class, new() where TDeleteReport : class, new() where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// Kayıt Ekler
        /// </summary>
        /// <param name="model">Kayıt Modeli</param>
        /// <returns></returns>
        Task<AppResult<TRead, AppDummy, TError>> AppInsertAsync(TInsert model);
        /// <summary>
        /// Kayıt Günceller
        /// </summary>
        /// <param name="model">Güncelleme Modeli</param>
        /// <returns></returns>
        Task<AppResult<TRead, AppDummy, TError>> AppExchangeAsync(TExchange model);
        /// <summary>
        /// Kayıtları Siler
        /// </summary>
        /// <param name="ids">Kayıtlara Ait Kimlik Numaraları</param>
        /// <returns></returns>
        Task<AppResult<AppDummy, TDeleteReport, TError>> AppTerminateAsync(IList<TKey> ids);
        /// <summary>
        /// Kaydı Sorguya Göre Okur
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <returns></returns>
        Task<AppResult<TRead, AppDummy, TError>> AppReadAsync(Expression<Func<TEntity, bool>> include);
        /// <summary>
        /// Kaydın Seçilen Alanlarını Okur
        /// </summary>
        /// <typeparam name="Selected">Seçilenler</typeparam>
        /// <typeparam name="TSource">Sıralama için Seçilen Alanın Veri Tipi</typeparam>
        /// <param name="include">Sorgu</param>
        /// <param name="selected">Alan Seçimi</param>
        /// <param name="source">Sıralama Alanı</param>
        /// <param name="ascending">Küçükten-Büyüğe mi Sıralansın?</param>
        /// <returns></returns>
        Task<AppResult<TRead, AppDummy, TError>> AppReadAsync<Selected, TSource>(Expression<Func<TEntity, bool>> include, Expression<Func<TEntity, Selected>> selected, Expression<Func<TEntity, TSource>> source, bool ascending);
        /// <summary>
        /// Kayıtları Listeler
        /// </summary>
        /// <returns></returns>
        Task<AppResult<AppDummy, TList, TError>> AppCatalogAsync();
        /// <summary>
        /// Kayıtları Sorguya Göre Listeler
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <returns></returns>
        Task<AppResult<AppDummy, TList, TError>> AppCatalogAsync(Expression<Func<TEntity, bool>> include);
        /// <summary>
        /// Kayıtları Seçilen Alanlara Göre Listeler
        /// </summary>
        /// <typeparam name="Selected">Seçilenler</typeparam>
        /// <typeparam name="TSource">Sıralama için Seçilen Alanın Veri Tipi</typeparam>
        /// <param name="include">Sorgu</param>
        /// <param name="selected">Alan Seçimi</param>
        /// <param name="source">Sıralama Yapılacak Alan Seçimi</param>
        /// <param name="request">İstek Detayları</param>
        /// <returns></returns>
        Task<AppResult<AppDummy, TSelectedList, TError>> AppCatalogAsync<Selected, TSource>(Expression<Func<TEntity, bool>> include, Expression<Func<TEntity, Selected>> selected, Expression<Func<TEntity, TSource>> source, RequestParameters request);
        /// <summary>
        /// Kaydın Sorguya Göre Mevcut Olup Olmadığını Kontrol Eder
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <returns></returns>
        Task<bool> AppStoreAsync(Expression<Func<TEntity, bool>> include);
        /// <summary>
        /// Kaydın Sorguya Göre Toplam Sayısını Verir
        /// </summary>
        /// <param name="include">Sorgu</param>
        /// <returns></returns>
        Task<int> AppTotalAsync(Expression<Func<TEntity, bool>> include);
    }
}
