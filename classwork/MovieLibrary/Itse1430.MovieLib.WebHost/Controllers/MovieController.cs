using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Itse1430.MovieLib.SqlServer;
using Itse1430.MovieLib.WebHost.Models;

namespace Itse1430.MovieLib.WebHost.Controllers
{
    public class MovieController : Controller
    {

        public MovieController ()
        {
            var connString = ConfigurationManager.ConnectionStrings["MovieDatabase"];
            _database = new SqlMovieDatabase (connString.ConnectionString);
        }
        // GET: Movie
        [HttpGet]
        public ActionResult Index ()
        {
            var items = _database.GetAll ()
                                 .OrderBy (x => x.Title)
                                 .ThenBy (x => x.ReleaseYear);

            var model = items.Select (i => i.ToModel ());
            
            return View (model);
        }
        [HttpGet]
        public ActionResult Create ()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Create ( MovieModel model)
        {
            //Validate
            //Save if valid
            try
            {
                //Save if valid
                var movie = model.ToDomain ();
                _database.Add (movie);
                return RedirectToAction ("Index");
            } catch (Exception e)
            {
                return View (model);

            };
            
        }
        private readonly IMovieDatabase _database;
    }
}