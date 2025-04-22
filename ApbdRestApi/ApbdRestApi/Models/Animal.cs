using System.ComponentModel.DataAnnotations;
using ApbdRestApi.Enums;

namespace ApbdRestApi.Models;

public class Animal
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public AnimalCategory Category { get; set; }
    public float Weight { get; set; }
    public string FurColor { get; set; }
}