using System.ComponentModel.DataAnnotations;

namespace WhatchApp.Web.Views.Watches
{
    public class CreateVM
    {

        [Required(ErrorMessage = "You must specify a name")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "You must specify a description")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "You must specify a price")]
        [DisplayFormat(DataFormatString = "{0:N2} €")]
        [Display(Name = "Price €")]
        public required decimal Price { get; set; }

        [Display(Name = "Ref")]
        [Required(ErrorMessage = "You must specify a Reference number")]
        public required string ReferenceNumber { get; set; }
    }
}
