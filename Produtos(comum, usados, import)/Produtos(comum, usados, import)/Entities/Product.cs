﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos_comum__usados__import_.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public string priceTag(int cfee)
        {
            return "Customs fee: "+ cfee;
        }
    }
}
