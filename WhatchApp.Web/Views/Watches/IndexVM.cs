using System.ComponentModel.DataAnnotations;

namespace WhatchApp.Web.Views.Watches;

public class IndexVM
{
    public WatchVM[] WatchVMs { get; set; } = null!;
    public class WatchVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
