using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {

        private readonly IOrderService _orderService;

        public OrderManager(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void Create(Order order)
        {
            _orderService.Create(order);    
        }

        public void Delete(Order order)
        {
            _orderService.Delete(order);    
        }

        public List<Order> GetAll()
        {
            return _orderService.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderService.GetById(id);
        }

        public void Update(Order order)
        {
            _orderService.Update(order);
        }
    }
}
