using Microsoft.EntityFrameworkCore;
using MusicApp.Models;

namespace MusicApp.Data{
  public class AppDbContext: DbContext
  {
    //constructor:
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){

    }
      // Create a DbSet for each model class
    public DbSet<Artist> Artists{get; set;} = null!;
     //initializes with a null value, which will be replaced when the context is configured.
  }
}