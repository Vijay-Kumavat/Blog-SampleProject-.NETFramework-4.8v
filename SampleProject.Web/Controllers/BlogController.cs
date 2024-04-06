using SampleProject.Common.Services;
using SampleProject.Web.Models.Blog;
using System.Linq;
using System.Web.Mvc;

namespace SampleProject.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService = new BlogService();
        private readonly IPersonService _personService = new PersonService();

        [Route("blog")]
        public ActionResult Index()
        {
            var model = new BlogListModel();

            var blog = _blogService.GetAll();

            model.Blog = blog.Select(x => new BlogItemModel
            {
                DateCreated = x.DateCreated,
                PersonName = _personService.LoadPerson(x.PersonId)?.Name,
                Content = x.Content,
                Description = x.Description,
                Id = x.Id,
                PersonId = x.Id,
                ThumbnailUrl = x.ThumbnailUrl,
                Title = x.Title,
                ViewCount = x.ViewCount
            }).ToList();

            return View(model);
        }

        [Route("blog/{blogId:int}")]
        public ActionResult ViewBlog(int blogId)
        {
            var model = new ViewBlogModel();

            var blog = _blogService.GetBlog(blogId);

            if (blog == null)
                return HttpNotFound("Blog could not be found");

            model.Title = blog.Title;
            model.ThumbnailUrl = blog.ThumbnailUrl;
            model.Content = blog.Content;
            model.ViewCount = blog.ViewCount;
            model.Description = blog.Description;
            model.Id = blog.Id;

            return View(model);
        }
    }
}