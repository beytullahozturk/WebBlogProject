using BusinessLayer.Abstract;
using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }
        public List<Blog> GetLast2Blog()
        {
            return _blogDal.GetAll().Take(2).ToList();
        }

        public List<Blog> GetAllBlogByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public List<Blog> GetAllBlogWithCategory()
        {
            return _blogDal.GetAllWithCategory();
        }
        public List<Blog> GetAllBlogWithCategoryByWriter(int id)
        {
            return _blogDal.GetAllWithCategoryByWriter(id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public void Add(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void Update(Blog t)
        {
            _blogDal.Update(t);
        }

        public void Delete(Blog t)
        {
            _blogDal.Delete(t);
        }
    }
}
