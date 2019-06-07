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
    public partial class frmSearch : Form
    {
        private frmCars carsForm;

        //We have to modify the constructor to expect parametar from carForm
        public frmSearch(frmCars carsForm)
        {
            InitializeComponent();

            this.carsForm = carsForm; //Grab the carsForm


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            //show the hidden frmCars
            carsForm.Show();
        }

        private void frmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            carsForm.Show();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            //Task A 17 Set the Text property of form frmSearch to: Task A Search your name and today's date. 
            Text = "Task A Search - Magdalena Kajinic " + DateTime.Now.ToShortDateString();

            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);

            //Part of task 15
            // make sure that the formats of the displayed fields are as shown in frmSearch
            // dataGridView1.Columns[4].DefaultCellStyle.Format = "c";

            //populate cboField with the field names Make, EngineSize, RentalPerDay and Available
            cboField.Items.Add("Make");
            cboField.Items.Add("Engine Size");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");

            //populate cboOperator with the following operator symbols, each one as a single list
            //item: =, <, >, <=, >=
            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");

        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //accident
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //accident click :(
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (cboField.SelectedItem != null && cboOperator.SelectedItem != null && String.IsNullOrEmpty(txBxValue.Text)) 
            {

               //"[RentalPerDay] > 50" example 
               string filter = "[" + cboField.SelectedItem.ToString() + "]" + " " 
                                   + cboOperator.SelectedItem.ToString()
                                   + " "      +       "'" 
                                   + txBxValue.Text + "'";
               

               //filter the underlined binding source which the datagridview is using to only show the rows
               //that match the filter criteria
               tblCarBindingSource.Filter = filter;

            }
            else
            {
                MessageBox.Show("Please check your search criteria and try again");
            }





        }
    }
}
