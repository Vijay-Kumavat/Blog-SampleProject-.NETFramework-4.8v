using SampleProject.Common.Data;
using System;
using System.Collections.Generic;

namespace SampleProject.Common.Services
{
    public class BlogService : IBlogService
    {
        public List<Blog> GetAll()
        {
            return BlogData.GetAll();
        }

        public Blog GetBlog(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            return BlogData.GetById(id);
        }
    }
}
