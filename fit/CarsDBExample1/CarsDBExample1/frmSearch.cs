using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDBExample1 //Magdalena Kajinic
{
    public partial class frmSearch : Form
    {
        //Field to hold a reference to frmCars object
        private frmCars carsForm;


        //Modify the constructor to expect a parametar of frmCars Object
        public frmSearch(frmCars carsForm)
        {
            InitializeComponent();

            //Grab the carsForm
            this.carsForm = carsForm;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();

            //Show the hidden frmCars Form
            carsForm.Show();

        }



        //not explicitly required for the assignment but nice to have (when clicked to x button)
        private void frmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Show the hidden frmCars Form
            carsForm.Show();
        }





    }
}
