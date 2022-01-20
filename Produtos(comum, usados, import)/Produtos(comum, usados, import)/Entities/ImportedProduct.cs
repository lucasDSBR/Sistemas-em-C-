using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos_comum__usados__import_.Entities
{
    class ImportedProduct: Product
    {
        public double CustomsFree { get; set; }


        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price)
        {
            CustomsFree = customsFree;
        }
    }
}
