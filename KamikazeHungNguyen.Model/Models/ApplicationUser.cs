using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace KamikazeHungNguyen.Model.Models
{
	[Table("ApplicationUsers")]
	public class ApplicationUser : IdentityUser
	{
		[MaxLength(256)]
		public string FullName { set; get; }

		[MaxLength(256)]
		public string Address { set; get; }

		public string Avatar { set; get; }

		public DateTime? BirthDay { set; get; }

		public bool? Status { set; get; }

		public bool? Gender { set; get; }

		public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
		{
			// Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType by DefaultAuthenticationTypes.ApplicationCookie parameter
			var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
			// Add custom user claims here
			return userIdentity;
		}
	}
}