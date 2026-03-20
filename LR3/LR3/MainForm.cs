using DrugLib;
using DrugLib.Model;
using DrugLib.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    
    public partial class MainForm : Form, IDishView
    {
        private DishPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new DishPresenter(new CsvDishModel(), this);

        }
        public void ShowCategories(List<string> categories)
        {
            CategoriesListBox.DataSource = categories;
        }
        public void ShowDishInCategory(List<Dish> dish)
        {
            DishComboBox.DataSource = null;
            DishComboBox.DataSource = dish;
            DishComboBox.DisplayMember = "Name";
        }

        public void ShowDishDetails(Dish dish)
        {
            PriceLabel.Text = dish.Price;
            ManufacturerLabel.Text = dish.Description;
            DateLabel.Text = dish.Ingredients;
            ProviderLabel.Text = dish.Group;
            try
            {
                DishPictureBox.Load(dish.ImagePath);
            }
            catch
            {}
        }
        public void ShowOrderSummary(Dictionary<string, int> orderItems)
        {
            string orderText = "Ваш заказ:\n";
            foreach (var item in orderItems)
            {
                orderText += $"{item.Key}: {item.Value} шт.\n";
            }
            MessageBox.Show(orderText, "Текущий заказ");
        }
        public string GetSelectedCategory()
        {
            return CategoriesListBox.SelectedItem?.ToString();
        }
        public Dish GetSelectedDish()
        {
            return DishComboBox.SelectedItem as Dish;
        }
        public int GetOrderQuantity()
        {
            return (int)QuantityNumericUpDown.Value;
        }
        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter_.CategorySelected();
        }
        private void DishComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter_.DishSelected();
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            presenter_.AddToOrder();
        }
    }
}
