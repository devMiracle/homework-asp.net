﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }
        public List<Car> Cars { set; get; }
    }
}
