using Microsoft.EntityFrameworkCore;

namespace Appglobal.Base.Abstract;

public abstract class Repository<T> : IRepository<T> where T : class
{
    public DbContext DbContext { get; private set; }

    public DbSet<T> Entities => DbContext.Set<T>();

    public Repository(DbContext dbContext)
    {
        this.DbContext = dbContext;
    }

    public virtual async Task AddAsync(T entity)
    {
        await Entities.AddAsync(entity);
    }

    public virtual async Task AddRangeAsync(IEnumerable<T> entities)
    {
        await Entities.AddRangeAsync(entities);
    }

    public virtual T? Find(params object[] keyValues)
    {
        return Entities.Find(keyValues);
    }

    public virtual async Task<T?> FindAsync(params object[] keyValues)
    {
        return await Entities.FindAsync(keyValues);
    }

    public virtual async Task<IList<T>> GetAllAsync()
    {
        return await Entities.ToListAsync();
    }

    public virtual void RemoveAsync(T entity)
    {
        Entities.Attach(entity);
        Entities.Remove(entity);  
    }

    public virtual void RemoveRangeAsync(IEnumerable<T> entities)
    {
        var res = entities as T[] ?? entities.ToArray();
        if (res.Any()) Entities.RemoveRange(res);
        Entities.RemoveRange(entities);
    }
}