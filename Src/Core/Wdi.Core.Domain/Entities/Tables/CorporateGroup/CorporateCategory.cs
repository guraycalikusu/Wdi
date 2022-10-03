using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.CorporateGroup
{
    /// <summary>
    /// Kurumsal Kategori Tablosu
    /// </summary>
    [Table("CorporateCategory", Schema = "CorporateGroup")]
    public class CorporateCategory : BaseModule
    {
        /// <summary>
        /// Üst Kategorisi
        /// </summary>
        [Required]
        public int UpperId { get; set; }
    }
}
