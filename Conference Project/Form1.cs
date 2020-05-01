using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference_Project
{
    public partial class conferenceForm : Form
    {
        private double bucksWTotal, bucksUTotal, readingTotal, bucksWAttendees,
            bucksUAttendees, readingAttendees;

        private int person, lunch, dinner;

        public conferenceForm()
        {
            InitializeComponent();
            person = 50;
            lunch = 10;
            dinner = 15;
        }

        private void showTotals(object sender, EventArgs e)
        {
            totalsForm totals = new totalsForm();
            totals.Show();
        }

        private void showBill(object sender, EventArgs e)
        {
            billForm billing = new billForm();
            billing.Show();
            billing.headingLabel.Text = firstNameTextBox.Text + " " + surnameTextBox.Text + " | " + schoolComboBox.SelectedItem;
        }
        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
