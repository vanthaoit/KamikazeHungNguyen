using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace KamikazeHungNguyen.Model.Models
{
	[Table("ApplicationRoles")]
	public class ApplicationRole : IdentityRole
	{
		public ApplicationRole() : base()
		{
		}

		public ApplicationRole(string name, string description) : base(name)
		{
		}
		public virtual string Description { get; set; }
	}
}