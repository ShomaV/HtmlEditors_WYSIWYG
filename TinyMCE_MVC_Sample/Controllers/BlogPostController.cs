using System.Web.Mvc;

namespace TinyMCE_MVC_Sample.Controllers
{    

    using TinyMCE_MVC_Sample.Models;

    public class BlogPostController : Controller
    {
        // GET: BlogPost
        public ActionResult Create()
        {            
            { return View();}
        }

        [HttpPost, ActionName("Create"),ValidateInput(false)]
        public ActionResult Create(BlogPost model)
        {

            ViewBag.HtmlContent = model.Content;

            return View(model);
        }
    }
}