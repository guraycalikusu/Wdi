using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;
using Wdi.Core.Domain.Enumerations;

namespace Wdi.Core.Domain.Entities.Tables.General
{
    /// <summary>
    /// Url Listesi
    /// </summary>
    [Table("UrlList", Schema = "General")]
    public class UrlList : BaseEntity
    {
        /// <summary>
        /// Modül Adı
        /// </summary>
        [Required]
        public Modules Module { get; set; }
        /// <summary>
        /// Satır Kimlik Numarası
        /// </summary>
        [Required]
        public int RowId { get; set; }
        /// <summary>
        /// Url Adresi
        /// </summary>
        [Required, StringLength(250)]
        public string Url { get; set; }
        /// <summary>
        /// Dil Kodu
        /// </summary>
        [Required, StringLength(10)]
        public string Culture { get; set; }
    }
}
