using System.ComponentModel.DataAnnotations;
using Wdi.Core.Domain.Enumerations;

namespace Wdi.Core.Domain.Entities.Common
{
    public class BaseFile : BaseEntity
    {
        /// <summary>
        /// Dosya Başlığı
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Alternatif Metin
        /// </summary>
        public string? Alt { get; set; }
        /// <summary>
        /// Dosya Yolu
        /// </summary>
        [StringLength(250)]
        public string? Path { get; set; }
        /// <summary>
        /// Dosya Yolu Tipi
        /// </summary>
        [Required]
        [StringLength(10)]
        public FilePathType PathType { get; set; }
        /// <summary>
        /// Dosya Adı
        /// </summary>
        [StringLength(250)]
        public string? FileName { get; set; }
        /// <summary>
        /// Dosya Boyutu(KB)
        /// </summary>
        public long? Size { get; set; }
        /// <summary>
        /// Dosya Uzantısı
        /// </summary>
        [StringLength(10)]
        public string? Extension { get; set; }
        /// <summary>
        /// Dosya Türü
        /// </summary>
        [StringLength(150)]
        public string? MimeType { get; set; }
        /// <summary>
        /// Yükleme Tarihi
        /// </summary>
        public DateTime? DownloadingDate { get; set; }
    }
}
