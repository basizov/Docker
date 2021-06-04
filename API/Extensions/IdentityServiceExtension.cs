using Domain.Entities;
using Infrstructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
  public static class IdentityServiceExtension
  {
    public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
    {
      services.AddIdentityCore<User>(opt =>
        {
          opt.Password.RequireNonAlphanumeric = false;
          opt.SignIn.RequireConfirmedEmail = false;
        })
        .AddEntityFrameworkStores<DataContext>()
        .AddSignInManager<SignInManager<User>>()
        .AddDefaultTokenProviders();
      return (services);
    }
  }
}