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
    public class BlogRatingManager : IBlogRatingService
    {
        IBlogRatingDal _blogRatingDal;

        public BlogRatingManager(IBlogRatingDal blogRatingDal)
        {
            _blogRatingDal = blogRatingDal;
        }

        public void Add(BlogRating t)
        {
            throw new NotImplementedException();
        }

        public void Delete(BlogRating t)
        {
            throw new NotImplementedException();
        }

        public List<BlogRating> GetAll()
        {
            throw new NotImplementedException();
        }

        public BlogRating GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(BlogRating t)
        {
            throw new NotImplementedException();
        }
    }
}
