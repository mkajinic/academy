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
    public partial class frmSearch : Form
    {
        private frmCars carsForm;
        
        
        
            

        public frmSearch(frmCars carsForm)
        {
            InitializeComponent();
            this.carsForm = carsForm;
        }








        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            Text = "Task A Magdalena Kajinic " + DateTime.Now.ToShortDateString();

            //populate cboField with the field names Make, EngineSize, RentalPerDay and Available
            cboField.Items.Add ("Make");
            cboField.Items.Add("Engine Size");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");


            cboOperator.Items.Add("=");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">=");
            cboOperator.Items.Add("=>");





        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            carsForm.Show();
        }

        private void frmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            carsForm.Show();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (cboField.SelectedItem !=null  && cboOperator.SelectedItem != null)
            {   
                //  [RentalPerDay] > '50'
                string filter = "[" + cboField.SelectedItem.ToString() + "]" + " " +
                    cboOperator.SelectedItem.ToString() + " " + "'" + txbxValue.Text + "'";

                //Or
                //$ is for string interpolation 
                                                   //string filter2 = $" [{}]  {}  '{}'>"
                                 // [RentalPerDay]                         >                                      '50'
                string filter2 = $"[{cboField.SelectedItem.ToString()}] {cboOperator.SelectedItem.ToString()} '{txbxValue }'";

                //Or
                string filter3 = String.Format("[{0}] {1} '{2}'",
                    cboField.SelectedItem.ToString(), cboOperator.SelectedItem.ToString(), txbxValue.Text);
                    

                tblCarBindingSource.Filter = filter3;
                
            }
            else
            {
                MessageBox.Show("Please check your search criteria and try again");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
