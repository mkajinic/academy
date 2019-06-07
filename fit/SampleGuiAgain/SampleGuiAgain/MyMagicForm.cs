using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleGuiAgain
{
    public partial class MyFirstForm : Form
    {
        public MyFirstForm()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            string messageToDisplay = txBoxMessage.Text;
            MessageBox.Show(messageToDisplay);

            if (btnClickMe.Text.Equals ("ClickMe"))
            {
                btnClickMe.Text = "Click me Again";
            }


        }

        private void lblChangeTxt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblChangeTxt.Text.Equals("Yey its working")) 
            {
                lblChangeTxt.Text = "Where did i go";
            }
           else
	{
                lblChangeTxt .Text = "its working";
            }

        }

        private void MyFirstForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("lala");
            button2.Text  = "New Button";
        }
    }
}
