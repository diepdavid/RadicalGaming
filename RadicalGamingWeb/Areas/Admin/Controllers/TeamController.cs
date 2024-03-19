using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RadicalGaming.DataAccess.Data;
using RadicalGaming.DataAccess.Repository.IRepository;
using RadicalGaming.Model;
using RadicalGaming.Utility;

namespace RadicalGamingWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class TeamController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TeamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            // Hämta listan från databasen och skicka det till view
            List<Team> objTeamList = _unitOfWork.Team.GetAll().ToList();
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
                _unitOfWork.Team.Add(obj);
                _unitOfWork.Save();
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

            Team teamFromDb = _unitOfWork.Team.Get(u => u.Id == id);
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
                _unitOfWork.Team.Update(obj);
                _unitOfWork.Save();
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

            Team teamFromDb = _unitOfWork.Team.Get(u => u.Id == id);
            if (teamFromDb == null)
            {
                return NotFound();
            }

            return View(teamFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Team? obj = _unitOfWork.Team.Get(u => u.Id == id);
            {
                if (obj == null)
                {
                    return NotFound();
                }
            }
            _unitOfWork.Team.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
