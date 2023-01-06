using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetAllBlogWithCategory();
        public List<Blog> GetAllBlogWithCategoryByWriter(int id);
        List<Blog> GetAllBlogByWriter(int id);
        List<Blog> GetBlogById(int id);
        List<Blog> GetLast2Blog();
    }
}
