using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedAndBreakfast
{
    public partial class BaileysForm : Form
    {
        public BaileysForm()
        {
            InitializeComponent();
        }

        private void BaileysForm_Load(object sender, EventArgs e)
        {

        }

        private void belleAireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(belleAireCheckBox.Checked)
            {
                BelleAireForm belleAireForm = new BelleAireForm();
                belleAireForm.ShowDialog();
                belleAireCheckBox.Checked = false;
            }
        }

        private void lincolnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(lincolnCheckBox.Checked)
            {
                LincolnForm linconInForm = new LincolnForm();
                linconInForm.ShowDialog();
                lincolnCheckBox.Checked = false;
            }
        }

        private void mealButton_Click(object sender, EventArgs e)
        {
            BreakfastOptionForm breakfastForm = new BreakfastOptionForm();
            breakfastForm.ShowDialog();
        }
    }
}
