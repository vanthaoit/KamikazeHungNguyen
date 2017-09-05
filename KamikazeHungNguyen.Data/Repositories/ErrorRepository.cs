using KamikazeHungNguyen.Data.Infrastructure;
using KamikazeHungNguyen.Model.Models;

namespace KamikazeHungNguyen.Data.Repositories
{
	public interface IErrorRepository : IRepository<Error>
	{
	}

	public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
	{
		public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
		{
		}
	}
}