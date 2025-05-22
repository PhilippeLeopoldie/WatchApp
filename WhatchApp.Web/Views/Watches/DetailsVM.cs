using System.ComponentModel.DataAnnotations;

namespace WhatchApp.Web.Views.Watches;

public class DetailsVM
{

    public  string Name { get; set; }
    public string Description { get; set; }

    [Display(Name = " Price €")]
    public decimal Price { get; set; }

    [Display(Name = "Ref")]
    public string ReferenceNumber { get; set; }
}
