using System.Runtime.CompilerServices;
using WhatchApp.Web.Models;

namespace WhatchApp.Web.Services;

public class WatchService
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
        }
    ];


    public IEnumerable<Watch> GetAll() => watches.OrderBy(watch => watch.Name).ToArray();

    public Watch? GetById(int id) => watches.SingleOrDefault(watch => watch.Id == id);

    public void Add(Watch watch) => watches.Add(watch);
    

}
