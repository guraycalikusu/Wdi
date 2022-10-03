using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.FirmInfo
{
    /// <summary>
    /// Şirketler
    /// </summary>
    [Table("Firm", Schema = "FirmGroup")]
    public class Firm : BaseTable
    {
        /// <summary>
        /// Şirket Adı
        /// </summary>
        [Required, StringLength(250)]
        public string FirmName { get; set; }
        /// <summary>
        /// Ticari Ünvanı
        /// </summary>
        [StringLength(250)]
        public string? CompanyName { get; set; }
        /// <summary>
        /// Şirket Kodu
        /// </summary>
        [StringLength(250)]
        public string? FirmCode { get; set; }
        /// <summary>
        /// Vergi Numarası
        /// </summary>
        [StringLength(25)]
        public string? TaxNumber { get; set; }
        /// <summary>
        /// Vergi Dairesi
        /// </summary>
        [StringLength(250)]
        public string? TaxOffice { get; set; }
        /// <summary>
        /// Mersis Numarası
        /// </summary>
        [StringLength(25)]
        public string? MersisNumber { get; set; }
        /// <summary>
        /// Ticari Sicil Numarası
        /// </summary>
        [StringLength(25)]
        public string? TradeRegisterNumber { get; set; }
        /// <summary>
        /// Sorumlu Kişi
        /// </summary>
        [StringLength(250)]
        public string? IndividualResponsible { get; set; }
    }
}
