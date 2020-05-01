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
    public partial class billForm : Form
    {
        public billForm()
        {
            InitializeComponent();
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBill(object sender, EventArgs e)
        {
            conferenceForm conference = new conferenceForm();

            if (conference.schoolComboBox.SelectedItem == "Buckinghamshire New University Wycombe Campus")
            {
                //conference.
            }
        }
    }
}
