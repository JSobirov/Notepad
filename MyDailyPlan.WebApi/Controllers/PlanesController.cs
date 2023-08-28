using Microsoft.AspNetCore.Mvc;
using MyDailyPlan.Service4.DTOs;
using MyDailyPlan.Service4.Interfaces;

namespace MyDailyPlan.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PlanesController : ControllerBase
{
    private readonly IPlanService planService;
    public PlanesController(IPlanService planService)
    {
        this.planService = planService;
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync(PlanCreationDto dto)
    {
        var result = await planService.AddAsync(dto);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(await planService.GetAllAsync());
    }
}
