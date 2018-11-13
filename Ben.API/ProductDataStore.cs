using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ben.API.Models;

namespace Ben.API
{
    public class ProductDataStore
    {
        public static ProductDataStore Current { get; } = new ProductDataStore();
        public List<Product> Products { get; set; }

        public ProductDataStore()
        {
            Products = new List<Product>()
            {
                    new Product()
                {
                    Id = 1,
                    Name = "Healthcare",
                    Cost = 100,
                    MemberId = 1

                },
                new Product()
                {
                    Id = 2,
                    Name = "Healthcare",
                    Cost = 100,
                    MemberId = 2

                },
                new Product()
                {
                    Id = 3,
                    Name = "Healthcare",
                    Cost = 100,
                    MemberId = 3

                },
                new Product()
                {
                    Id = 4,
                    Name = "Healthcare",
                    Cost = 100,
                    MemberId = 4

                },
                new Product()
                {
                    Id = 5,
                    Name = "Travel Insurance",
                    Cost = 150,
                    MemberId = 1

                },
                new Product()
                {
                    Id = 6,
                    Name = "Travel Insurance",
                    Cost = 150,
                    MemberId = 4

                },
                new Product()
                {
                    Id = 7,
                    Name = "Home Insurance",
                    Cost = 120,
                    MemberId = 1

                },
                new Product()
                {
                    Id = 8,
                    Name = "Home Insurance",
                    Cost = 120,
                    MemberId = 2

                }
            };

        }

    }
}