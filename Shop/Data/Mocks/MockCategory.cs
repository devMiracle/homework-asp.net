using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get{
                return new List<Category>
                {
                    new Category { categoryName = "Electro", desc = " Eco cars"},
                    new Category { categoryName = "Fuel", desc = "Cars with the fuel motor"},
                    new Category { categoryName = "Motorbike", desc = "For the real man"}
                };
            }
        }
    }
}
