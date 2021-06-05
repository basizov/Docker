using API.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API
{
  public class Startup
  {
    private readonly IConfiguration _config;

    public Startup(IConfiguration config) => _config = config;

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();
      services.AddApplicationServices(_config);
      // services.AddIdentityServices(_config);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      app.UseRouting();
      app.UseAuthentication();
      // app.UseAuthorization();
      app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
  }
}
