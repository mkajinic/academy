using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleLogin1
{
    public partial class MessagesWindow : Form
    {
        public MessagesWindow(string username)
        {
            InitializeComponent();

            //set the form text to the users name
            this.Text = "Hi, " + username;
        }

        private void ExitApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
