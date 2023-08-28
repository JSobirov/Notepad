using System.Linq.Expressions;

namespace MyDailyPlan.DAL.IRepositories;

public interface IRepository<T> where T : class
{
    Task CreateAsync(T entity);
    IQueryable<T> SelectAll(Expression<Func<T, bool>> expression = null, bool isNoTracked = true, string include = null);
    Task SaveAsync();
}
