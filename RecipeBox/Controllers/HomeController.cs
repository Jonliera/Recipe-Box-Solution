using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
/* using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity; */

namespace RecipeBox.Controllers
{
    public class HomeController : Controller
    {
      private readonly RecipeBoxContext _db;
      // private readonly UserManager<ApplicationUser> _userManager; //

      public HomeController(RecipeBoxContext db)
      {
        // _userManager = userManager;
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {        
        // Recipe[] recipes = _db.Recipes.ToArray();
        // Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        // // model.Add("categories", cats);
        // model.Add("recipes", recipes);
        return View();
      }

      // [HttpGet("/About")]
      public ActionResult About()
      {
        return View();
      }
     }
}