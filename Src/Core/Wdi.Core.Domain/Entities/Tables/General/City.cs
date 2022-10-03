using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.General
{
    /// <summary>
    /// Şehirler
    /// </summary>
    [Table("City", Schema = "General")]
    public class City : BaseEntity
    {
        /// <summary>
        /// Ülke Bağlantısı
        /// </summary>
        [Required]
        public int CountryId { get; set; }
        /// <summary>
        /// Şehir Adı
        /// </summary>
        [Required, StringLength(250)]
        public string Name { get; set; }
        /// <summary>
        /// Şehir Kodu
        /// </summary>
        [StringLength(25)]
        public string? CityCode { get; set; }
    }
}
