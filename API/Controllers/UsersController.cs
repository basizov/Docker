using System.Threading.Tasks;
using Core.Users;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  public class UsersController : BaseController
  {
    [HttpGet]
    public async Task<IActionResult> GetUsers() =>
      HandleResult(await Mediator.Send(new List.Query { }));
  }
}