namespace Wdi.Core.Domain.Entities.Common
{
    public class BaseTable : BaseEntity
    {
        /// <summary>
        /// Sıra Numarası
        /// </summary>
        public int? Order { get; set; }
        /// <summary>
        /// Aktif mi?
        /// </summary>
        public bool? Active { get; set; }
    }
}
