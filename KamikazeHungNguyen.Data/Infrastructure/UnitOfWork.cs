namespace KamikazeHungNguyen.Data.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private KamikazeHungNguyenDbContext _dbContext;
		private readonly IDbFactory dbFactory;

		public UnitOfWork(IDbFactory dbFactory)
		{
			this.dbFactory = dbFactory;
		}

		public KamikazeHungNguyenDbContext DbContext
		{
			get { return _dbContext ?? (_dbContext = dbFactory.Init()); }
		}

		public void Commit()
		{
			DbContext.SaveChanges();
		}
	}
}