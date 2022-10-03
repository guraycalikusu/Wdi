using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;
using Wdi.Core.Domain.Enumerations;

namespace Wdi.Core.Domain.Entities.Tables.Identity
{
    /// <summary>
    /// Yetkilendirme
    /// </summary>
    [Table("AppAuth")]
    public class AppAuth : BaseEntity
    {
        /// <summary>
        /// Rol Bağlantısı
        /// </summary>
        [Required]
        public string RoleId { get; set; }
        /// <summary>
        /// Modül
        /// </summary>
        [Required, StringLength(25)]
        public Modules Module { get; set; }
        /// <summary>
        /// Okuma Yetkisi
        /// </summary>
        [Required]
        public bool Read { get; set; }
        /// <summary>
        /// Yazma Yetkisi
        /// </summary>
        [Required]
        public bool Write { get; set; }
        /// <summary>
        /// Silme Yetkisi
        /// </summary>
        [Required]
        public bool Delete { get; set; }
    }
}
