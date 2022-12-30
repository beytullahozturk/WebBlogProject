using DataAccessLayer.Abstarct;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
    }
}
