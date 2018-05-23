using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RecipeWebsite.Models;
using System.Diagnostics;
using System.Data.Entity.Validation;
using System.Threading.Tasks;

namespace RecipeWebsite.Controllers
{
    [Authorize]
    public class RecipesController : Controller
    {
        private DBEntities db = new DBEntities();

        // GET: Recipes
        public ActionResult Index(string q, string vegan, bool chkBxVegan = false, bool chkBxVegetarian = false, bool chkBxPescatarian = false)
        {
            //List<string> veganBlackList = new List<string> { "meat"(done), "margarine", "goose", "chicken"(done), "pork"(done), "milk(done)", "egg(done)", "beef"(done), "butter(done)", "cream(done)", "cheese"(cheese), "fish(done)", "shellfish"(done), "lamb"(done), "gelatine"(done), "honey"(done), "turkey"(done), "duck(done)", "pheasent"(done), "mutton"(done) };
            var recipes = from m in db.Recipes select m;
            if (!String.IsNullOrEmpty(q))
            {
                if (chkBxVegan == true)
                {
                    Debug.WriteLine("vegan mode is on");
                    recipes = recipes.Where(a => !a.Ingrediant1.Contains("chicken") && !a.Ingrediant2.Contains("chicken") && !a.Ingrediant3.Contains("chicken") && !a.Ingrediant4.Contains("chicken") && !a.Ingrediant5.Contains("chicken") && !a.Ingrediant6.Contains("chicken") && !a.Ingrediant7.Contains("chicken") && !a.Ingrediant8.Contains("chicken") && !a.Ingrediant9.Contains("chicken") && !a.Ingrediant10.Contains("chicken") && !a.Ingrediant1.Contains("mutton") && !a.Ingrediant2.Contains("mutton") && !a.Ingrediant3.Contains("mutton") && !a.Ingrediant4.Contains("mutton") && !a.Ingrediant5.Contains("mutton") && !a.Ingrediant6.Contains("mutton") && !a.Ingrediant7.Contains("mutton") && !a.Ingrediant8.Contains("mutton") && !a.Ingrediant9.Contains("mutton") && !a.Ingrediant10.Contains("mutton") && !a.Ingrediant1.Contains("pheasent") && !a.Ingrediant2.Contains("pheasent") && !a.Ingrediant3.Contains("pheasent") && !a.Ingrediant4.Contains("pheasent") && !a.Ingrediant5.Contains("pheasent") && !a.Ingrediant6.Contains("pheasent") && !a.Ingrediant7.Contains("pheasent") && !a.Ingrediant8.Contains("pheasent") && !a.Ingrediant9.Contains("pheasent") && !a.Ingrediant10.Contains("pheasent") && !a.Ingrediant1.Contains("duck") && !a.Ingrediant2.Contains("duck") && !a.Ingrediant3.Contains("duck") && !a.Ingrediant4.Contains("duck") && !a.Ingrediant5.Contains("duck") && !a.Ingrediant6.Contains("duck") && !a.Ingrediant7.Contains("duck") && !a.Ingrediant8.Contains("duck") && !a.Ingrediant9.Contains("duck") && !a.Ingrediant10.Contains("duck") && !a.Ingrediant1.Contains("turkey") && !a.Ingrediant2.Contains("turkey") && !a.Ingrediant3.Contains("turkey") && !a.Ingrediant4.Contains("turkey") && !a.Ingrediant5.Contains("turkey") && !a.Ingrediant6.Contains("turkey") && !a.Ingrediant7.Contains("turkey") && !a.Ingrediant8.Contains("turkey") && !a.Ingrediant9.Contains("turkey") && !a.Ingrediant10.Contains("turkey") && !a.Ingrediant1.Contains("honey") && !a.Ingrediant2.Contains("honey") && !a.Ingrediant3.Contains("honey") && !a.Ingrediant4.Contains("honey") && !a.Ingrediant5.Contains("honey") && !a.Ingrediant6.Contains("honey") && !a.Ingrediant7.Contains("honey") && !a.Ingrediant8.Contains("honey") && !a.Ingrediant9.Contains("honey") && !a.Ingrediant10.Contains("honey") && !a.Ingrediant1.Contains("gelatine") && !a.Ingrediant2.Contains("gelatine") && !a.Ingrediant3.Contains("gelatine") && !a.Ingrediant4.Contains("gelatine") && !a.Ingrediant5.Contains("gelatine") && !a.Ingrediant6.Contains("gelatine") && !a.Ingrediant7.Contains("gelatine") && !a.Ingrediant8.Contains("gelatine") && !a.Ingrediant9.Contains("gelatine") && !a.Ingrediant10.Contains("gelatine") && !a.Ingrediant1.Contains("lamb") && !a.Ingrediant2.Contains("lamb") && !a.Ingrediant3.Contains("lamb") && !a.Ingrediant4.Contains("lamb") && !a.Ingrediant5.Contains("lamb") && !a.Ingrediant6.Contains("lamb") && !a.Ingrediant7.Contains("lamb") && !a.Ingrediant8.Contains("lamb") && !a.Ingrediant9.Contains("lamb") && !a.Ingrediant10.Contains("lamb") && !a.Ingrediant1.Contains("shellfish") && !a.Ingrediant2.Contains("shellfish") && !a.Ingrediant3.Contains("shellfish") && !a.Ingrediant4.Contains("shellfish") && !a.Ingrediant5.Contains("shellfish") && !a.Ingrediant6.Contains("shellfish") && !a.Ingrediant7.Contains("shellfish") && !a.Ingrediant8.Contains("shellfish") && !a.Ingrediant9.Contains("shellfish") && !a.Ingrediant10.Contains("shellfish") && !a.Ingrediant1.Contains("fish") && !a.Ingrediant2.Contains("fish") && !a.Ingrediant3.Contains("fish") && !a.Ingrediant4.Contains("fish") && !a.Ingrediant5.Contains("fish") && !a.Ingrediant6.Contains("fish") && !a.Ingrediant7.Contains("fish") && !a.Ingrediant8.Contains("fish") && !a.Ingrediant9.Contains("fish") && !a.Ingrediant10.Contains("fish") && !a.Ingrediant1.Contains("cheese") && !a.Ingrediant2.Contains("cheese") && !a.Ingrediant3.Contains("cheese") && !a.Ingrediant4.Contains("cheese") && !a.Ingrediant5.Contains("cheese") && !a.Ingrediant6.Contains("cheese") && !a.Ingrediant7.Contains("cheese") && !a.Ingrediant8.Contains("cheese") && !a.Ingrediant9.Contains("cheese") && !a.Ingrediant10.Contains("cheese") && !a.Ingrediant1.Contains("cream") && !a.Ingrediant2.Contains("cream") && !a.Ingrediant3.Contains("cream") && !a.Ingrediant4.Contains("cream") && !a.Ingrediant5.Contains("cream") && !a.Ingrediant6.Contains("cream") && !a.Ingrediant7.Contains("cream") && !a.Ingrediant8.Contains("cream") && !a.Ingrediant9.Contains("cream") && !a.Ingrediant10.Contains("cream") && !a.Ingrediant1.Contains("butter") && !a.Ingrediant2.Contains("butter") && !a.Ingrediant3.Contains("butter") && !a.Ingrediant4.Contains("butter") && !a.Ingrediant5.Contains("butter") && !a.Ingrediant6.Contains("butter") && !a.Ingrediant7.Contains("butter") && !a.Ingrediant8.Contains("butter") && !a.Ingrediant9.Contains("butter") && !a.Ingrediant10.Contains("butter") && !a.Ingrediant1.Contains("beef") && !a.Ingrediant2.Contains("beef") && !a.Ingrediant3.Contains("beef") && !a.Ingrediant4.Contains("beef") && !a.Ingrediant5.Contains("beef") && !a.Ingrediant6.Contains("beef") && !a.Ingrediant7.Contains("beef") && !a.Ingrediant8.Contains("beef") && !a.Ingrediant9.Contains("beef") && !a.Ingrediant10.Contains("beef") && !a.Ingrediant1.Contains("pork") && !a.Ingrediant2.Contains("pork") && !a.Ingrediant3.Contains("pork") && !a.Ingrediant4.Contains("pork") && !a.Ingrediant5.Contains("pork") && !a.Ingrediant6.Contains("pork") && !a.Ingrediant7.Contains("pork") && !a.Ingrediant8.Contains("pork") && !a.Ingrediant9.Contains("pork") && !a.Ingrediant10.Contains("pork") && !a.Ingrediant1.Contains("milk") && !a.Ingrediant2.Contains("milk") && !a.Ingrediant3.Contains("milk") && !a.Ingrediant4.Contains("milk") && !a.Ingrediant5.Contains("milk") && !a.Ingrediant6.Contains("milk") && !a.Ingrediant7.Contains("milk") && !a.Ingrediant8.Contains("milk") && !a.Ingrediant9.Contains("milk") && !a.Ingrediant10.Contains("milk") && !a.Ingrediant1.Contains("egg") && !a.Ingrediant2.Contains("egg") && !a.Ingrediant3.Contains("egg") && !a.Ingrediant4.Contains("egg") && !a.Ingrediant5.Contains("egg") && !a.Ingrediant6.Contains("egg") && !a.Ingrediant7.Contains("egg") && !a.Ingrediant8.Contains("egg") && !a.Ingrediant9.Contains("egg") && !a.Ingrediant10.Contains("egg") && !a.Ingrediant1.Contains("meat") && !a.Ingrediant2.Contains("meat") && !a.Ingrediant3.Contains("meat") && !a.Ingrediant4.Contains("meat") && !a.Ingrediant5.Contains("meat") && !a.Ingrediant6.Contains("meat") && !a.Ingrediant7.Contains("meat") && !a.Ingrediant8.Contains("meat") && !a.Ingrediant9.Contains("meat") && !a.Ingrediant10.Contains("meat") && !a.Ingrediant1.Contains("goose") && !a.Ingrediant2.Contains("goose") && !a.Ingrediant3.Contains("goose") && !a.Ingrediant4.Contains("goose") && !a.Ingrediant5.Contains("goose") && !a.Ingrediant6.Contains("goose") && !a.Ingrediant7.Contains("goose") && !a.Ingrediant8.Contains("goose") && !a.Ingrediant9.Contains("goose") && !a.Ingrediant10.Contains("goose") && !a.Ingrediant1.Contains("margarine") && !a.Ingrediant2.Contains("margarine") && !a.Ingrediant3.Contains("margarine") && !a.Ingrediant4.Contains("margarine") && !a.Ingrediant5.Contains("margarine") && !a.Ingrediant6.Contains("margarine") && !a.Ingrediant7.Contains("margarine") && !a.Ingrediant8.Contains("margarine") && !a.Ingrediant9.Contains("margarine") && !a.Ingrediant10.Contains("margarine") && (a.Ingrediant1.Contains(q) || a.Ingrediant2.Contains(q) || a.Ingrediant3.Contains(q) || a.Ingrediant4.Contains(q) || a.Ingrediant5.Contains(q) || a.Ingrediant6.Contains(q) || a.Ingrediant7.Contains(q) || a.Ingrediant8.Contains(q) || a.Ingrediant9.Contains(q) || a.Ingrediant10.Contains(q))).Take(10);
                }
                if (chkBxVegetarian == true)
                {
                    Debug.WriteLine("vegetarian mode is on");
                    recipes = recipes.Where(a => !a.Ingrediant1.Contains("chicken") && !a.Ingrediant2.Contains("chicken") && !a.Ingrediant3.Contains("chicken") && !a.Ingrediant4.Contains("chicken") && !a.Ingrediant5.Contains("chicken") && !a.Ingrediant6.Contains("chicken") && !a.Ingrediant7.Contains("chicken") && !a.Ingrediant8.Contains("chicken") && !a.Ingrediant9.Contains("chicken") && !a.Ingrediant10.Contains("chicken") && !a.Ingrediant1.Contains("mutton") && !a.Ingrediant2.Contains("mutton") && !a.Ingrediant3.Contains("mutton") && !a.Ingrediant4.Contains("mutton") && !a.Ingrediant5.Contains("mutton") && !a.Ingrediant6.Contains("mutton") && !a.Ingrediant7.Contains("mutton") && !a.Ingrediant8.Contains("mutton") && !a.Ingrediant9.Contains("mutton") && !a.Ingrediant10.Contains("mutton") && !a.Ingrediant1.Contains("pheasent") && !a.Ingrediant2.Contains("pheasent") && !a.Ingrediant3.Contains("pheasent") && !a.Ingrediant4.Contains("pheasent") && !a.Ingrediant5.Contains("pheasent") && !a.Ingrediant6.Contains("pheasent") && !a.Ingrediant7.Contains("pheasent") && !a.Ingrediant8.Contains("pheasent") && !a.Ingrediant9.Contains("pheasent") && !a.Ingrediant10.Contains("pheasent") && !a.Ingrediant1.Contains("duck") && !a.Ingrediant2.Contains("duck") && !a.Ingrediant3.Contains("duck") && !a.Ingrediant4.Contains("duck") && !a.Ingrediant5.Contains("duck") && !a.Ingrediant6.Contains("duck") && !a.Ingrediant7.Contains("duck") && !a.Ingrediant8.Contains("duck") && !a.Ingrediant9.Contains("duck") && !a.Ingrediant10.Contains("duck") && !a.Ingrediant1.Contains("turkey") && !a.Ingrediant2.Contains("turkey") && !a.Ingrediant3.Contains("turkey") && !a.Ingrediant4.Contains("turkey") && !a.Ingrediant5.Contains("turkey") && !a.Ingrediant6.Contains("turkey") && !a.Ingrediant7.Contains("turkey") && !a.Ingrediant8.Contains("turkey") && !a.Ingrediant9.Contains("turkey") && !a.Ingrediant10.Contains("turkey") && !a.Ingrediant1.Contains("lamb") && !a.Ingrediant2.Contains("lamb") && !a.Ingrediant3.Contains("lamb") && !a.Ingrediant4.Contains("lamb") && !a.Ingrediant5.Contains("lamb") && !a.Ingrediant6.Contains("lamb") && !a.Ingrediant7.Contains("lamb") && !a.Ingrediant8.Contains("lamb") && !a.Ingrediant9.Contains("lamb") && !a.Ingrediant10.Contains("lamb") && !a.Ingrediant1.Contains("shellfish") && !a.Ingrediant2.Contains("shellfish") && !a.Ingrediant3.Contains("shellfish") && !a.Ingrediant4.Contains("shellfish") && !a.Ingrediant5.Contains("shellfish") && !a.Ingrediant6.Contains("shellfish") && !a.Ingrediant7.Contains("shellfish") && !a.Ingrediant8.Contains("shellfish") && !a.Ingrediant9.Contains("shellfish") && !a.Ingrediant10.Contains("shellfish") && !a.Ingrediant1.Contains("fish") && !a.Ingrediant2.Contains("fish") && !a.Ingrediant3.Contains("fish") && !a.Ingrediant4.Contains("fish") && !a.Ingrediant5.Contains("fish") && !a.Ingrediant6.Contains("fish") && !a.Ingrediant7.Contains("fish") && !a.Ingrediant8.Contains("fish") && !a.Ingrediant9.Contains("fish") && !a.Ingrediant10.Contains("fish") && !a.Ingrediant1.Contains("beef") && !a.Ingrediant2.Contains("beef") && !a.Ingrediant3.Contains("beef") && !a.Ingrediant4.Contains("beef") && !a.Ingrediant5.Contains("beef") && !a.Ingrediant6.Contains("beef") && !a.Ingrediant7.Contains("beef") && !a.Ingrediant8.Contains("beef") && !a.Ingrediant9.Contains("beef") && !a.Ingrediant10.Contains("beef") && !a.Ingrediant1.Contains("pork") && !a.Ingrediant2.Contains("pork") && !a.Ingrediant3.Contains("pork") && !a.Ingrediant4.Contains("pork") && !a.Ingrediant5.Contains("pork") && !a.Ingrediant6.Contains("pork") && !a.Ingrediant7.Contains("pork") && !a.Ingrediant8.Contains("pork") && !a.Ingrediant9.Contains("pork") && !a.Ingrediant10.Contains("pork") && !a.Ingrediant1.Contains("meat") && !a.Ingrediant2.Contains("meat") && !a.Ingrediant3.Contains("meat") && !a.Ingrediant4.Contains("meat") && !a.Ingrediant5.Contains("meat") && !a.Ingrediant6.Contains("meat") && !a.Ingrediant7.Contains("meat") && !a.Ingrediant8.Contains("meat") && !a.Ingrediant9.Contains("meat") && !a.Ingrediant10.Contains("meat") && !a.Ingrediant1.Contains("goose") && !a.Ingrediant2.Contains("goose") && !a.Ingrediant3.Contains("goose") && !a.Ingrediant4.Contains("goose") && !a.Ingrediant5.Contains("goose") && !a.Ingrediant6.Contains("goose") && !a.Ingrediant7.Contains("goose") && !a.Ingrediant8.Contains("goose") && !a.Ingrediant9.Contains("goose") && !a.Ingrediant10.Contains("goose") && (a.Ingrediant1.Contains(q) || a.Ingrediant2.Contains(q) || a.Ingrediant3.Contains(q) || a.Ingrediant4.Contains(q) || a.Ingrediant5.Contains(q) || a.Ingrediant6.Contains(q) || a.Ingrediant7.Contains(q) || a.Ingrediant8.Contains(q) || a.Ingrediant9.Contains(q) || a.Ingrediant10.Contains(q))).Take(10);
                }
                if (chkBxPescatarian == true)
                {
                    Debug.WriteLine("pescatarian mode is on");
                    recipes = recipes.Where(a => !a.Ingrediant1.Contains("shellfish") && !a.Ingrediant2.Contains("shellfish") && !a.Ingrediant3.Contains("shellfish") && !a.Ingrediant4.Contains("shellfish") && !a.Ingrediant5.Contains("shellfish") && !a.Ingrediant6.Contains("shellfish") && !a.Ingrediant7.Contains("shellfish") && !a.Ingrediant8.Contains("shellfish") && !a.Ingrediant9.Contains("shellfish") && !a.Ingrediant10.Contains("shellfish") && !a.Ingrediant1.Contains("fish") && !a.Ingrediant2.Contains("fish") && !a.Ingrediant3.Contains("fish") && !a.Ingrediant4.Contains("fish") && !a.Ingrediant5.Contains("fish") && !a.Ingrediant6.Contains("fish") && !a.Ingrediant7.Contains("fish") && !a.Ingrediant8.Contains("fish") && !a.Ingrediant9.Contains("fish") && !a.Ingrediant10.Contains("fish") && (a.Ingrediant1.Contains(q) || a.Ingrediant2.Contains(q) || a.Ingrediant3.Contains(q) || a.Ingrediant4.Contains(q) || a.Ingrediant5.Contains(q) || a.Ingrediant6.Contains(q) || a.Ingrediant7.Contains(q) || a.Ingrediant8.Contains(q) || a.Ingrediant9.Contains(q) || a.Ingrediant10.Contains(q))).Take(10);
                }
                else if ((chkBxVegan == false) && (chkBxVegetarian == false) && (chkBxPescatarian == false))
                {
                    recipes = recipes.Where(a => a.Ingrediant1.Contains(q) || a.Ingrediant2.Contains(q) || a.Ingrediant3.Contains(q) || a.Ingrediant4.Contains(q) || a.Ingrediant5.Contains(q) || a.Ingrediant6.Contains(q) || a.Ingrediant7.Contains(q) || a.Ingrediant8.Contains(q) || a.Ingrediant9.Contains(q) || a.Ingrediant10.Contains(q)).Take(10);
                }
            }
            return View(recipes.ToList());
        }
        // GET: Recipes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // GET: Recipes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecipeID,RecipeTitle,RecipeStep1,RecipeStep2,RecipeStep3,RecipeStep4,RecipeStep5,RecipeStep6,RecipeStep7,RecipeStep8,RecipeStep9,RecipeStep10,Ingrediant1,Ingrediant2,Ingrediant3,Ingrediant4,Ingrediant5,Ingrediant6,Ingrediant7,Ingrediant8,Ingrediant9,Ingrediant10")] Recipe recipe)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Recipes.Add(recipe);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);//Tracks which variable was responsible for the error
                    }
                }
            }
            return View(recipe);
        }

        // GET: Recipes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }
        // POST: Recipes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecipeID,RecipeTitle,RecipeStep1,RecipeStep2,RecipeStep3,RecipeStep4,RecipeStep5,RecipeStep6,RecipeStep7,RecipeStep8,RecipeStep9,RecipeStep10,Ingrediant1,Ingrediant2,Ingrediant3,Ingrediant4,Ingrediant5,Ingrediant6,Ingrediant7,Ingrediant8,Ingrediant9,Ingrediant10")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recipe);
        }
        // GET: Recipes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipe recipe = db.Recipes.Find(id);
            db.Recipes.Remove(recipe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        //public ActionResult Search(string q)
        //{
        //    //var recipes = db.Recipes.Include("RecipeTitle").Where(a => a.Ingrediant1.Contains(q) || a.Ingrediant2.Contains(q) || a.Ingrediant3.Contains(q) || a.Ingrediant4.Contains(q) || a.Ingrediant5.Contains(q) || a.Ingrediant6.Contains(q) || a.Ingrediant7.Contains(q) || a.Ingrediant8.Contains(q) || a.Ingrediant9.Contains(q) || a.Ingrediant10.Contains(q)).Take(10);
        //    //return View(recipes); //This returns the query and not the correct data in the right format???
        //    var recipes = from m in db.Recipes select m;
        //    if (!String.IsNullOrEmpty(q))
        //    {
        //        recipes = recipes.Where(a => a.Ingrediant1.Contains(q) || a.Ingrediant2.Contains(q) || a.Ingrediant3.Contains(q) || a.Ingrediant4.Contains(q) || a.Ingrediant5.Contains(q) || a.Ingrediant6.Contains(q) || a.Ingrediant7.Contains(q) || a.Ingrediant8.Contains(q) || a.Ingrediant9.Contains(q) || a.Ingrediant10.Contains(q)).Take(10);
        //    }
        //    return View(await recipes.ToListAsync());
        //}
    }
}

