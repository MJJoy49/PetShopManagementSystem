using System;
using System.Windows.Forms;
using PetMate_Shop.Views;

namespace PetMate_Shop.ComponentCarts
{
    public partial class VolunteerHelps : UserControl
    {
        private string _cityOrArea;
        private string _tasksCompleted;
        private string _nameValue;
        private string _volunteerId;

        public VolunteerHelps(
            string cityOrArea,
            string tasksCompleted,
            string nameValue,
            string volunteerId
        )
        {
            InitializeComponent();
            _cityOrArea = cityOrArea;
            _tasksCompleted = tasksCompleted;
            _nameValue = nameValue;
            _volunteerId = volunteerId;
            LoadData();
        }

        private void LoadData()
        {
            cityOrAreaLabel.Text = _cityOrArea;
            tasksCompletedLabel.Text = _tasksCompleted;
            nameValueLabel.Text = _nameValue;
            volunteerIdLabel.Text = _volunteerId;
        }

        private void HelpReqBtn_Click(object sender, EventArgs e)
        {
            HelpRequest helpRequest = new HelpRequest(_volunteerId);
            helpRequest.Show();
        }
    }
}
