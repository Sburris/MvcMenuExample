using System.Collections.Generic;
using System.Web.Routing;

namespace MvcMenuExample.ViewModels
{
  public class MenuControls
  {
    public IList<IMenuSlot> Items { get; set; }

    public MenuControls()
    {
      Items = new List<IMenuSlot>();
    }
  }

  public interface IMenuSlot { }

  public interface IDropDownMenuSlot { }

  public class MenuItem : IMenuSlot, IDropDownMenuSlot
  {
    public string Text { get; set; }
    public string Action { get; set; }
    public string Controller { get; set; }
    public bool IsActive { get; set; }

    public RouteValueDictionary Routes { get; set; }

    public MenuItem(string text, string action, string controller, RouteValueDictionary routes = null, bool isActive = false)
    {
      Text = text;
      Action = action;
      Controller = controller;
      IsActive = isActive;
      Routes = routes ?? new RouteValueDictionary();
    }
  }

  public class DropDownSlot : IMenuSlot
  {
    public string Text { get; set; }
    public string Action { get; set; }
    public string Controller { get; set; }
    public IList<IDropDownMenuSlot> Items { get; set; }

    public DropDownSlot(string text, string action, string controller)
    {
      Text = text;
      Action = action;
      Controller = controller;

      Items = new List<IDropDownMenuSlot>();
    }
  }

  public class DropDownSeperator : IDropDownMenuSlot { }
}
