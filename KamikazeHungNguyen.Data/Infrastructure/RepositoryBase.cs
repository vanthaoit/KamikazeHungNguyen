using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace KamikazeHungNguyen.Data.Infrastructure
{
	public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
	{
		#region Properties

		private KamikazeHungNguyenDbContext dataContext;

		protected IDbFactory dbFactory
		{
			get;
			private set;
		}

		protected KamikazeHungNguyenDbContext DbContext
		{
			get { return dataContext ?? (dataContext = dbFactory.Init()); }
		}

		private readonly IDbSet<TEntity> dbSet;

		#endregion Properties

		#region Implementations
		public RepositoryBase(IDbFactory dbFactory) {
			this.dbFactory = dbFactory;
			dbSet = DbContext.Set<TEntity>();
		}

		public TEntity Add(TEntity entity)
		{
			return dbSet.Add(entity);
		}

		public bool CheckContains(Expression<Func<TEntity, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public int Count(Expression<Func<TEntity, bool>> where)
		{
			throw new NotImplementedException();
		}

		public TEntity Delete(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public virtual TEntity Delete(int id)
		{
			var entity = dbSet.Find(id);
			return dbSet.Remove(entity);
		}

		public void DeleteMulti(Expression<Func<TEntity, bool>> where)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TEntity> GetAll(string[] includes = null)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TEntity> GetMulti(Expression<Func<TEntity, bool>> predicate, string[] includes = null)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TEntity> GetMultiPaging(Expression<Func<TEntity, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
		{
			throw new NotImplementedException();
		}

		public TEntity GetSingleByCondition(Expression<Func<TEntity, bool>> expression, string[] includes = null)
		{
			throw new NotImplementedException();
		}

		public TEntity GetSingleById(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(TEntity entity)
		{
			dbSet.Attach(entity);
			dataContext.Entry(entity).State = EntityState.Modified;
		}

		#endregion Implementations
	}
}