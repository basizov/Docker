using Core.Base;
using Core.Users;
using Infrstructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
  public static class ApplicationServiceExtension
  {
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
      services.AddDbContext<DataContext>(opt => opt.UseNpgsql(config.GetConnectionString("DefaultConnection")));
      services.AddMediatR(typeof(List.Query).Assembly);
      services.AddAutoMapper(typeof(MappingProfiles).Assembly);
      return (services);
    }
  }
}