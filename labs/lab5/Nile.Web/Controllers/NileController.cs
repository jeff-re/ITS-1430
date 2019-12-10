/*
 * Geoffrey Kio
 * ITSE 1430
 * 12/8/2019
 */
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
        public ActionResult Index()
        {
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

                return RedirectToAction ("Index");
            } catch (Exception e)
            {
                ModelState.AddModelError ("", e.Message);
            };

            return View (model);
        }

        [HttpGet]
        public ActionResult Edit ( int id )
        {
            var product = _database.Get (id);
            if (product == null)
                return HttpNotFound ();

            var model = product.ToModel ();
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
                    _database.Update (Product);

                    return RedirectToAction ("Edit", new { id = Product.Id });
                };
            } catch (Exception e)
            {
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
                    var product = model.ToDomain ();
                    _database.Add (product);

                    return RedirectToAction ("Index");
                };
            } catch (Exception e)
            {
                ModelState.AddModelError ("", e.Message);
            };

            return View (model);
        }

        [HttpGet]
        public ActionResult Details ( int id )
        {
            var product = _database.Get (id);
            if (product == null)
                return HttpNotFound ();

            var model = product.ToModel ();
            return View (model);
        }

        private  IProductDatabase _database;
    }
}