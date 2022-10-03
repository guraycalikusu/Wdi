using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Interfaces;

namespace Wdi.Core.Domain.Entities.Common
{
    public abstract class BaseEntity : IEntity
    {
        /// <summary>
        /// Kimlik Bilgisi
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Kayıt Tarihi
        /// </summary>
        [Required]
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Kaydeden
        /// </summary>
        [Required]
        [StringLength(250)]
        public string Recorder { get; set; }
        /// <summary>
        /// Güncelleme Tarihi
        /// </summary>

        public DateTime? UpdatingDate { get; set; }
        /// <summary>
        /// Güncelleyen
        /// </summary>
        [StringLength(250)]
        public string? Updater { get; set; }
    }
}
