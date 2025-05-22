using System.ComponentModel.DataAnnotations;

namespace WhatchApp.Web.Models;

public class Watch
{
    public int Id { get; set; }
    //[Required (ErrorMessage = "You must specify a name")]
    public string Name { get; set; }

    //[Required(ErrorMessage = "You must specify a description")]
    public string Description { get; set; }

    //[Required(ErrorMessage = "You must specify a price")]
    //[DisplayFormat(DataFormatString = "{0:N2} €")]
    public decimal Price { get; set; }

    //[Display(Name = "Ref")]
    //[Required(ErrorMessage = "You must specify a Reference number")]
    public string ReferenceNumber { get; set; }

}
