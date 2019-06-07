using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleGui2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelLastname_Click(object sender, EventArgs e)
        {

        }

        //event handler that responds to the button click 
        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtboxName.Text.Trim () + " " + textBoxLastname.Text.Trim());
        }

        //this will change the content of the lable everytime we change the content of the txt box
        private void txtboxName_TextChanged(object sender, EventArgs e)
        {
            lblTxtBxFirstNameContent.Text = txtboxName.Text;
        }
    }
}
