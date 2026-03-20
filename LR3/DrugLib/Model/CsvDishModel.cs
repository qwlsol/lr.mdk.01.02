using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib.Model
{
    public class CsvDishModel : IDishModel
    {
        private Dictionary<string, List<Dish>> drugs_ = new Dictionary<string, List<Dish>>();
        private Dictionary<string, int> orderItems_ = new Dictionary<string, int>();
        private FileDishStorage fileStorage_ = new FileDishStorage();

        public CsvDishModel()
        {
            drugs_ = fileStorage_.LoadDataFromCsv();
        }
        public void AddOrderItem(string drugName, int quantity)
        {
            if (orderItems_.ContainsKey(drugName))
            {
                orderItems_[drugName] += quantity;
            }
            else
            {
                orderItems_[drugName] = quantity;
            }
        }

        public void ClearOrder()
        {
            orderItems_.Clear();
        }

        public Dictionary<string, int> GetOrderItems()
        {
            return orderItems_;
        }

        public Dictionary<string, List<Dish>> LoadData()
        {
            return drugs_;
        }

        public Dictionary<string, List<Dish>> LoadDataFromCsv()
        {
            throw new NotImplementedException();
        }
    }
}
