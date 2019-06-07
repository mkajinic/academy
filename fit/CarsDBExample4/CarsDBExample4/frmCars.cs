using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDBExample4
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
           Text  = "Task A - Magdalena Kajinic " + DateTime.Now.ToShortDateString();
            updateRecordDisplay();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveFirst();
            updateRecordDisplay();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MovePrevious();
            updateRecordDisplay();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveNext();
            updateRecordDisplay();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveLast();
            updateRecordDisplay();
        }

        private void txBxRecordDisplay_TextChanged(object sender, EventArgs e)
        {
            //no need for this one
        }

        private void updateRecordDisplay()
        {
            txBxRecordDisplay.Text =(tblCarBindingSource.Position + 1) + " of " +  tblCarBindingSource.Count;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.CancelEdit();
            hireDataSet.RejectChanges();
            updateRecordDisplay();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tblCarBindingSource.Count > 0)
            {
                tblCarBindingSource.RemoveCurrent();
                updateRecordDisplay();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                tblCarBindingSource.AddNew();
                updateRecordDisplay();

                chBxAvailable.CheckState = CheckState.Unchecked;
            }
            catch (Exception)
            {

                MessageBox.Show("The vehicle cannot be added to the database" +
                   "\nPlease check the values entered in all fields or press Cancel"); 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblCarBindingSource.EndEdit();

                //use the tableAdapter to push the changes in dataset to database
                int recordsUpdated = tblCarTableAdapter.Update(hireDataSet);

                updateRecordDisplay();

                MessageBox.Show(recordsUpdated + " records were updated");

            }
            catch (ConstraintException)
            
            {

                MessageBox.Show("That vehicle registration number already exists in the database" +
                    "\nPlease check the Registration or press Cancel"); 
            }
            catch (Exception)
            {
                MessageBox.Show("The vehicle cannot be added to the database" +
                    "\nPlease check the values entered in all fields or press Cancel");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchFrom = new frmSearch(this);

            searchFrom.Show();

            this.Hide();
               
        }
    }
}
