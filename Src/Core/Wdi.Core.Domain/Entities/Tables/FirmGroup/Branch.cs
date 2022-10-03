using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.FirmInfo
{
    /// <summary>
    /// Şubeler
    /// </summary>
    [Table("Branch", Schema = "FirmGroup")]
    public class Branch : BaseTable
    {
        /// <summary>
        /// Şirket Bağlantısı
        /// </summary>
        [Required]
        public int FirmId { get; set; }
        /// <summary>
        /// Şube Adı
        /// </summary>
        [Required, StringLength(250)]
        public string BranchName { get; set; }
        /// <summary>
        /// Şube Kodu
        /// </summary>
        [StringLength(250)]
        public string? BranchCode { get; set; }
    }
}
