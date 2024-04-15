using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RadicalGaming.DataAccess.Data;
using RadicalGaming.DataAccess.Repository;
using RadicalGaming.DataAccess.Repository.IRepository;
using RadicalGaming.Model;
using RadicalGaming.Model.ViewModels;
using RadicalGaming.Utility;

namespace RadicalGamingWeb.Areas.Admin.Controllers
{
    public class CommentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost] // Comment
        public IActionResult AddComment(int productId, string Name, string Text)
        {
            var product = _unitOfWork.Product.Get(u => u.Id == productId);

            if (product == null)
            {
                return NotFound();
            }

            // Ensure the product's Comments collection is initialized 
            if (product.Comments == null)
            {
                product.Comments = new List<Comment>();
            }

            // Create a new comment and add it to the product's Comments collection 
            product.Comments.Add(new Comment
            {
                Name = Name,
                Text = Text
            });

            // Save changes to the database 
            _unitOfWork.Save();

            // Redirect back to the product listing page 
            return RedirectToAction("Index");
        }
    }
}
