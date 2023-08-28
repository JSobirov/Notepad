using Microsoft.EntityFrameworkCore;
using MyDailyPlan.DAL.Contexts;
using MyDailyPlan.DAL.IRepositories;
using System.Linq.Expressions;

namespace MyDailyPlan.DAL.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext appDbContext;
    private readonly DbSet<T> dbSet;
    public Repository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
        dbSet = appDbContext.Set<T>();
    }

    public async Task CreateAsync(T entity)
    {
        await dbSet.AddAsync(entity);
    }

    public IQueryable<T> SelectAll(Expression<Func<T, bool>> expression = null, bool isNoTracked = true, string include = null)
    {
        IQueryable<T> query = expression is null ? dbSet.AsQueryable() : dbSet.Where(expression).AsQueryable();

        query = isNoTracked ? query.AsNoTracking() : query;

        if (include is not null)
            query = query.Include(include);

        return query;
    }
    public async Task SaveAsync()
    {
        await appDbContext.SaveChangesAsync();
    }

}