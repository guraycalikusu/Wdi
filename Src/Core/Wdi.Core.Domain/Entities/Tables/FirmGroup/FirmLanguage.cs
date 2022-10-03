using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.FirmGroup
{
    /// <summary>
    /// Şirket Çevirileri
    /// </summary>
    [Table("FirmLanguage", Schema = "FirmGroup")]
    public class FirmLanguage : BaseLanguage
    {

    }
}
