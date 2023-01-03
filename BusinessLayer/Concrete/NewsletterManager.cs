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
    public class NewsletterManager : INewsletterService
    {
        INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void Add(Newsletter t)
        {
            _newsletterDal.Insert(t);
        }

        public void Delete(Newsletter t)
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> GetAll()
        {
            throw new NotImplementedException();
        }

        public Newsletter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Newsletter t)
        {
            throw new NotImplementedException();
        }
    }
}
