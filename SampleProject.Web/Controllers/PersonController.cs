using System.Linq;
using System.Web.Mvc;
using SampleProject.Common.Services;
using SampleProject.Web.Models.Person;

namespace SampleProject.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService = new PersonService();

        [Route("people")]
        public ActionResult Index()
        {
            var model = new PeopleListModel();

            var people = _personService.GetAll();

            model.People = people.Select(x => new PersonItemModel(x)).ToList();

            return View(model);
        }

        [Route("person/{personId:int}")]
        public ActionResult ViewPerson(int personId)
        {
            var model = new ViewPersonModel();

            var person = _personService.LoadPerson(personId);

            if (person == null)
                return HttpNotFound("Person could not be found");

            model.Name = person.Name;
            model.ImageUrl = person.ImageUrl;
            model.Description = person.Description;
            model.Id = person.Id;

            return View(model);
        }
    }
}