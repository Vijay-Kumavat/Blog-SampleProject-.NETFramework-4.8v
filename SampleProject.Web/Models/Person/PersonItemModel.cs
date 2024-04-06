namespace SampleProject.Web.Models.Person
{
    public class PersonItemModel
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public PersonItemModel(Common.Data.Person person)
        {
            Name = person.Name;
            Id = person.Id;
            ShortDescription = person.ShortDescription;
            Description = person.Description;
            ImageUrl = person.ImageUrl;
        }
    }
}