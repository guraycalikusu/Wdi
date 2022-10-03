using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.General
{
    /// <summary>
    /// İlçeler
    /// </summary>
    [Table("District", Schema = "General")]
    public class District : BaseEntity
    {
        /// <summary>
        /// Şehir Bağlantısı
        /// </summary>
        [Required]
        public int CityId { get; set; }
        /// <summary>
        /// İlçe Adı
        /// </summary>
        [Required, StringLength(250)]
        public string Name { get; set; }
        /// <summary>
        /// İlçe Kodu
        /// </summary>
        [StringLength(25)]
        public string? DistrictCode { get; set; }
    }
}
