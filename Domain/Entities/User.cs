using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
  public class User : IdentityUser
  {
    /// <summary>
    /// ФИО пользователя
    /// </summary>
    public string FIO { get; set; }
    /// <summary>
    /// Возраст пользователя
    /// </summary>
    public int Age { get; set; }
  }
}