using Wdi.Core.Domain.Enumerations;

namespace Wdi.Core.Application.DTO.Request
{
    /// <summary>
    /// İstek Parametreleri
    /// </summary>
    public class RequestParameters
    {
        /// <summary>
        /// Sayfa Büyüklüğü
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// Sayfa Numarası. Not: Sayfa 0'dan başlar. 0(sıfır) ilk sayfa olacaktır.
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// Sayfalama Var mı? Not: Burası "True" değer gönderilirse "PageSize" ve "Page" parametreleri dikkate alınır. 
        /// </summary>
        public bool Paging { get; set; }
        /// <summary>
        /// Kayıt Aktif mi?
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Kaydın Dili
        /// </summary>
        public string Culture { get; set; }
        /// <summary>
        /// Sıralama Küçükten-Büyüğe mi?
        /// </summary>
        public bool SortAscending { get; set; }
        /// <summary>
        /// İzleme Olsun mu?
        /// </summary>
        public bool Tracking { get; set; }
        /// <summary>
        /// Arama İfadesi
        /// </summary>
        public string Search { get; set; }
        /// <summary>
        /// Arama Kriterleri
        /// </summary>
        public SearchType SearchType { get; set; }
    }
}
