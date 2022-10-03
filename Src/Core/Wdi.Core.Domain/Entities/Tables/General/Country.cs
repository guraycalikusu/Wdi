using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.General
{
    /// <summary>
    /// Ülkeler
    /// </summary>
    [Table("Country", Schema = "General")]
    public class Country : BaseEntity
    {
        /// <summary>
        /// Ülke Adı
        /// </summary>
        [Required, StringLength(250)]
        public string Name { get; set; }
        /// <summary>
        /// Ülke Kodu
        /// </summary>
        [StringLength(5)]
        public string? CountryCode { get; set; }
        /// <summary>
        /// Telefon Kodu
        /// </summary>
        [StringLength(10)]
        public string? PhoneCode { get; set; }
        /// <summary>
        /// Dil Kodu
        /// </summary>
        [StringLength(10)]
        public string? LanguageCode { get; set; }
    }
}
