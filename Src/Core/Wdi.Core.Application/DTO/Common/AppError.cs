using System.Net;
using Wdi.Core.Domain.Constants;

namespace Wdi.Core.Application.DTO.Common
{
    /// <summary>
    /// Hatalar
    /// </summary>
    public class AppError
    {
        /// <summary>
        /// Hata Kodu
        /// </summary>
        public AppErrorCode? AppErrorCode { get; set; }
        /// <summary>
        /// Durum Kodu
        /// </summary>
        public HttpStatusCode? StatusCode { get; set; }
        /// <summary>
        /// Geliştirici Mesajı
        /// </summary>
        public string? DeveloperMessage { get; set; }
        /// <summary>
        /// Hata Mesajı
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Hata Kodu
        /// </summary>
        public string? ErrorCode { get; set; }
        /// <summary>
        /// Hata Tarihi
        /// </summary>
        public DateTime? ErrorDate { get; set; }
        /// <summary>
        /// Hata Detayı
        /// </summary>
        public string? ErrorInfo { get; set; }
        /// <summary>
        /// Hata Detayı
        /// </summary>
        public string? ErrorExtraInfo { get; set; }
        /// <summary>
        /// Hata Detayı
        /// </summary>
        public string? ErrorMoreExtraInfo { get; set; }

    }
}
