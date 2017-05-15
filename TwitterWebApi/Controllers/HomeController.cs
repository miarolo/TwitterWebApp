using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Threading.Tasks;
using TWA.Interfaces.Services;
using TWA.Models;

namespace TwitterWebApi.Controllers
{
	public class HomeController : Controller
	{
        private ITwitterService _twitService;

        public HomeController(ITwitterService twitService)
        {
            _twitService = twitService;
        }

        public async Task<ActionResult> Index()
		{
			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            List<TweetViewModel> tweets = await _twitService.GetTweets();

            return View(tweets);
		}
	}
}
