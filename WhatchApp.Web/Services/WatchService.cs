using System.Runtime.CompilerServices;
using WhatchApp.Web.Models;

namespace WhatchApp.Web.Services;

public class WatchService : IWatchService
{
    public List<Watch> watches =
    [
        new Watch()
        {
            Id = 1,
            Name = "Club Sport neomatik 39 smoke",
            Description = "The sunburst polishing of the galvanized dial lets the smoky light gray tone glow richly—and with a great deal of character." +
                " This sporty NOMOS automatic watch represents style and connoisseurship." +
                " It adds luster without being overbearing. In a robust stainless steel case with a polished and satin-finished stainless steel link bracelet, " +
                "Club Sport neomatik 39 smoke is water-resistant to 20 atm and," +
                " at the same time, unusually slim with a height of just 8.5 millimeters. Inside the automatic caliber DUW 3001 with a proprietary escapement," +
                " the NOMOS swing system, is at work.",
            Price = 3240,
            ReferenceNumber = "764",
        },
         new Watch()
        {
            Id = 2,
            Name = "Omega Seamaster Diver 300M",
            Description = "A classic professional dive watch featuring a ceramic bezel and wave-patterned dial." +
                " With a helium escape valve and co-axial movement, it's a favorite among divers and style enthusiasts alike.",
            Price = 5100,
            ReferenceNumber = "210.30.42.20.01.001",
        },
        new Watch()
        {
            Id = 3,
            Name = "Rolex Submariner Date",
            Description = "An iconic timepiece that needs no introduction. The Submariner is robust, reliable, and instantly recognizable," +
                " with a unidirectional rotatable bezel and luminescent hour markers.",
            Price = 10900,
            ReferenceNumber = "126610LN",
        },
        new Watch()
        {
            Id = 4,
            Name = "TAG Heuer Carrera Calibre 5",
            Description = "Elegant and sporty, this Carrera features a clean dial design and fine-brushed steel case." +
                " Powered by the reliable Calibre 5 automatic movement, it bridges classic and modern watchmaking.",
            Price = 2650,
            ReferenceNumber = "WAR211A.BA0782",
        },
        new Watch()
        {
            Id = 5,
            Name = "Tissot Gentleman Powermatic 80 Silicium",
            Description = "A versatile dress watch with high-tech specs. It boasts an 80-hour power reserve and silicon balance spring," +
                " offering precision and resistance to magnetic fields at an entry-level luxury price point.",
            Price = 825,
            ReferenceNumber = "T127.407.11.041.00",
        },
        new Watch()
        {
            Id = 6,
            Name = "Grand Seiko Snowflake",
            Description = "Renowned for its textured dial inspired by snow-covered Japanese landscapes, the Snowflake features the Spring Drive movement" +
                " combining quartz precision with mechanical craftsmanship.",
            Price = 6200,
            ReferenceNumber = "SBGA211",
        }
    ];


    public IEnumerable<Watch> GetAll() => watches.OrderBy(watch => watch.Name).ToArray();

    public Watch? GetById(int id) => watches.SingleOrDefault(watch => watch.Id == id);

    public void Add(Watch watch)
    {
        watch.Id = watches.Count() == 0 ? 1 : watches.Max(watch => watch.Id) + 1;
        watches.Add(watch);
    }

}
