using System.ComponentModel.DataAnnotations;

namespace Wdi.Core.Domain.Entities.Common
{
    public class BaseCategoryDetail : BaseEntity
    {
        /// <summary>
        /// Kategori Kimlik Numarası
        /// </summary>
        [Required]
        public int CategoryId { get; set; }
        /// <summary>
        /// Satır Kimlik Numarası
        /// </summary>
        [Required]
        public int RowId { get; set; }
    }
}
