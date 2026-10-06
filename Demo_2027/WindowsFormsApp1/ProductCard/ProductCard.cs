using DemoLib;
using DemoLib.Views;
using System.Drawing;
using System.Windows.Forms;

namespace DemoUIComponents
{
    public partial class ProductCard: UserControl, IProductsView
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public void Show(Product product)
        {
            CategoryLabel1.Text = product.Category;
            CountLabel.Text = product.Count.ToString();
            PartsLabel.Text = product.Parts;
            nameLabel.Text = product.Name;
            supplierLabel.Text = product.Supplier;
            priceLabel.Text = product.Price.ToString();
            ShowPhoto(product.ImagePath); 
        }
        public void ShowPhoto(string path)
        { 
            productImages.ImageLocation = path;
            
        }

        private void ProductCard_MouseLeave(object sender, System.EventArgs e)
        {
            string hexColor = "#D2F6E7";
            Color color = ColorTranslator.FromHtml(hexColor);
            BackColor = color;

        }

        private void ProductCard_MouseMove(object sender, MouseEventArgs e)
        {
            string hexColor = "#70B2AF";
            Color color = ColorTranslator.FromHtml(hexColor);
            BackColor = color;
        }

        private void ProductCard_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
