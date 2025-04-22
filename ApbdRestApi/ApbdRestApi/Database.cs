using ApbdRestApi.Enums;
using ApbdRestApi.Models;

namespace ApbdRestApi;

public static class Database
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal() { Id = 1, Name = "Szarik", Category = AnimalCategory.Dog, FurColor = "Black", Weight = 45.5f },
        new Animal() { Id = 2, Name = "Mruczek", Category = AnimalCategory.Cat, FurColor = "Orange", Weight = 8 },
        new Animal() { Id = 3, Name = "Hopek", Category = AnimalCategory.Rabbit, FurColor = "Gray", Weight = 5.4f },
        new Animal() { Id = 4, Name = "Cwirek", Category = AnimalCategory.Bird, FurColor = "Brown", Weight = 0.6f },
    };
    public static List<Visit> Visits = new List<Visit>()
    {
        new Visit() { VisitDateTime = DateTime.Now.AddDays(-30), Animal = Animals[0], Description = "Szczepienie", Price = 50 },
        new Visit() { VisitDateTime = DateTime.Now.AddDays(-30), Animal = Animals[0], Description = "Sterylizacja", Price = 800 },
        new Visit() { VisitDateTime = DateTime.Now.AddDays(-60), Animal = Animals[1], Description = "Sterylizacja", Price = 600 },
    };
}