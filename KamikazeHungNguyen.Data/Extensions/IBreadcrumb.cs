using System.Collections.Generic;

namespace KamikazeHungNguyen.Data.Extensions
{
    public interface IBreadcrumb<TEntity>
    {
        IEnumerable<TEntity> GetTeamTree(int Id);
    }
}