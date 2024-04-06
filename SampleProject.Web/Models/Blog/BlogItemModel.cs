using System;

namespace SampleProject.Web.Models.Blog
{
    public class BlogItemModel
    {
        public int Id { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public int PersonId { get; set; }
        public int ViewCount { get; set; }
        public string PersonName { get; set;}
    }
}