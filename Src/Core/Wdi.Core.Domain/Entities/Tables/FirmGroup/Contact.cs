using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;
using Wdi.Core.Domain.Enumerations;

namespace Wdi.Core.Domain.Entities.Tables.FirmInfo
{
    /// <summary>
    /// İletişim Bilgileri
    /// </summary>
    [Table("Contact", Schema = "FirmGroup")]
    public class Contact : BaseTable
    {
        /// <summary>
        /// İletişim Tipi
        /// </summary>
        [Required]
        [StringLength(25)]
        public ContactType ContactType { get; set; }
        /// <summary>
        /// Sosyal Medya Tipi
        /// </summary>
        [Required]
        [StringLength(25)]
        public SocialMediaType SocialMedia { get; set; }
        /// <summary>
        /// İletişim İçeriği
        /// </summary>
        [Required]
        public string ContactContent { get; set; }
    }
}
