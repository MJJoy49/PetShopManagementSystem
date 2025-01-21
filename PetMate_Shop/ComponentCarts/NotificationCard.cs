using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetMate_Shop.ComponentCarts
{
    public partial class NotificationCard : UserControl
    {
        string _date;
        string _msg;
        string _status;

        public NotificationCard(string date, string msg, string status)
        {
            _date = date;
            _msg = msg;
            _status = status;
            InitializeComponent();
            upData();
        }

        public void upData()
        {
            dateLabel.Text = _date;
            msgLabel.Text = _msg;

            if (_status == "seen")
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
            }
            else
            {
                this.BackColor = Color.FromArgb(47, 47, 47);
            }
        }

        private void NotificationCard_Load(object sender, EventArgs e)
        {

        }
    }
}
