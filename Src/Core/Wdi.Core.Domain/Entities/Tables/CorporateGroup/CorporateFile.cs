using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.CorporateGroup
{
    /// <summary>
    /// Kurumsal Dosyalar
    /// </summary>
    [Table("CorporateLanguage", Schema = "CorporateGroup")]
    public class CorporateFile : BaseFileDetail
    {

    }
}
