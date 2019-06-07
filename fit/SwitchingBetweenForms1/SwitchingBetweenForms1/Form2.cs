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
    public partial class Form2 : Form
    {
        //A reference to a Form1 object
        private Form1 form1;



        public Form2(Form1 callingForm)
        {
            InitializeComponent();

            //save the passed in Form1 object reference
            //to our instance field 'form1'
            this.form1 = callingForm;


        }

        private void btnOpenForm1_Click(object sender, EventArgs e)
        {
            //Show the Form1 object that called this form
            form1.Show();

            //Close this Form2 instance
            this.Close();
        }
    }
}
