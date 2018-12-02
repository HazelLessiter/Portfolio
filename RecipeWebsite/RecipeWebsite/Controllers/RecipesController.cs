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
    //[Authorize]
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
                    recipes = recipes.Where(a => !a.Ingredient1.Contains("chicken") && !a.Ingredient2.Contains("chicken") && !a.Ingredient3.Contains("chicken") && !a.Ingredient4.Contains("chicken") && !a.Ingredient5.Contains("chicken") && !a.Ingredient6.Contains("chicken") && !a.Ingredient7.Contains("chicken") && !a.Ingredient8.Contains("chicken") && !a.Ingredient9.Contains("chicken") && !a.Ingredient10.Contains("chicken") && !a.Ingredient1.Contains("mutton") && !a.Ingredient2.Contains("mutton") && !a.Ingredient3.Contains("mutton") && !a.Ingredient4.Contains("mutton") && !a.Ingredient5.Contains("mutton") && !a.Ingredient6.Contains("mutton") && !a.Ingredient7.Contains("mutton") && !a.Ingredient8.Contains("mutton") && !a.Ingredient9.Contains("mutton") && !a.Ingredient10.Contains("mutton") && !a.Ingredient1.Contains("pheasent") && !a.Ingredient2.Contains("pheasent") && !a.Ingredient3.Contains("pheasent") && !a.Ingredient4.Contains("pheasent") && !a.Ingredient5.Contains("pheasent") && !a.Ingredient6.Contains("pheasent") && !a.Ingredient7.Contains("pheasent") && !a.Ingredient8.Contains("pheasent") && !a.Ingredient9.Contains("pheasent") && !a.Ingredient10.Contains("pheasent") && !a.Ingredient1.Contains("duck") && !a.Ingredient2.Contains("duck") && !a.Ingredient3.Contains("duck") && !a.Ingredient4.Contains("duck") && !a.Ingredient5.Contains("duck") && !a.Ingredient6.Contains("duck") && !a.Ingredient7.Contains("duck") && !a.Ingredient8.Contains("duck") && !a.Ingredient9.Contains("duck") && !a.Ingredient10.Contains("duck") && !a.Ingredient1.Contains("turkey") && !a.Ingredient2.Contains("turkey") && !a.Ingredient3.Contains("turkey") && !a.Ingredient4.Contains("turkey") && !a.Ingredient5.Contains("turkey") && !a.Ingredient6.Contains("turkey") && !a.Ingredient7.Contains("turkey") && !a.Ingredient8.Contains("turkey") && !a.Ingredient9.Contains("turkey") && !a.Ingredient10.Contains("turkey") && !a.Ingredient1.Contains("honey") && !a.Ingredient2.Contains("honey") && !a.Ingredient3.Contains("honey") && !a.Ingredient4.Contains("honey") && !a.Ingredient5.Contains("honey") && !a.Ingredient6.Contains("honey") && !a.Ingredient7.Contains("honey") && !a.Ingredient8.Contains("honey") && !a.Ingredient9.Contains("honey") && !a.Ingredient10.Contains("honey") && !a.Ingredient1.Contains("gelatine") && !a.Ingredient2.Contains("gelatine") && !a.Ingredient3.Contains("gelatine") && !a.Ingredient4.Contains("gelatine") && !a.Ingredient5.Contains("gelatine") && !a.Ingredient6.Contains("gelatine") && !a.Ingredient7.Contains("gelatine") && !a.Ingredient8.Contains("gelatine") && !a.Ingredient9.Contains("gelatine") && !a.Ingredient10.Contains("gelatine") && !a.Ingredient1.Contains("lamb") && !a.Ingredient2.Contains("lamb") && !a.Ingredient3.Contains("lamb") && !a.Ingredient4.Contains("lamb") && !a.Ingredient5.Contains("lamb") && !a.Ingredient6.Contains("lamb") && !a.Ingredient7.Contains("lamb") && !a.Ingredient8.Contains("lamb") && !a.Ingredient9.Contains("lamb") && !a.Ingredient10.Contains("lamb") && !a.Ingredient1.Contains("shellfish") && !a.Ingredient2.Contains("shellfish") && !a.Ingredient3.Contains("shellfish") && !a.Ingredient4.Contains("shellfish") && !a.Ingredient5.Contains("shellfish") && !a.Ingredient6.Contains("shellfish") && !a.Ingredient7.Contains("shellfish") && !a.Ingredient8.Contains("shellfish") && !a.Ingredient9.Contains("shellfish") && !a.Ingredient10.Contains("shellfish") && !a.Ingredient1.Contains("fish") && !a.Ingredient2.Contains("fish") && !a.Ingredient3.Contains("fish") && !a.Ingredient4.Contains("fish") && !a.Ingredient5.Contains("fish") && !a.Ingredient6.Contains("fish") && !a.Ingredient7.Contains("fish") && !a.Ingredient8.Contains("fish") && !a.Ingredient9.Contains("fish") && !a.Ingredient10.Contains("fish") && !a.Ingredient1.Contains("cheese") && !a.Ingredient2.Contains("cheese") && !a.Ingredient3.Contains("cheese") && !a.Ingredient4.Contains("cheese") && !a.Ingredient5.Contains("cheese") && !a.Ingredient6.Contains("cheese") && !a.Ingredient7.Contains("cheese") && !a.Ingredient8.Contains("cheese") && !a.Ingredient9.Contains("cheese") && !a.Ingredient10.Contains("cheese") && !a.Ingredient1.Contains("cream") && !a.Ingredient2.Contains("cream") && !a.Ingredient3.Contains("cream") && !a.Ingredient4.Contains("cream") && !a.Ingredient5.Contains("cream") && !a.Ingredient6.Contains("cream") && !a.Ingredient7.Contains("cream") && !a.Ingredient8.Contains("cream") && !a.Ingredient9.Contains("cream") && !a.Ingredient10.Contains("cream") && !a.Ingredient1.Contains("butter") && !a.Ingredient2.Contains("butter") && !a.Ingredient3.Contains("butter") && !a.Ingredient4.Contains("butter") && !a.Ingredient5.Contains("butter") && !a.Ingredient6.Contains("butter") && !a.Ingredient7.Contains("butter") && !a.Ingredient8.Contains("butter") && !a.Ingredient9.Contains("butter") && !a.Ingredient10.Contains("butter") && !a.Ingredient1.Contains("beef") && !a.Ingredient2.Contains("beef") && !a.Ingredient3.Contains("beef") && !a.Ingredient4.Contains("beef") && !a.Ingredient5.Contains("beef") && !a.Ingredient6.Contains("beef") && !a.Ingredient7.Contains("beef") && !a.Ingredient8.Contains("beef") && !a.Ingredient9.Contains("beef") && !a.Ingredient10.Contains("beef") && !a.Ingredient1.Contains("pork") && !a.Ingredient2.Contains("pork") && !a.Ingredient3.Contains("pork") && !a.Ingredient4.Contains("pork") && !a.Ingredient5.Contains("pork") && !a.Ingredient6.Contains("pork") && !a.Ingredient7.Contains("pork") && !a.Ingredient8.Contains("pork") && !a.Ingredient9.Contains("pork") && !a.Ingredient10.Contains("pork") && !a.Ingredient1.Contains("milk") && !a.Ingredient2.Contains("milk") && !a.Ingredient3.Contains("milk") && !a.Ingredient4.Contains("milk") && !a.Ingredient5.Contains("milk") && !a.Ingredient6.Contains("milk") && !a.Ingredient7.Contains("milk") && !a.Ingredient8.Contains("milk") && !a.Ingredient9.Contains("milk") && !a.Ingredient10.Contains("milk") && !a.Ingredient1.Contains("egg") && !a.Ingredient2.Contains("egg") && !a.Ingredient3.Contains("egg") && !a.Ingredient4.Contains("egg") && !a.Ingredient5.Contains("egg") && !a.Ingredient6.Contains("egg") && !a.Ingredient7.Contains("egg") && !a.Ingredient8.Contains("egg") && !a.Ingredient9.Contains("egg") && !a.Ingredient10.Contains("egg") && !a.Ingredient1.Contains("meat") && !a.Ingredient2.Contains("meat") && !a.Ingredient3.Contains("meat") && !a.Ingredient4.Contains("meat") && !a.Ingredient5.Contains("meat") && !a.Ingredient6.Contains("meat") && !a.Ingredient7.Contains("meat") && !a.Ingredient8.Contains("meat") && !a.Ingredient9.Contains("meat") && !a.Ingredient10.Contains("meat") && !a.Ingredient1.Contains("goose") && !a.Ingredient2.Contains("goose") && !a.Ingredient3.Contains("goose") && !a.Ingredient4.Contains("goose") && !a.Ingredient5.Contains("goose") && !a.Ingredient6.Contains("goose") && !a.Ingredient7.Contains("goose") && !a.Ingredient8.Contains("goose") && !a.Ingredient9.Contains("goose") && !a.Ingredient10.Contains("goose") && !a.Ingredient1.Contains("margarine") && !a.Ingredient2.Contains("margarine") && !a.Ingredient3.Contains("margarine") && !a.Ingredient4.Contains("margarine") && !a.Ingredient5.Contains("margarine") && !a.Ingredient6.Contains("margarine") && !a.Ingredient7.Contains("margarine") && !a.Ingredient8.Contains("margarine") && !a.Ingredient9.Contains("margarine") && !a.Ingredient10.Contains("margarine") && (a.Ingredient1.Contains(q) || a.Ingredient2.Contains(q) || a.Ingredient3.Contains(q) || a.Ingredient4.Contains(q) || a.Ingredient5.Contains(q) || a.Ingredient6.Contains(q) || a.Ingredient7.Contains(q) || a.Ingredient8.Contains(q) || a.Ingredient9.Contains(q) || a.Ingredient10.Contains(q))).Take(10);
                }
                if (chkBxVegetarian == true)
                {
                    Debug.WriteLine("vegetarian mode is on");
                    recipes = recipes.Where(a => !a.Ingredient1.Contains("chicken") && !a.Ingredient2.Contains("chicken") && !a.Ingredient3.Contains("chicken") && !a.Ingredient4.Contains("chicken") && !a.Ingredient5.Contains("chicken") && !a.Ingredient6.Contains("chicken") && !a.Ingredient7.Contains("chicken") && !a.Ingredient8.Contains("chicken") && !a.Ingredient9.Contains("chicken") && !a.Ingredient10.Contains("chicken") && !a.Ingredient1.Contains("mutton") && !a.Ingredient2.Contains("mutton") && !a.Ingredient3.Contains("mutton") && !a.Ingredient4.Contains("mutton") && !a.Ingredient5.Contains("mutton") && !a.Ingredient6.Contains("mutton") && !a.Ingredient7.Contains("mutton") && !a.Ingredient8.Contains("mutton") && !a.Ingredient9.Contains("mutton") && !a.Ingredient10.Contains("mutton") && !a.Ingredient1.Contains("pheasent") && !a.Ingredient2.Contains("pheasent") && !a.Ingredient3.Contains("pheasent") && !a.Ingredient4.Contains("pheasent") && !a.Ingredient5.Contains("pheasent") && !a.Ingredient6.Contains("pheasent") && !a.Ingredient7.Contains("pheasent") && !a.Ingredient8.Contains("pheasent") && !a.Ingredient9.Contains("pheasent") && !a.Ingredient10.Contains("pheasent") && !a.Ingredient1.Contains("duck") && !a.Ingredient2.Contains("duck") && !a.Ingredient3.Contains("duck") && !a.Ingredient4.Contains("duck") && !a.Ingredient5.Contains("duck") && !a.Ingredient6.Contains("duck") && !a.Ingredient7.Contains("duck") && !a.Ingredient8.Contains("duck") && !a.Ingredient9.Contains("duck") && !a.Ingredient10.Contains("duck") && !a.Ingredient1.Contains("turkey") && !a.Ingredient2.Contains("turkey") && !a.Ingredient3.Contains("turkey") && !a.Ingredient4.Contains("turkey") && !a.Ingredient5.Contains("turkey") && !a.Ingredient6.Contains("turkey") && !a.Ingredient7.Contains("turkey") && !a.Ingredient8.Contains("turkey") && !a.Ingredient9.Contains("turkey") && !a.Ingredient10.Contains("turkey") && !a.Ingredient1.Contains("lamb") && !a.Ingredient2.Contains("lamb") && !a.Ingredient3.Contains("lamb") && !a.Ingredient4.Contains("lamb") && !a.Ingredient5.Contains("lamb") && !a.Ingredient6.Contains("lamb") && !a.Ingredient7.Contains("lamb") && !a.Ingredient8.Contains("lamb") && !a.Ingredient9.Contains("lamb") && !a.Ingredient10.Contains("lamb") && !a.Ingredient1.Contains("shellfish") && !a.Ingredient2.Contains("shellfish") && !a.Ingredient3.Contains("shellfish") && !a.Ingredient4.Contains("shellfish") && !a.Ingredient5.Contains("shellfish") && !a.Ingredient6.Contains("shellfish") && !a.Ingredient7.Contains("shellfish") && !a.Ingredient8.Contains("shellfish") && !a.Ingredient9.Contains("shellfish") && !a.Ingredient10.Contains("shellfish") && !a.Ingredient1.Contains("fish") && !a.Ingredient2.Contains("fish") && !a.Ingredient3.Contains("fish") && !a.Ingredient4.Contains("fish") && !a.Ingredient5.Contains("fish") && !a.Ingredient6.Contains("fish") && !a.Ingredient7.Contains("fish") && !a.Ingredient8.Contains("fish") && !a.Ingredient9.Contains("fish") && !a.Ingredient10.Contains("fish") && !a.Ingredient1.Contains("beef") && !a.Ingredient2.Contains("beef") && !a.Ingredient3.Contains("beef") && !a.Ingredient4.Contains("beef") && !a.Ingredient5.Contains("beef") && !a.Ingredient6.Contains("beef") && !a.Ingredient7.Contains("beef") && !a.Ingredient8.Contains("beef") && !a.Ingredient9.Contains("beef") && !a.Ingredient10.Contains("beef") && !a.Ingredient1.Contains("pork") && !a.Ingredient2.Contains("pork") && !a.Ingredient3.Contains("pork") && !a.Ingredient4.Contains("pork") && !a.Ingredient5.Contains("pork") && !a.Ingredient6.Contains("pork") && !a.Ingredient7.Contains("pork") && !a.Ingredient8.Contains("pork") && !a.Ingredient9.Contains("pork") && !a.Ingredient10.Contains("pork") && !a.Ingredient1.Contains("meat") && !a.Ingredient2.Contains("meat") && !a.Ingredient3.Contains("meat") && !a.Ingredient4.Contains("meat") && !a.Ingredient5.Contains("meat") && !a.Ingredient6.Contains("meat") && !a.Ingredient7.Contains("meat") && !a.Ingredient8.Contains("meat") && !a.Ingredient9.Contains("meat") && !a.Ingredient10.Contains("meat") && !a.Ingredient1.Contains("goose") && !a.Ingredient2.Contains("goose") && !a.Ingredient3.Contains("goose") && !a.Ingredient4.Contains("goose") && !a.Ingredient5.Contains("goose") && !a.Ingredient6.Contains("goose") && !a.Ingredient7.Contains("goose") && !a.Ingredient8.Contains("goose") && !a.Ingredient9.Contains("goose") && !a.Ingredient10.Contains("goose") && (a.Ingredient1.Contains(q) || a.Ingredient2.Contains(q) || a.Ingredient3.Contains(q) || a.Ingredient4.Contains(q) || a.Ingredient5.Contains(q) || a.Ingredient6.Contains(q) || a.Ingredient7.Contains(q) || a.Ingredient8.Contains(q) || a.Ingredient9.Contains(q) || a.Ingredient10.Contains(q))).Take(10);
                }
                if (chkBxPescatarian == true)
                {
                    Debug.WriteLine("pescatarian mode is on");
                    recipes = recipes.Where(a => !a.Ingredient1.Contains("shellfish") && !a.Ingredient2.Contains("shellfish") && !a.Ingredient3.Contains("shellfish") && !a.Ingredient4.Contains("shellfish") && !a.Ingredient5.Contains("shellfish") && !a.Ingredient6.Contains("shellfish") && !a.Ingredient7.Contains("shellfish") && !a.Ingredient8.Contains("shellfish") && !a.Ingredient9.Contains("shellfish") && !a.Ingredient10.Contains("shellfish") && !a.Ingredient1.Contains("fish") && !a.Ingredient2.Contains("fish") && !a.Ingredient3.Contains("fish") && !a.Ingredient4.Contains("fish") && !a.Ingredient5.Contains("fish") && !a.Ingredient6.Contains("fish") && !a.Ingredient7.Contains("fish") && !a.Ingredient8.Contains("fish") && !a.Ingredient9.Contains("fish") && !a.Ingredient10.Contains("fish") && (a.Ingredient1.Contains(q) || a.Ingredient2.Contains(q) || a.Ingredient3.Contains(q) || a.Ingredient4.Contains(q) || a.Ingredient5.Contains(q) || a.Ingredient6.Contains(q) || a.Ingredient7.Contains(q) || a.Ingredient8.Contains(q) || a.Ingredient9.Contains(q) || a.Ingredient10.Contains(q))).Take(10);
                }
                else if ((chkBxVegan == false) && (chkBxVegetarian == false) && (chkBxPescatarian == false))
                {
                    recipes = recipes.Where(a => a.Ingredient1.Contains(q) || a.Ingredient2.Contains(q) || a.Ingredient3.Contains(q) || a.Ingredient4.Contains(q) || a.Ingredient5.Contains(q) || a.Ingredient6.Contains(q) || a.Ingredient7.Contains(q) || a.Ingredient8.Contains(q) || a.Ingredient9.Contains(q) || a.Ingredient10.Contains(q)).Take(10);
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
        public ActionResult Create([Bind(Include = "RecipeID,RecipeTitle,RecipeStep1,RecipeStep2,RecipeStep3,RecipeStep4,RecipeStep5,RecipeStep6,RecipeStep7,RecipeStep8,RecipeStep9,RecipeStep10,Ingredient1,Ingredient2,Ingredient3,Ingredient4,Ingredient5,Ingredient6,Ingredient7,Ingredient8,Ingredient9,Ingredient10")] Recipe recipe)
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
        public ActionResult Edit([Bind(Include = "RecipeID,RecipeTitle,RecipeStep1,RecipeStep2,RecipeStep3,RecipeStep4,RecipeStep5,RecipeStep6,RecipeStep7,RecipeStep8,RecipeStep9,RecipeStep10,Ingredient1,Ingredient2,Ingredient3,Ingredient4,Ingredient5,Ingredient6,Ingredient7,Ingredient8,Ingredient9,Ingredient10")] Recipe recipe)
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
        //    //var recipes = db.Recipes.Include("RecipeTitle").Where(a => a.Ingredient1.Contains(q) || a.Ingredient2.Contains(q) || a.Ingredient3.Contains(q) || a.Ingredient4.Contains(q) || a.Ingredient5.Contains(q) || a.Ingredient6.Contains(q) || a.Ingredient7.Contains(q) || a.Ingredient8.Contains(q) || a.Ingredient9.Contains(q) || a.Ingredient10.Contains(q)).Take(10);
        //    //return View(recipes); //This returns the query and not the correct data in the right format???
        //    var recipes = from m in db.Recipes select m;
        //    if (!String.IsNullOrEmpty(q))
        //    {
        //        recipes = recipes.Where(a => a.Ingredient1.Contains(q) || a.Ingredient2.Contains(q) || a.Ingredient3.Contains(q) || a.Ingredient4.Contains(q) || a.Ingredient5.Contains(q) || a.Ingredient6.Contains(q) || a.Ingredient7.Contains(q) || a.Ingredient8.Contains(q) || a.Ingredient9.Contains(q) || a.Ingredient10.Contains(q)).Take(10);
        //    }
        //    return View(await recipes.ToListAsync());
        //}
    }
}

