using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleGui1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This is an even handler for the button click action 
        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("You just clicked the button!");
        }
    }
}
