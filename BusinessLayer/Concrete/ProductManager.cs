using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductService _productService;


        public void Create(Product product)
        {
            _productService.Create(product);    
        }

        public void Delete(Product product)
        {
            _productService.Delete(product);  
        }

        public List<Product> GetAll()
        {
            return _productService.GetAll();
        }

        public Product GetById(int id)
        {
            return _productService.GetById(id);
        }

        public void Update(Product product)
        {
            _productService.Update(product);
        }
    }
}
