namespace MyDailyPlan.Service4.DTOs;
#nullable disable

public class PlanCreationDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartAt { get; set; }
    public string Duration { get; set; }
    public string IsTodo { get; set; }
}
