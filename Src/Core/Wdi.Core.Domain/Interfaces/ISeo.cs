namespace Wdi.Core.Domain.Interfaces
{
    public interface ISeo
    {
        /// <summary>
        /// Seo Başlık
        /// </summary>
        string? SeoTitle { get; set; }
        /// <summary>
        /// Seo Açıklama
        /// </summary>
        string? SeoDescription { get; set; }
        /// <summary>
        /// Seo Anahtar Kelime
        /// </summary>
        string? SeoKeyword { get; set; }
    }
}
