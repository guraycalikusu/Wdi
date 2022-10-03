namespace Wdi.Core.Domain.Interfaces
{
    public interface ITitle
    {
        /// <summary>
        /// Üst Başlık
        /// </summary>
        string? UpperTitle { get; set; }
        /// <summary>
        /// Alt Başlık
        /// </summary>
        string? LowerTitle { get; set; }
        /// <summary>
        /// Açıklama
        /// </summary>
        string? Description { get; set; }
    }
}
