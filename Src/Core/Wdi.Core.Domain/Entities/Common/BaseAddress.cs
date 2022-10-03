using System.ComponentModel.DataAnnotations;
using Wdi.Core.Domain.Enumerations;

namespace Wdi.Core.Domain.Entities.Common
{
    public class BaseAddress : BaseTable
    {
        /// <summary>
        /// Adres Tipi
        /// </summary>
        [Required]
        [StringLength(20)]
        public AddressType AddressType { get; set; }
        /// <summary>
        /// Adres Adı
        /// </summary>
        [Required, StringLength(250)]
        public string Name { get; set; }
        /// <summary>
        /// Adres İçeriği
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        /// Ülke
        /// </summary>
        [Required]
        public int Country { get; set; }
        /// <summary>
        /// Şehir
        /// </summary>
        [Required]
        public int City { get; set; }
        /// <summary>
        /// İlçe
        /// </summary>
        [Required]
        public int District { get; set; }
    }
}
