using MyDailyPlan.Service4.DTOs;

namespace MyDailyPlan.Service4.Interfaces;

public interface IPlanService
{
    Task<PlanResultDto> AddAsync(PlanCreationDto dto);
    Task<IEnumerable<PlanResultDto>> GetAllAsync();
}
