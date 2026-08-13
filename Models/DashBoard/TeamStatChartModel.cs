namespace TyphoonTaskingTool.Models.DashBoard
{
    public class TeamStatChartModel
    {

        public int? TeamId { get; set; }
        public string? TeamName { get; set; }
        public string? TeamNameLong { get; set; }
        public string[] Labels { get; set; }
        public double[] Data { get; set; }
        public List<StatusBreakdown> Statuses { get; set; } = new();
    }

public class StatusBreakdown
{
    public int? StatusId { get; set; }
    public string? StatusName { get; set; }
    public int? Count { get; set; }
}
}
