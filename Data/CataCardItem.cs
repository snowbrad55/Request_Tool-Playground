using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TyphoonTaskingTool.Data
{
    public class CataCardItem
    {
        public string title { get; set; } 
        public string imagePath { get; set; } 
        public string description { get; set; }
        public string warning { get; set; } 
        public Type DialogComponent { get; set; }

    }
}
