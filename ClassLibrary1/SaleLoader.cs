using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SaleLoader
    {
        private List<Product> products_ = new List<Product>();

        public List<Product> ReadAllFile()
        {
            string path = @".\продукты.txt";
            StreamReader info = new StreamReader(path);
            string line;
            while ((line = info.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                products_.Add(new Product
                {
                    Name = lines[0],
                    Price = Convert.ToDouble(lines[1]),
                    Count = Convert.ToInt32(lines[2])
                });
            }
            info.Close();
            return products_;
        }
    }
}
