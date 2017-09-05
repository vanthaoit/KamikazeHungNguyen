using System.Data.Entity;
using KamikazeHungNguyen.Model.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace KamikazeHungNguyen.Data
{
	public class KamikazeHungNguyenDbContext : IdentityDbContext<ApplicationUser>
	{
		public KamikazeHungNguyenDbContext() : base("KamikazeHungNguyenConnection")
		{
			Configuration.LazyLoadingEnabled = false;
		}

		public DbSet<Error> Errors { set; get; }
		public DbSet<Footer> Footers { set; get; }
		public DbSet<Menu> Menus { set; get; }
		public DbSet<MenuGroup> MenuGroups { set; get; }

		public DbSet<Product> Products { set; get; }
		public DbSet<ProductCategory> ProductCategories { set; get; }
		public DbSet<ProductTag> ProductTags { set; get; }
		public DbSet<Tag> Tags { set; get; }
		public DbSet<Permission> Permissions { set; get; }

		protected override void OnModelCreating(DbModelBuilder builder)
		{
			builder.Entity<IdentityRole>().HasKey<string>(x => x.Id).ToTable("ApplicationRoles");
			builder.Entity<IdentityUserLogin>().HasKey(x => x.UserId).ToTable("ApplicationUserLogins");
			builder.Entity<IdentityUserRole>().HasKey(x => new { x.UserId, x.RoleId }).ToTable("ApplicationUserRoles");
		}

		public static KamikazeHungNguyenDbContext Create()
		{
			return new KamikazeHungNguyenDbContext();
		}
	}
}