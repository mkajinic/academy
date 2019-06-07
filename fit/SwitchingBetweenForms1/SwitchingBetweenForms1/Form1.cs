using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchingBetweenForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            //Create a new Form2 object and pass in a reference to this form instance
            //'this' is this object / Form1 instance 
            Form2 form2 = new Form2(this);

            //show form2
            form2.Show();

            //Hide this Form1 object 
            this.Hide();



        }

        private void btnOpenForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);

            form3.Show();

            //hide this form
            this.Hide();
        }
    }
}
