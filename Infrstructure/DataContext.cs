using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrstructure
{
  public class DataContext : DbContext
  {
    public DbSet<User> Users { get; set; }
    
    // docker run --name dev -e POSTGRES_USER=admin -e POSTGRES_PASSWORD=secret -p 5432:5432 -d postgres:latest
    public DataContext(DbContextOptions options) : base(options) { }
  }
}