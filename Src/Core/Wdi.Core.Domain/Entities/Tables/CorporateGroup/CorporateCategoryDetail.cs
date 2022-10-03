using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.CorporateGroup
{
    /// <summary>
    /// Kurumsal Kategori Bağlantıları Tablosu
    /// </summary>
    [Table("CorporateCategoryDetail", Schema = "CorporateGroup")]
    public class CorporateCategoryDetail : BaseCategoryDetail
    {

    }
}
