using System.ComponentModel.DataAnnotations;

namespace ApbdRestApi.Models;

public class Visit
{
    public DateTime VisitDateTime { get; set; }
    [Required]
    public Animal Animal { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
}