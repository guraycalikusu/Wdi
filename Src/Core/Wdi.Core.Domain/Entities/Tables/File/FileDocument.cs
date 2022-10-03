using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.File
{
    /// <summary>
    /// Dokümanlar
    /// </summary>
    [Table("FileDocument", Schema = "File")]
    public class FileDocument : BaseFile
    {

    }
}
