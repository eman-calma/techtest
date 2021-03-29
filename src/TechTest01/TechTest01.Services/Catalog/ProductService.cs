using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;

namespace TechTest01.Services.Catalog
{
  public class ProductService : IProductService
  {

    private IRepository<Product> _productRepo;

    public ProductService(IRepository<Product> productRepo)
    {
      _productRepo = productRepo;
    }

    public Product GetById(int id)
    {
      return _productRepo.GetById(id);
    }

    public ICollection<Product> GetProducts()
    {
      return _productRepo.Table.ToList();
    }
  }
}
