using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Taco", Age = 9, Breed = "Pitbull" },
          new Dog { DogId = 2, Name = "Max Jellybean", Age = 4, Breed = "Chihuahua mix" },
          new Dog { DogId = 3, Name = "Boo", Age = 10, Breed = "Huskie" }
        );
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Moonbeam", Age = 8, Breed = "Maine Coon" },
          new Cat { CatId = 1, Name = "Kittie", Age = 15, Breed = "Mix" },
          new Cat { CatId = 1, Name = "Bella", Age = 6, Breed = "Tabby Cat" }
        );
    }
  }
}