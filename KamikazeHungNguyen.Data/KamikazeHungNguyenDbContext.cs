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

		private DbSet<Error> Errors { set; get; }
		private DbSet<Footer> Footers { set; get; }
		private DbSet<Menu> Menus { set; get; }
		private DbSet<MenuGroup> MenuGroups { set; get; }

		private DbSet<Product> Products { set; get; }
		private DbSet<ProductCategory> ProductCategorys { set; get; }
		private DbSet<ProductTag> ProductTags { set; get; }
		private DbSet<Tag> Tags { set; get; }
		private DbSet<Permission> Permissions { set; get; }

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