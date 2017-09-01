using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KamikazeHungNguyen.Model.Models
{
	[Table("Permissions")]
	public class Permission
	{
		[Key]
		public int Id { set; get; }

		[StringLength(128)]
		public string RoleId { set; get; }

		public bool CanCreate { set; get; }

		public bool CanRead { set; get; }

		public bool CanUpdate { set; get; }

		public bool CanDelete { set; get; }

		[ForeignKey("RoleId")]
		public virtual ApplicationRole ApplicationRoles { set; get; }
	}
}