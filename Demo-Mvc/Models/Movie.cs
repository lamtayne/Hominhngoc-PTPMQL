using System.ComponentModel.DataAnnotations;

namespace Demo_Mvc.Models;

public class Moive
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseData { get; set; }
    public String? Genre { get; set; }
    public Decimal Price { get; set; }
    
}