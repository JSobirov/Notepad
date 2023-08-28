using MyDailyPlan.DAL.IRepositories;
using MyDailyPlan.DAL.Repositories;
using MyDailyPlan.Service4.Interfaces;
using MyDailyPlan.Service4.Mappers;
using MyDailyPlan.Service4.Services;

namespace MyDailyPlan.mvc.Extensions
{
    public static class ServicesCollection
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
