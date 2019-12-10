using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nile.Stores.Sql;
using Nile.Web.Models;

namespace Nile.Web.Controllers
{
    public class NileController : Controller
    {

        public NileController ()
        {
            var connString = ConfigurationManager.ConnectionStrings["ProductDatabase"];
            _database = new SqlProductDatabase (connString.ConnectionString);
        }
        // GET: Nile
        public ActionResult Index()
        {
            //var product = from p in _database.GetAll ()
            //              orderby p.Name
            //              select p;

            // _database.DataSource = product;
            //return View();
            var items = _database.GetAll ()
                                .OrderBy (p => p.Name);
                            

            var model = items.Select (i => i.ToModel ());

            return View (model);
        }

        [HttpGet]
        public ActionResult Create ()
        {
            return View ();
        }

        [HttpGet]
        public ActionResult Delete ( int id )
        {
            var product = _database.Get (id);
            if (product == null)
                return HttpNotFound ();

            var model = product.ToModel ();
            return View (model);
        }

        [HttpPost]
        public ActionResult Delete ( ProductModel model )
        {
            try
            {
                _database.Remove (model.Id);

                //PRG 
                return RedirectToAction ("Index");
            } catch (Exception e)
            {
                //Don't use Exception overload - doesn't work
                ModelState.AddModelError ("", e.Message);
            };

            return View (model);
        }

        [HttpGet]
        public ActionResult Edit ( int id )
        {
            var movie = _database.Get (id);
            if (movie == null)
                return HttpNotFound ();

            var model = movie.ToModel ();
            return View (model);
        }

        [HttpPost]
        public ActionResult Edit ( ProductModel model )
        {
            try
            {
                //Validate
                if (ModelState.IsValid)
                {
                    //Save if valid
                    var Product = model.ToDomain ();
                    _database.Update ( Product);

                    //PRG 
                    return RedirectToAction ("Edit", new { id = Product.Id });
                };
            } catch (Exception e)
            {
                //Don't use Exception overload - doesn't work
                ModelState.AddModelError ("", e.Message);
            };

            return View (model);
        }

        [HttpPost]
        public ActionResult Create ( ProductModel model )
        {
            try
            {
                //Validate
                if (ModelState.IsValid)
                {
                    //Save if valid
                    var movie = model.ToDomain ();
                    _database.Add (movie);

                    //PRG 
                    return RedirectToAction ("Index");
                };
            } catch (Exception e)
            {
                //Don't use Exception overload - doesn't work
                ModelState.AddModelError ("", e.Message);
            };

            return View (model);
        }

        private  IProductDatabase _database;
    }
}