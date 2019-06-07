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
    public partial class Form3 : Form
    {

        private Form1 form1;



        public Form3(Form1 callingFrom)
        {
            InitializeComponent();

            this.form1 = callingFrom;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
            
            
        }
    }
}
