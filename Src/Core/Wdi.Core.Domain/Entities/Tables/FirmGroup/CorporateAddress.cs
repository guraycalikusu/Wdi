using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;
using Wdi.Core.Domain.Enumerations;

namespace Wdi.Core.Domain.Entities.Tables.FirmGroup
{
    /// <summary>
    /// Kurumsal Adres
    /// </summary>
    [Table("CorporateAddress", Schema = "FirmGroup")]
    public class CorporateAddress : BaseAddress
    {
        /// <summary>
        /// Grup Bileşen Tipi
        /// </summary>
        [Required]
        [StringLength(25)]
        public GroupComponentType GroupComponent { get; set; }
    }
}
