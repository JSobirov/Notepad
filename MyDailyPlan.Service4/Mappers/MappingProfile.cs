using AutoMapper;
using MyDailyPlan.Domain.Entities;
using MyDailyPlan.Service4.DTOs;

namespace MyDailyPlan.Service4.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Plan, PlanResultDto>().ReverseMap();
        CreateMap<PlanCreationDto, Plan>().ReverseMap();
    }
}
