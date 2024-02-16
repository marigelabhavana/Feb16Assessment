using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb16Assessment
{
    public class Product
    {
        public string PName { get; set; }
        public double PPrice { get; set; }
        public string PBrand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Product(string name, double price, string brand, DateTime mfDate, DateTime expDate)
        {
            PName = name;
            PPrice = price;
            PBrand = brand;
            ManufacturingDate = mfDate;
            ExpiryDate = expDate;
        }
    }
}
