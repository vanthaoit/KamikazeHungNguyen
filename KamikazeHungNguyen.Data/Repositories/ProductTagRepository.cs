using KamikazeHungNguyen.Data.Infrastructure;
using KamikazeHungNguyen.Model.Models;

namespace KamikazeHungNguyen.Data.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    {
    }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}