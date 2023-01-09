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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message2 t)
        {
            _messageDal.Insert(t);
        }

        public void Delete(Message2 t)
        {
            _messageDal.Delete(t);
        }

        public List<Message2> GetAll()
        {
            return _messageDal.GetAll();
        }

        public Message2 GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message2> GetInboxByWriter(int p)
        {
            return _messageDal.GetListMessageByWriter(p);
        }

        public void Update(Message2 t)
        {
            _messageDal.Update(t);
        }
    }
}
