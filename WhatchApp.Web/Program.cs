using WhatchApp.Web.Services;

namespace WhatchApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IWatchService,WatchService>();
            var app = builder.Build();
            app.MapControllers();
            app.Run();
        }
    }
}
