using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.File
{
    /// <summary>
    /// Dosya Çevirileri
    /// </summary>
    [Table("FileLanguage", Schema = "File")]
    public class FileLanguage : BaseLanguage
    {

    }
}
