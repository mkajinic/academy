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
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);

            //Task A part 3
            //set the Text property of this form object 
            this.Text = "Task A Magdalena Kajinic " + DateTime.Now.ToShortDateString();

            //Update record display box
            updateRecordDisplay();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveNext();
            updateRecordDisplay();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MovePrevious();
            updateRecordDisplay();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveFirst();
            updateRecordDisplay();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveLast();
            updateRecordDisplay();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add a new record trough the binding source 
            tblCarBindingSource.AddNew();

            //Update the record display
            updateRecordDisplay();

            //Set the checkbox to show as unchecked initialy 
            ckBxAvailable.CheckState = CheckState.Unchecked;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Remove the current record in the data set by way of the binding source
            //We should only delete if the binding source has items on it
            if (tblCarBindingSource.Count > 0)
            {
                tblCarBindingSource.RemoveCurrent();
            }
            updateRecordDisplay();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Cancel the edit operation being performed on the dataset trough the bining course
            tblCarBindingSource.CancelEdit();
            hireDataSet.RejectChanges();
            updateRecordDisplay();
        }



        private void updateRecordDisplay()
        {
            txBxRecordDisplay.Text = ( tblCarBindingSource.Position+1) + " of " + tblCarBindingSource.Count;
        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Create a new instance (object) of frmSearch Form while pasing in a reference to this form
            //Show the frmSearch Form and hide this form
            frmSearch searchForm = new frmSearch(this);

            //Show the new Search Form
            searchForm.Show();

            //hide this form
            this.Hide();


        }
    }

}
