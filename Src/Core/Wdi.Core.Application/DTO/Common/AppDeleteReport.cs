namespace Wdi.Core.Application.DTO.Common
{
    /// <summary>
    /// Silme Raporu
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class AppDeleteReport<TKey> where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// Kimlik Numarası
        /// </summary>
        public TKey Id { get; set; }
        /// <summary>
        /// Kayıt Adı
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// İşlem Başarılı mı?
        /// </summary>
        public bool Success { get; set; }
    }
}
