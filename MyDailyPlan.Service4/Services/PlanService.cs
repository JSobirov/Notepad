using AutoMapper;
using MyDailyPlan.DAL.IRepositories;
using MyDailyPlan.Domain.Entities;
using MyDailyPlan.Service4.DTOs;
using MyDailyPlan.Service4.Interfaces;

namespace MyDailyPlan.Service4.Services;

public class PlanService : IPlanService
{
    private readonly IMapper mapper;
    private readonly IRepository<Plan> repository;
    public PlanService(IRepository<Plan> repository, IMapper mapper)
    {
        this.mapper = mapper;
        this.repository = repository;
    }
    public async Task<PlanResultDto> AddAsync(PlanCreationDto dto)
    {
        var mappedPlan = this.mapper.Map<Plan>(dto);
        await this.repository.CreateAsync(mappedPlan);
        await this.repository.SaveAsync();

        var result = this.mapper.Map<PlanResultDto>(mappedPlan);
        return result;
    }

    public async Task<IEnumerable<PlanResultDto>> GetAllAsync()
    {
        var plans = this.repository.SelectAll();
        var result = this.mapper.Map<IEnumerable<PlanResultDto>>(plans);
        return result;
    }
}
