﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentBuilderPattern
{
    public class ProductRepository : IProductRepository
    {
        public Product GetById(int id)
        {
            return new Product();
        }
    }
}
