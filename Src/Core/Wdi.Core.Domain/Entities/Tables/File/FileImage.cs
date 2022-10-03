using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wdi.Core.Domain.Entities.Common;

namespace Wdi.Core.Domain.Entities.Tables.File
{
    /// <summary>
    /// Resimler
    /// </summary>
    [Table("FileImage", Schema = "File")]
    public class FileImage : BaseFile
    {
        /// <summary>
        /// Resim Ölçüleri
        /// </summary>
        [StringLength(50)]
        public string? Measurements { get; set; }
    }
}
