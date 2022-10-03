using System.ComponentModel.DataAnnotations;
using Wdi.Core.Domain.Enumerations;
using Wdi.Core.Domain.Interfaces;

namespace Wdi.Core.Domain.Entities.Common
{
    public class BaseFileDetail : BaseTable, ITitle
    {
        /// <summary>
        /// Dosya Kimlik Numarası
        /// </summary>
        [Required]
        public int FileId { get; set; }
        /// <summary>
        /// Satır Kimlik Numarası
        /// </summary>
        [Required]
        public int RowId { get; set; }
        /// <summary>
        /// Dosya Tipi
        /// </summary>
        [Required]
        [StringLength(10)]
        public FileType FileType { get; set; }
        /// <summary>
        /// Üst Başlık
        /// </summary>
        public string? UpperTitle { get; set; }
        /// <summary>
        /// Alt Başlık
        /// </summary>
        public string? LowerTitle { get; set; }
        /// <summary>
        /// Açıklama
        /// </summary>
        public string? Description { get; set; }
    }
}
