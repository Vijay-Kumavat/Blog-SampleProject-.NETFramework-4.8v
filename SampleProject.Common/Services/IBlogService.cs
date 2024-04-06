using SampleProject.Common.Data;
using System.Collections.Generic;

namespace SampleProject.Common.Services
{
    public interface IBlogService
    {
        List<Blog> GetAll();

        Blog GetBlog(int id);
    }
}
