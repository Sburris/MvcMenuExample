using MvcMenuExample.Models;

namespace MvcMenuExample.Helpers
{
  public class CurrentUserHelper
  {
    public static CurrentUserHelper Instance { get { return Nested.Instance; } }

    // ReSharper disable once ClassNeverInstantiated.Local
    private class Nested
    {
      static Nested() { }

      // ReSharper disable once MemberHidesStaticFromOuterClass
      internal static readonly CurrentUserHelper Instance = new CurrentUserHelper();
    }

    private CurrentUserHelper() { CurrentUser = new CurrentUser(); }
    
    public ICurrentUser CurrentUser { get; private set; }

  }
}
