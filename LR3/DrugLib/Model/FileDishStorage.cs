using DrugLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib
{
    public class FileDishStorage : ILoadDish
    {
        public Dictionary<string, List<Dish>> LoadDataFromCsv()
        {
            Dictionary<string, List<Dish>> result = new Dictionary<string, List<Dish>>();

            using (StreamReader reader = new StreamReader("data.csv", Encoding.GetEncoding(1251)))
            {
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] dishInfo = line.Split(';');

                    string category = dishInfo[0];
                    string name = dishInfo[1];
                    string price = dishInfo[2];
                    string manufacturer = dishInfo[3];
                    string date = dishInfo[4];
                    string provider = dishInfo[5];
                    string imagePath = dishInfo[6];

                    Dish dish = new Dish(name, price, manufacturer, date, provider, imagePath);

                    if (!result.ContainsKey(category))
                    {
                        result[category] = new List<Dish>();
                    }

                    result[category].Add(dish);
                }
            }

            return result;
        }
    }
}
