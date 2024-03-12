using Microsoft.AspNetCore.Mvc;
using RadicalGaming.DataAccess.Data;
using RadicalGaming.Model;

namespace RadicalGamingWeb.Controllers
{
    public class TeamController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TeamController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            // Hämta listan från databasen och skicka det till view
            List<Team> objTeamList = _db.Team.ToList();
            return View(objTeamList);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Team obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display Order cannot exactly match the Name."); // Custom Error
            }
            if (ModelState.IsValid)
            {
                _db.Team.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category added successfully";
                return RedirectToAction("Index", "Team");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Team teamFromDb = _db.Team.Find(id);
            if (teamFromDb == null)
            {
                return NotFound();
            }

            return View(teamFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Team obj)
        {
            if (ModelState.IsValid)
            {
                _db.Team.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index", "Team");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Team teamFromDb = _db.Team.Find(id);
            if (teamFromDb == null)
            {
                return NotFound();
            }

            return View(teamFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Team? obj = _db.Team.Find(id);
            {
                if (obj == null)
                {
                    return NotFound();
                }
            }
            _db.Team.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
