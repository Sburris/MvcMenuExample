namespace MvcMenuExample.Models
{
  public interface ICurrentUser
  {
    int Id { get; set; }
    string DisplayName { get; set; }
    bool IsLoggedIn { get; set; }
  }

  public class CurrentUser : ICurrentUser
  {
    public int Id { get; set; }

    public string DisplayName { get; set; }

    public bool IsLoggedIn { get; set; }
  }
}
