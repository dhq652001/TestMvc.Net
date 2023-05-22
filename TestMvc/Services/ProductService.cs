using System.Collections.Generic;
using TestMvc.Models;

namespace TestMvc.Services
{
    public class ProductService : List<ProductModel>
    {
        public ProductService()
        {
            this.AddRange(new ProductModel[]
            {
                new ProductModel(){Id = 1, Name = "Iphone XS Max",Price = 10000},
                new ProductModel(){Id = 2, Name = "Iphone 11 ProMax",Price = 13000},
                new ProductModel(){Id = 3, Name = "Iphone 12 ProMax",Price = 15000},
                new ProductModel(){Id = 4, Name = "Iphone 13ProMax",Price = 18000}
            });
        }
    }
}
