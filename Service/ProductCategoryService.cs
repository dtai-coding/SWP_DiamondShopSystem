using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductCategoryService
    {
        private ProductCategoryRepository _repo = new ProductCategoryRepository();

        public List<ProductCategory> GetAllProductCate() => _repo.GetAll();

        public ProductCategory? GetAProductCate(int id) => _repo.GetById(id);
    }
}
