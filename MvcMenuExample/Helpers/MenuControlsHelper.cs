using System.Web.Routing;
using MvcMenuExample.Models;
using MvcMenuExample.ViewModels;

namespace MvcMenuExample.Helpers
{
  public static class MenuControlsHelper
  {
    public static MenuControls GenerateMenu(MenuPages currentPage, ICurrentUser currentUser)
    {
      var menuControls = new MenuControls();

      var tagDropDown = new DropDownSlot("Display", "Display", "Home");
      tagDropDown.Items.Add(new MenuItem("Blank", "Display", "Home"));
      tagDropDown.Items.Add(new DropDownSeperator());
      tagDropDown.Items.Add(new MenuItem("Foo", "Display", "Home", new RouteValueDictionary { { "text", "Foo" } }));
      tagDropDown.Items.Add(new MenuItem("Bar", "Display", "Home", new RouteValueDictionary { { "text", "Bar" } }));
      tagDropDown.Items.Add(new MenuItem("FooBar", "Display", "Home", new RouteValueDictionary { { "text", "FooBar" } }));
      menuControls.Items.Add(tagDropDown);

      menuControls.Items.Add(new MenuItem("Users", "Users", "Home", isActive: currentPage == MenuPages.Users));

      menuControls.Items.Add(new MenuItem("Products", "Products", "Home", isActive: currentPage == MenuPages.Products));
      
      if (currentUser.IsLoggedIn)
      {
        menuControls.Items.Add(new MenuItem("My Profile", "Index", "Home", isActive: currentPage == MenuPages.Profile));
      }
      else
      {
        menuControls.Items.Add(new MenuItem("Register", "Register", "Home", isActive: currentPage == MenuPages.Register));
      }

      return menuControls;
    }

    public enum MenuPages
    {
      None,
      Users,
      Products,
      Register,
      Login,
      Profile
    }
  }
}
