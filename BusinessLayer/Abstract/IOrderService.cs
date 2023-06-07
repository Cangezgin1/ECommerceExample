using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderService
    {
        void Create(Order order);
        void Delete(Order order);
        void Update(Order order);

        Order GetById(int id);
        List<Order> GetAll();
    }
}
