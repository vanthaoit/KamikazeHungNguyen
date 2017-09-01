namespace KamikazeHungNguyen.Data.Infrastructure
{
	public class DbFactory : Disposable, IDbFactory
	{
		private KamikazeHungNguyenDbContext dbContext;

		public KamikazeHungNguyenDbContext Init()
		{
			return dbContext ?? (dbContext = new KamikazeHungNguyenDbContext());
		}

		protected override void DisposeCore()
		{
			if (dbContext != null)
			{
				dbContext.Dispose();
			}
		}
	}
}