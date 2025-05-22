using System.ComponentModel.DataAnnotations;

namespace WhatchApp.Web.Models;

public class Watch
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public string ReferenceNumber { get; set; } = string.Empty;

}
