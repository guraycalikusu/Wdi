namespace Wdi.Core.Application.DTO.Common
{
    /// <summary>
    /// Sonuç Sınıfı
    /// </summary>
    /// <typeparam name="TRead">Model Sınıfı</typeparam>
    /// <typeparam name="TList">Liste Sınıfı</typeparam>
    /// <typeparam name="TError">Hata Sınıfı</typeparam>
    public class AppResult<TRead, TList, TError>
    {
        /// <summary>
        /// İşlem Başarılı mı?
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Model
        /// </summary>
        public TRead Data { get; set; }
        /// <summary>
        /// Liste
        /// </summary>
        public IList<TList> DataList { get; set; }
        /// <summary>
        /// Hata Sınıfı
        /// </summary>
        public TError Error { get; set; }

    }
}
