using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.CorporateGroup
{
    /// <summary>
    /// Kurumsal Tablolarına Ait Dil Çevirileri
    /// </summary>
    [Table("CorporateLanguage", Schema = "CorporateGroup")]
    public class CorporateLanguage : BaseLanguage
    {

    }
}
