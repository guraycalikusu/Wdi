using System.ComponentModel.DataAnnotations;
using Wdi.Core.Domain.Enumerations;

namespace Wdi.Core.Domain.Entities.Common
{
    public class BaseLanguage : BaseEntity
    {
        /// <summary>
        /// Grup Bileşen Tipi
        /// </summary>
        [Required]
        [StringLength(25)]
        public GroupComponentType GroupComponent { get; set; }
        /// <summary>
        /// Kayıt Bileşen Tipi
        /// </summary>
        [Required]
        [StringLength(25)]
        public RowComponentType RowComponent { get; set; }
        /// <summary>
        /// Satır Kimlik Numarası
        /// </summary>
        [Required]
        public int RowId { get; set; }
        /// <summary>
        /// Metinsel İçerik
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// Dil
        /// </summary>
        [Required, StringLength(10)]
        public string Culture { get; set; }
    }
}
