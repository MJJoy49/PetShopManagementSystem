using PetMate_Shop.ComponentForms;
using System;
using System.Windows.Forms;
using PetMate_Shop.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetMate_Shop.ComponentCarts
{
    public partial class VolunteerCart : UserControl
    {
        private string _volunteerIdValue;
        private string _userNameValue;
        private string _tasksCompletedValue;
        private string _rewardPointsValue;
        private UsersForm _recall;

        public VolunteerCart(
            string volunteerIdValue,
            string userNameValue,
            string tasksCompletedValue,
            string rewardPointsValue,
            UsersForm recall)
        {
            InitializeComponent();
            _volunteerIdValue = volunteerIdValue;
            _userNameValue = userNameValue;
            _tasksCompletedValue = tasksCompletedValue;
            _rewardPointsValue = rewardPointsValue;
            _recall = recall;

            showData();
        }

        void showData()
        {
            volunteerIdValue.Text = _volunteerIdValue;
            userNameValue.Text = _userNameValue;
            tasksCompletedValue.Text = _tasksCompletedValue;
            rewardPointsValue.Text = _rewardPointsValue;
        }

        private void VolunteerCart_Load(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            VolunteerEdit volunteerEdit = new VolunteerEdit(_userNameValue, _recall, _tasksCompletedValue, _rewardPointsValue);
            volunteerEdit.Show();
        }
    }
}
