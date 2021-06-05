using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrstructure
{
  public class Seed
  {
    public static async Task SeedDataAsync(DataContext context)
    {
      var users = new List<User>();

      if (!context.Users.Any())
      {
        users.AddRange(
          new List<User>
          {
            new User { FIO = "boris" },
            new User { FIO = "adel" },
            new User { FIO = "vova" }
          }
        );

        await context.Users.AddRangeAsync(users);
        await context.SaveChangesAsync();
      }
    }
  }
}