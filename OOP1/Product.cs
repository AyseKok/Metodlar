using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CatehoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //birim fiyat
        public int UnitsInStock { get; set; } //stok adedi

        
    }
}
