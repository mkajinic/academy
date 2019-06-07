using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
         /// <summary>
         ///  Magdalena Kajinic Task A C# Assignment 29/01/2018
         /// </summary>
namespace CarsDBExample2
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);


            this.Text = "Task A Magdalena Kajinic " + DateTime.Now.ToShortDateString();

            updateRecordDisplay();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveNext();
            updateRecordDisplay();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MovePrevious();
            updateRecordDisplay();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveFirst();
            updateRecordDisplay();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveLast();
            updateRecordDisplay();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Add a new record trough the biding source
                tblCarBindingSource.AddNew();
                updateRecordDisplay();

                chBxAvailable.CheckState = CheckState.Unchecked;
            }
            catch (Exception)
            {

                MessageBox .Show ("The vehicle cannot be added to the database" +
                    "\nPlease check the values entered in all fields or press Cancel");
            }
           

        }




        private void txBxRecordDisplay_TextChanged(object sender, EventArgs e)
        {
            //no need, hit by accident
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Remove the current record in binding dataset
            //We should delete only if there is items on it
            if (tblCarBindingSource.Count > 0)
            {
                tblCarBindingSource.RemoveCurrent();
                updateRecordDisplay();
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //cancel the edit operation
            tblCarBindingSource.CancelEdit();
            hireDataSet.RejectChanges();
        }

        private void updateRecordDisplay()
        {
            txBxRecordDisplay.Text = (tblCarBindingSource.Position + 1) + " of " + tblCarBindingSource.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //create a new instance object of frmSearch while passing reference from this form
            //We will show the search window and close this window

            frmSearch searchForm = new frmSearch(this);

            searchForm.Show();

            //hide this formCars
            this.Hide();

        }

        private void txBxVehicleReg_Leave(object sender, EventArgs e)
        {
            //Tried something
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {   //apply pending changes to dataset
                //EndEdit - can throw a "Constraint/Exception"
                tblCarBindingSource.EndEdit(); 

                //use the tableAdapter to push the changes in dataset to database
                int recordsUpdated = tblCarTableAdapter.Update(hireDataSet); //field

                //Update record display
                updateRecordDisplay();

                //Show how many records were updated
                MessageBox.Show(recordsUpdated + " records were updated in the database");
            }
            catch (ConstraintException) //catches specific expeptions (primary key constraint violations)
            {
                //Show error info to user
                MessageBox.Show("That vehicle registration number already exists in the database" +
                    "\nPlease check the Registration or press Cancel");
            }
            catch (Exception) //Catch any other (all) exceptions
            {
                //Show error info to user
                MessageBox.Show("The vehicle cannot be added to the database" +
                    "\nPlease check the values entered in all fields or press Cancel");
            }


        }





    }
}
