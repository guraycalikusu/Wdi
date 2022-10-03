namespace Wdi.Core.Domain.Constants
{
    /// <summary>
    /// Hata Kodları
    /// </summary>
    public class AppErrorCode
    {
        /// <summary>
        /// İşlem Başarılı
        /// </summary>
        public const short AppOk = 10;
        /// <summary>
        /// Yetkilendirma Hatası
        /// </summary>
        public const short AppAuthError = 11;
        /// <summary>
        /// Kötü İstek Hatası
        /// </summary>
        public const short AppBadRequestError = 12;
        /// <summary>
        /// İçerik Bulunamadı Hatası
        /// </summary>
        public const short AppNotFoundError = 13;
        /// <summary>
        /// Sunucu Hatası
        /// </summary>
        public const short AppServerError = 14;
        /// <summary>
        /// Bağlantı Hatası
        /// </summary>
        public const short AppConnectionError = 15;
        /// <summary>
        /// Ekleme Hatası
        /// </summary>
        public const short AppInsertError = 20;
        /// <summary>
        /// Güncelleme Hatası
        /// </summary>
        public const short AppExchangeError = 30;
        /// <summary>
        /// Silme Hatası
        /// </summary>
        public const short AppDeleteError = 40;
    }
}
