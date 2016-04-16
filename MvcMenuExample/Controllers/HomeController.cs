using System.Web.Mvc;
using MvcMenuExample.ViewModels;

namespace MvcMenuExample.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Display(string text)
    {
      var data = new DisplayData();

      data.Text = text;

      return View(data);
    }

    public ActionResult Users()
    {
      return View();
    }

    public ActionResult Products()
    {
      return View();
    }

    public ActionResult Register()
    {
      return View();
    }
  }
}