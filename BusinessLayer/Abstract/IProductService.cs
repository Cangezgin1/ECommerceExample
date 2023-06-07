using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        void Create(Product product);
        void Delete(Product product);
        void Update(Product product);

        Product GetById(int id);
        List<Product> GetAll();
    }
}
