namespace MyDailyPlan.Domain.Entities;
#nullable disable

public class Plan
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartAt { get; set; }
    public string Duration { get; set; }
    public bool IsTodo { get; set; }
}
