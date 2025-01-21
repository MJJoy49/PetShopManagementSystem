using System;
using System.Windows.Forms;

namespace PetMate_Shop.ComponentForms
{
    public partial class OrderItems : UserControl
    {
        string _itemId;
        string _quantity;

        public OrderItems(string itemId, string quantity)
        {
            InitializeComponent();
            _itemId = itemId;
            _quantity = quantity;
            LoadValues();
        }

        
        public void LoadValues()
        {
            itemIdValueLabel.Text = _itemId;
            quantityValueLabel.Text = _quantity;
        }

        private void OrderItems_Load(object sender, EventArgs e)
        {
            
        }
    }
}
