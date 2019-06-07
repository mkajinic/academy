using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponenetBrower
{
    public partial class FrmSearch : Form
    {
       
        private FrmComponentBrowser frmComponent;
        private DataSet ds;
        private DataView dataView;

        

        public FrmSearch(DataSet ds, FrmComponentBrowser frmComponent)
        {
            InitializeComponent();
            this.frmComponent = frmComponent;

            this.ds = ds;

            //Initialise the DataView so that  it is view
            //of the first DataTable in our dataset 'ds'
          
            dataView = new DataView(ds.Tables[0]);

            dataGridView1.DataSource = dataView;
            dataGridView1.RowTemplate.Height = 80;
        }

        /// <summary>
        /// Closes the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmComponent.Show();
            
            
            
        }

        /// <summary>
        /// filling out fields in combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            cmbxSearchField1.Items.Add("Id");
            cmbxSearchField1.Items.Add("Name");
            cmbxSearchField1.Items.Add("Description");
            cmbxSearchField1.Items.Add("Price");
            cmbxSearchField3.Items.Add("Category");
            cmbxSearchField1.Items.Add("SubCategory");
            cmbxSearchField1.Items.Add("DateFirstInStock");
            cmbxSearchField1.Items.Add("Available");


            cmbxSearchField2.Items.Add("Id");
            cmbxSearchField2.Items.Add("Name");
            cmbxSearchField2.Items.Add("Description");
            cmbxSearchField2.Items.Add("Price");
            cmbxSearchField3.Items.Add("Category");
            cmbxSearchField2.Items.Add("SubCategory");
            cmbxSearchField2.Items.Add("DateFirstInStock");
            cmbxSearchField2.Items.Add("Available");


            cmbxSearchField3.Items.Add("Id");
            cmbxSearchField3.Items.Add("Name");
            cmbxSearchField3.Items.Add("Description");
            cmbxSearchField3.Items.Add("Price");
            cmbxSearchField3.Items.Add("Category");
            cmbxSearchField3.Items.Add("SubCategory");
            cmbxSearchField3.Items.Add("DateFirstInStock");
            cmbxSearchField3.Items.Add("Available");

            cmbxOperator1.Items.Add("<");
            cmbxOperator1.Items.Add(">");
            cmbxOperator1.Items.Add("=");
            cmbxOperator1.Items.Add(">=");
            cmbxOperator1.Items.Add("<=");

            cmbxOperator2.Items.Add("<");
            cmbxOperator2.Items.Add(">");
            cmbxOperator2.Items.Add("=");
            cmbxOperator2.Items.Add(">=");
            cmbxOperator2.Items.Add("<=");

            cmbxOperator3.Items.Add("<");
            cmbxOperator3.Items.Add(">");
            cmbxOperator3.Items.Add("=");
            cmbxOperator3.Items.Add(">=");
            cmbxOperator3.Items.Add("<=");





        }

        /// <summary>
        /// fills out the database grid with data, and clears the combo box and text box fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            dataView.RowFilter = null;

            cmbxSearchField1.SelectedItem = null;
            cmbxOperator1.SelectedItem = null;

            cmbxSearchField2.SelectedItem = null;
            cmbxOperator2.SelectedItem = null;

            cmbxSearchField3.SelectedItem = null;
            cmbxOperator3.SelectedItem = null;

            txbxFilterValue1.Text = null;
            txbxFilterValue2.Text = null;
            txbxFilterValue3.Text = null;
        }


        /// <summary>
        /// filters the data in datagrid as per parameters entered by user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRunSearch_Click(object sender, EventArgs e)
        {

            if (cmbxSearchField1.SelectedItem != null && cmbxOperator1.SelectedItem != null)
            {
                
              
                string filter1 = String.Format("[{0}] {1} '{2}'",
                    cmbxSearchField1.SelectedItem.ToString(), cmbxOperator1.SelectedItem.ToString(), txbxFilterValue1.Text);


                dataView.RowFilter = filter1;

            }
            else
            {
                MessageBox.Show("Please check your search criteria and try again");
            }
        }


        /// <summary>
        /// accidental click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbxSearchField3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Error
        }

        private void bntSelect_Click(object sender, EventArgs e)
        {
            //If a component is selected the...
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //so we have a row selected
                //we want to ge th e ID sku value of the component int he selected row
                int componentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SKU"].Value.ToString());
                frmComponent.MoveToComponentSKU(componentID);
                frmComponent.Show();
            }
            else
            {
                MessageBox.Show("Rows are not selected. Please select component");
            }
        }

        /// <summary>
        /// Accidental click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
