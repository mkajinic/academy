using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDBExample3
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hireDataSet);

        }

        private void tblCarBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hireDataSet);
            

        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            Text = "Task A - Magdalena Kajinic " + DateTime.Now.ToShortDateString();
            
            try
            {
                // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
                this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
                updateRecordDisplay();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured. Cannot load data!");
                btnSearch.Enabled = false; //Disable btnSearch control
            }
           

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            //accidental click
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblCarBindingSource.AddNew();
                availableCheckBox.CheckState = CheckState.Unchecked;
                
                updateRecordDisplay();
            }
            catch (Exception)
            {

                MessageBox.Show("The vehicle cannot be added to the database" +
                    "\nPlease check the values entered in all fields or press Cancel"); 
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tblCarBindingSource.Count  >  0)
            {
                this.tblCarBindingSource.RemoveCurrent();
                updateRecordDisplay();
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.CancelEdit();
            hireDataSet.RejectChanges();
            updateRecordDisplay();
        }

        private void updateRecordDisplay()
        {
            txBxRecordDisplay.Text = (this.tblCarBindingSource.Position + 1) + " of " + tblCarBindingSource.Count;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                tblCarBindingSource.EndEdit();

                int recordUpdated = tblCarTableAdapter.Update(hireDataSet);
                updateRecordDisplay();

                MessageBox.Show(recordUpdated + " records were updated");

            }
            catch (ConstraintException)
            {
                MessageBox.Show("That vehicle registration number already exists in the database" +
                   "\nPlease check the Registration or press Cancel");
            }
            catch (Exception)
            {
                MessageBox.Show("That vehicle registration number already exists in the database" +
                                  "\nPlease check the Registration or press Cancel");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch (this);

            searchForm.Show();

            this.Hide();

        }

        public void vehicleRegNoTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void txBxRecordDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
