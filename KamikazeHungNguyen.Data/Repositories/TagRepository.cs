using KamikazeHungNguyen.Data.Infrastructure;
using KamikazeHungNguyen.Model.Models;

namespace KamikazeHungNguyen.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}