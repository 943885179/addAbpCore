using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace adminAbp.EntityFrameworkCore.Repositories
{
    public abstract class ArticleRepository<TEntity, TPrimaryKey> : EfCoreRepositoryBase<adminAbpDbContext1, TEntity, TPrimaryKey>
   where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ArticleRepository(IDbContextProvider<adminAbpDbContext1> dbContextProvider) : base(dbContextProvider)
        {
        }
    }  
    /// <summary>
         /// Base class for custom repositories of the application.
         /// </summary>
         /// <typeparam name="TEntity">Entity type</typeparam>
         /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class adminAbpRepositoryBase1<TEntity, TPrimaryKey> : EfCoreRepositoryBase<adminAbpDbContext1, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected adminAbpRepositoryBase1(IDbContextProvider<adminAbpDbContext1> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="adminAbpRepositoryBase1{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class adminAbpRepositoryBase1<TEntity> : adminAbpRepositoryBase1<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected adminAbpRepositoryBase1(IDbContextProvider<adminAbpDbContext1> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
