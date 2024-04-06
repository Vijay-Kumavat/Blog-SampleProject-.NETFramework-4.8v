namespace SampleProject.Web.Models.Blog
{
    public class ViewBlogModel
    {
        public int Id { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public int PersonId { get; set; }
    }
}