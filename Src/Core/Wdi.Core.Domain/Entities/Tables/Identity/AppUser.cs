using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Wdi.Core.Domain.Entities.Tables.Identity
{
    /// <summary>
    /// Kullanıcılar
    /// </summary>
    public class AppUser : IdentityUser
    {
        /// <summary>
        /// Kullanıcı Adı
        /// </summary>
        [StringLength(250), Required]
        public string Name { get; set; }
        /// <summary>
        /// Kullanıcı Resmi
        /// </summary>
        [StringLength(250)]
        public string? Image { get; set; }
    }
}
