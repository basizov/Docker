using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
  public class User
  {
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public int Id { get; set; }
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