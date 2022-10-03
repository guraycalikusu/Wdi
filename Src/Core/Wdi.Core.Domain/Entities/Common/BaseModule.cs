using System.ComponentModel.DataAnnotations;
using Wdi.Core.Domain.Enumerations;

namespace Wdi.Core.Domain.Entities.Common
{
    public class BaseModule : BaseTable
    {
        /// <summary>
        /// Kayıt Adı
        /// </summary>
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        /// <summary>
        /// Seflink
        /// </summary>
        [Required]
        [StringLength(250)]
        public string Url { get; set; }
        /// <summary>
        /// Seo Başlık
        /// </summary>
        [StringLength(500)]
        public string? SeoTitle { get; set; }
        /// <summary>
        /// Seo Açıklama
        /// </summary>
        [StringLength(500)]
        public string? SeoDescription { get; set; }
        /// <summary>
        /// Seo Anahtar Kelime
        /// </summary>
        [StringLength(500)]
        public string? SeoKeyword { get; set; }
        /// <summary>
        /// Özel Css
        /// </summary>
        public string? CustomCss { get; set; }
        /// <summary>
        /// Özel Script
        /// </summary>
        public string? CustomScript { get; set; }
        /// <summary>
        /// Özel Meta Bilgisi
        /// </summary>
        public string? CustomMeta { get; set; }
        /// <summary>
        /// Sayfa İçerik Tipi
        /// </summary>
        [Required]
        [StringLength(10)]
        public PageContentType ContentType { get; set; }
        /// <summary>
        /// Sayfa İçeriği
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// Üst Başlık
        /// </summary>
        public string? UpperTitle { get; set; }
        /// <summary>
        /// Alt Başlık
        /// </summary>
        public string? LowerTitle { get; set; }
        /// <summary>
        /// Açıklama
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Editör
        /// </summary>
        public string? Editor { get; set; }
    }
}
