using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstarct
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetAllWithCategory();
        List<Blog> GetAllWithCategoryByWriter(int id);
    }
}
