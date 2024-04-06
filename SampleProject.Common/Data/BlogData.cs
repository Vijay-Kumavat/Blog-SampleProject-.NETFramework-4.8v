using SampleProject.Common.Core;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SampleProject.Common.Data
{
    public class BlogData : DataContext
    {
        public static List<Blog> GetAll()
        {
            return Context.Blog.ToList();
        }

        public static Blog GetById(int id)
        {
            var blog = Context.Blog.FirstOrDefault(b => b.Id == id);
            if (blog != null)
            {
                blog.ViewCount++;
                Context.Blog.AddOrUpdate(blog);
                Context.SaveChanges();
            }

            return blog;
        }
    }
}
