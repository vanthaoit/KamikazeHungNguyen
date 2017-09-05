﻿using KamikazeHungNguyen.Data.Infrastructure;
using KamikazeHungNguyen.Model.Models;

namespace KamikazeHungNguyen.Data.Repositories
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {
    }

    public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}