namespace MyDailyPlan.Service4.DTOs;

public class PlanResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public DateTime StartAt { get; set; }
    public string Duration { get; set; }
    public string IsTodo { get; set; }
    public string Description { get; set; }
}
