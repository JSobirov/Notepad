using Microsoft.AspNetCore.Mvc;
using MyDailyPlan.Service4.Interfaces;
using System.Reflection.Metadata;

namespace MyDailyPlan.mvc.Controllers
{
    public class PlansController : Controller
    {
        private readonly IPlanService planService;
        public PlansController(IPlanService planService)
        {
            this.planService = planService;
        }
        public async Task<IActionResult> GetUser(long id)
        {
            var data = (await planService.GetAllAsync()).FirstOrDefault(i => i.Id.Equals(id));
            return View(data);
        }
        public async Task<IActionResult> Index()
        {
            var plans = (await this.planService.GetAllAsync()).OrderByDescending(i => i.IsTodo);
            return View(plans);
        }
    }
}
