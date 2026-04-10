using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PriceFilter
    {
        private List<Product> products_ = new List<Product>();
        public List<Product> FindeProducts(double x)
        {
            SaleLoader loader = new SaleLoader();
            products_ = loader.ReadAllFile();

            List<Product> result = new List<Product>();

            for (int i = 0; i<products_.Count; i++)
            {
                if (products_[i].Price > x)
                {
                    result.Add(products_[i]);
                }
            }
            return result;
        }
    }
}
