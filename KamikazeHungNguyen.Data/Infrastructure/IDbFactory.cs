using System;

namespace KamikazeHungNguyen.Data.Infrastructure
{
	public interface IDbFactory : IDisposable
	{
		KamikazeHungNguyenDbContext Init();
	}
}