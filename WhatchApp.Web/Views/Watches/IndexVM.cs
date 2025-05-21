namespace WhatchApp.Web.Views.Watches;

public class IndexVM
{
    public WatchVM[] WatchVMs { get; set; } = null!;
    public class WatchVM
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public required string ReferenceNumber { get; set; }
    }
}
