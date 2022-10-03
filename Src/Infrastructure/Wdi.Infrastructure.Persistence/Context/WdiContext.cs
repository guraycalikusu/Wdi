using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Wdi.Core.Domain.Entities.Tables.CorporateGroup;
using Wdi.Core.Domain.Entities.Tables.File;
using Wdi.Core.Domain.Entities.Tables.FirmGroup;
using Wdi.Core.Domain.Entities.Tables.FirmInfo;
using Wdi.Core.Domain.Entities.Tables.General;
using Wdi.Core.Domain.Entities.Tables.Identity;
using Wdi.Core.Domain.Enumerations;

namespace Wdi.Infrastructure.Persistence.Context
{
    public partial class WdiContext : IdentityDbContext<AppUser, AppRole, string>
    {
        #region Corporate Group
        public DbSet<Corporate> Corporate { get; set; }
        public DbSet<CorporateCategory> CorporateCategory { get; set; }
        public DbSet<CorporateCategoryDetail> CorporateCategoryDetail { get; set; }
        public DbSet<CorporateFile> CorporateFile { get; set; }
        public DbSet<CorporateLanguage> CorporateLanguage { get; set; }
        #endregion

        #region File
        public DbSet<FileDocument> FileDocument { get; set; }
        public DbSet<FileImage> FileImage { get; set; }
        public DbSet<FileLanguage> FileLanguage { get; set; }
        public DbSet<FileVideo> FileVideo { get; set; }
        #endregion

        #region Firm Group
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<CorporateAddress> CorporateAddress { get; set; }
        public DbSet<Firm> Firm { get; set; }
        public DbSet<FirmLanguage> FirmLanguage { get; set; }
        #endregion

        #region General
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<UrlList> UrlList { get; set; }
        #endregion

        #region Identity
        public DbSet<AppAuth> AppAuth { get; set; }
        #endregion
    }
    public partial class WdiContext : IdentityDbContext<AppUser, AppRole, string>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            DateTime current = DateTime.Now;

            #region Corporate Group
            builder.Entity<Corporate>().Property(p => p.ContentType).HasConversion(v => v.ToString(), v => (PageContentType)Enum.Parse(typeof(PageContentType), v)).HasDefaultValue(PageContentType.Dynamic);

            builder.Entity<CorporateCategory>().Property(p => p.ContentType).HasConversion(v => v.ToString(), v => (PageContentType)Enum.Parse(typeof(PageContentType), v)).HasDefaultValue(PageContentType.None);

            builder.Entity<CorporateFile>().Property(p => p.FileType).HasConversion(v => v.ToString(), v => (FileType)Enum.Parse(typeof(FileType), v)).HasDefaultValue(FileType.None);

            builder.Entity<CorporateLanguage>().Property(p => p.GroupComponent).HasConversion(v => v.ToString(), v => (GroupComponentType)Enum.Parse(typeof(GroupComponentType), v)).HasDefaultValue(GroupComponentType.None);

            builder.Entity<CorporateLanguage>().Property(p => p.RowComponent).HasConversion(v => v.ToString(), v => (RowComponentType)Enum.Parse(typeof(RowComponentType), v)).HasDefaultValue(RowComponentType.None);

            #endregion

            #region File
            builder.Entity<FileDocument>().Property(p => p.PathType).HasConversion(v => v.ToString(), v => (FilePathType)Enum.Parse(typeof(FilePathType), v)).HasDefaultValue(FilePathType.None);

            builder.Entity<FileImage>().Property(p => p.PathType).HasConversion(v => v.ToString(), v => (FilePathType)Enum.Parse(typeof(FilePathType), v)).HasDefaultValue(FilePathType.None);

            builder.Entity<FileLanguage>().Property(p => p.GroupComponent).HasConversion(v => v.ToString(), v => (GroupComponentType)Enum.Parse(typeof(FilePathType), v)).HasDefaultValue(GroupComponentType.None);

            builder.Entity<FileLanguage>().Property(p => p.RowComponent).HasConversion(v => v.ToString(), v => (RowComponentType)Enum.Parse(typeof(RowComponentType), v)).HasDefaultValue(RowComponentType.None);

            builder.Entity<FileVideo>().Property(p => p.PathType).HasConversion(v => v.ToString(), v => (FilePathType)Enum.Parse(typeof(FilePathType), v)).HasDefaultValue(FilePathType.None);
            #endregion

            #region Firm Group
            builder.Entity<Contact>().Property(p => p.ContactType).HasConversion(v => v.ToString(), v => (ContactType)Enum.Parse(typeof(ContactType), v)).HasDefaultValue(ContactType.None);

            builder.Entity<Contact>().Property(p => p.SocialMedia).HasConversion(v => v.ToString(), v => (SocialMediaType)Enum.Parse(typeof(SocialMediaType), v)).HasDefaultValue(SocialMediaType.None);

            builder.Entity<CorporateAddress>().Property(p => p.GroupComponent).HasConversion(v => v.ToString(), v => (GroupComponentType)Enum.Parse(typeof(GroupComponentType), v)).HasDefaultValue(GroupComponentType.None);

            builder.Entity<CorporateAddress>().Property(p => p.AddressType).HasConversion(v => v.ToString(), v => (AddressType)Enum.Parse(typeof(AddressType), v)).HasDefaultValue(AddressType.None);

            builder.Entity<FirmLanguage>().Property(p => p.GroupComponent).HasConversion(v => v.ToString(), v => (GroupComponentType)Enum.Parse(typeof(GroupComponentType), v)).HasDefaultValue(GroupComponentType.None);

            builder.Entity<FirmLanguage>().Property(p => p.RowComponent).HasConversion(v => v.ToString(), v => (RowComponentType)Enum.Parse(typeof(RowComponentType), v)).HasDefaultValue(RowComponentType.None);
            #endregion

            #region General

            List<City> cities = new List<City> {
                new City{CityCode="1",CountryId=1,CreationDate=current,Id=1,Name="Adana",Recorder="developer",Updater=null,UpdatingDate=null},
                new City{CityCode="1",CountryId=1,CreationDate=current,Id=1,Name="Adana",Recorder="developer",Updater=null,UpdatingDate=null},
            };
            builder.Entity<City>().HasData(null);

            builder.Entity<UrlList>().Property(p => p.Module).HasConversion(v => v.ToString(), v => (Modules)Enum.Parse(typeof(Modules), v)).HasDefaultValue(Modules.None);
            #endregion

            #region Identity
            builder.Entity<AppAuth>().Property(p => p.Module).HasConversion(v => v.ToString(), v => (Modules)Enum.Parse(typeof(Modules), v)).HasDefaultValue(Modules.None);
            #endregion

            
            base.OnModelCreating(builder);
        }
    }
}
