using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstarct
{
    public interface IMessageDal : IGenericDal<Message2>
    {
        List<Message2> GetListMessageByWriter(int id);
    }
}
