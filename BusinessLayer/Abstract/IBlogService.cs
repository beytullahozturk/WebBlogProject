using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void DeleteBlog(Blog blog);
        List<Blog> GetAll();
        Blog GetById(int id);
        List<Blog> GetAllBlogWithCategory();
        List<Blog> GetAllBlogByWriter(int id);
        List<Blog> GetBlogById(int id);
    }
}
