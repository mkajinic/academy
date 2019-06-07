using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComponentBrowser;

namespace ComponenetBrower
{
    public partial class FrmComponentBrowser : Form
    {
        private DataSet ds;
        private SqlConnection conn;
        private SqlDataAdapter da;

        //SqlCommandBuilder - generates single table SQL commands
        //to reconcile the changes made to the database
        private SqlCommandBuilder sqlCommandBuilder;

        //bs will be used to bind the forms controls to the datasets with represents the Components data
        private BindingSource bs;


        //we will use this to map sub catergoies to catergories
        //The key will be subCategory and value will be Category
        private Dictionary<string, string> categoryMappings;

        public FrmComponentBrowser(string fName, string lName, bool isAdmin)
        {
            InitializeComponent();
            this.Text = $"Welcome , {fName} {lName}";

            if (!isAdmin)
            {
                DisableNonAdminFeatures();
            }
        }

        /// <summary>
        /// if user is not admin, buttons will be hidden
        /// </summary>
        private void DisableNonAdminFeatures()
        {
            btnAddNew.Hide();
            btnDelete.Hide();
            btnSave.Hide();
            btnCancel.Hide();
            btnEditCurrent.Hide();
            btnUploadImage.Hide();

        }

        private void ItemsEditable(bool edit)
        {
            foreach ( var control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).ReadOnly = !edit;
                    ((TextBox)control).BackColor = System.Drawing.SystemColors.Window;
                }
                else if (control.GetType() == typeof (ComboBox))
                {
                    ((ComboBox)control).Enabled = edit;
                    ((ComboBox)control).BackColor = System.Drawing.SystemColors.Window;
                }
                else if (control.GetType() == typeof(RichTextBox))
                {
                    ((RichTextBox)control).Enabled = edit;
                    ((RichTextBox)control).BackColor = Color.White;
                }
            }
        }

        /// <summary>
        /// closes the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
        private void txBxSKU_Leave(object sender, EventArgs e)
        {
           /*
            if (txBxSKU.Text == "SKU (Unique ID)")
            {
                txBxSKU.Text = "";
                txBxSKU.ForeColor = Color.Silver;
            }
            */

        }

        private void txBxSKU_Enter(object sender, EventArgs e)
        {
            /*
            if (txBxSKU.Text == "SKU (Unique ID)")
            {
                txBxSKU.Text = "";
                txBxSKU.ForeColor = Color.Black;
            }
            
            */
        }

        private void txBxName_Enter(object sender, EventArgs e)
        {
            /*
            if (txBxName.Text == "Name)")
            {
                txBxName.Text = "";
                txBxName.ForeColor = Color.Black;
            }
            */
        }

        private void txBxName_Leave(object sender, EventArgs e)
        {
            /*
            if (txBxName.Text == "Name")
            {
                txBxName.Text = "";
                txBxName.ForeColor = Color.Silver;
            }
            */
        }

        private void txBxPrice_Enter(object sender, EventArgs e)
        {
            /*
            if (txBxPrice.Text == "Price")
            {
                txBxPrice.Text = "";
                txBxPrice.ForeColor = Color.Black;
            }
            */
        }

        private void txBxPrice_Leave(object sender, EventArgs e)
        {
           /* if (txBxPrice.Text == "Price")
            {
                txBxPrice.Text = "";
                txBxPrice.ForeColor = Color.Black;
            }*/
        }

        //Event handler that gets invoked when the bs positionChanged event is raised
        private void BindingSourceRecordPositionChanged(object sender, EventArgs e)
        {
            UpdateRecordDisplay();

            //Fix the category when we change position in the binding sourse
            SetCategoryComboBox();
            
        }

        private void FrmComponentBrowser_Load(object sender, EventArgs e)
        {
            try
            {
                //GetDbConnection(0 - retunrs our applications
                //Single SQL database connection reference
                conn = ConnectToDB.GetDbConnection();

                //Inititialise the Dataset Object
                ds = new DataSet();

                //Create our query string to retrieve all component data
                // string selectAllComps = "SELECT * FROM Components";
                string selectAllComps = "SELECT * FROM Components";

                //Use an SQL data adapter to retrieve all the component table data from DB and fill 
                //Dataset 'ds' with it
                da = new SqlDataAdapter(selectAllComps, conn);

                //Fill the dataset with the retreived data
                da.Fill(ds);

                //Initialise the binding sourcee object and set its dataSource
                //which is the first table in the DataSet(ds.table[0])
                 bs = new BindingSource();
                bs.DataSource = ds.Tables[0]; //First table in collection

                //Update record display
                UpdateRecordDisplay();                

                //SetImageAndUpdateRecord is called when the bs Positionchanged event occurs
                bs.PositionChanged += SetImageAndUpdateRecord;

                //Link the SqlCommandBuilder to the SqlDataAdapter
                sqlCommandBuilder =new SqlCommandBuilder(da);

                //update record display
                txBxRecordDisplay_TextChanged(null, null);

                //Bind some of our dataset data to our form control by way of using the Binding Source object bs
                //We are binding the "Text" property of the txBxSKU textbox to the column named "Id" 
                //trought our binding source

                //new Binding (string propertyName, object dataSource, string dataMember)
                txBxSKU.DataBindings.Add(new Binding("Text", bs, "Id"));

                //Add other bindings
               // cmBxCategory.DataBindings.Add(new Binding("Text", bs, "Category"));
                cmBxSubcategory.DataBindings.Add(new Binding("Text", bs, "SubCategory"));
                txBxName.DataBindings.Add(new Binding("Text", bs, "Name"));
                txBxPrice.DataBindings.Add(new Binding("Text", bs, "Price"));

                //Format the price
                txBxPrice.DataBindings[0].FormattingEnabled = true;
                txBxPrice.DataBindings[0].FormatString = "c";

                txBxDescribtion.DataBindings.Add(new Binding("Text", bs, "Description"));
                cxBxAvailable.DataBindings.Add(new Binding("Checked", bs, "Available"));
                // We need this for adding a new record with bs.Addnew()
                ds.Tables[0].Columns["Available"].DefaultValue = true;

                dateTmFirstInStock.DataBindings.Add(new Binding("Text", bs, "DateFirstInStock"));
                // We need this for adding a new record with bs.Addnew()
                ds.Tables[0].Columns["DateFirstInStock"].DefaultValue = DateTime.Now.ToShortDateString();

                

                bxImage.DataBindings.Add(new Binding("Image", bs, "Image", true));



                //Call the GetAllCategoryDictionary method to load the dictionary
                GetAllCategoryDictionary();

                SetCategoryComboBox();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        /// <summary>
        /// Query the Category table and get all the subCategories and categories
        /// as a dictionary 
        /// </summary>
        /// <returns>Dictionary</string></returns>
        private void GetAllCategoryDictionary()
        
{
            //Initialise the Dictionary and assign the reference to categoryMappings
            categoryMappings = new Dictionary<string, string>();

            string selectCategory = "SELECT SubCategory, Category FROM Category";

            SqlCommand cmdSelectCategoryAndSubCategory = new SqlCommand(selectCategory, conn);

            SqlDataReader reader = cmdSelectCategoryAndSubCategory.ExecuteReader();

            //if the SqlReader has rowns then we will process it
            if (reader.HasRows)
            {
                
                //while we cna read(0 from the reader...
                //Read() returns a boolean if it was able to move to the next record
                while (reader.Read())
                {
                    //Add the subCategory and category to the list
                    categoryMappings.Add(reader.GetString(0), reader.GetString(1));
                                        
                }
            }
            reader.Close();    


        }

        /// <summary>
        /// fills category in combo box
        /// </summary>
        private void SetCategoryComboBox()
        {
            //if the sub Category combobox is not empty..
            if (!String.IsNullOrEmpty(cmBxSubcategory.Text))
            {
                //Clear the category cmbx first before adding
                cmBxCategory.Items.Clear();

                //then pull out the category from the dictionary using the key
                //key which will be the value of the subCategory combo box
                cmBxCategory.Items.Add(categoryMappings[cmBxSubcategory.Text]);

                //Set the selected index to 0 otherwise nothis is selected
                cmBxCategory.SelectedIndex = 0;
            }
        }

        
        private void SetImageAndUpdateRecord(object sender, EventArgs e)
        {
            UpdateRecordDisplay();
        }
        
        /// <summary>
        /// updates record display to show how many items is in database
        /// </summary>
        private void UpdateRecordDisplay()
        {
            txBxRecordDisplay.Text = bs.Position + 1 + " of " + bs.Count;
        }

        /// <summary>
        /// closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txBxRecordDisplay_TextChanged(object sender, EventArgs e)
        {
            txBxRecordDisplay.Text = bs.Position + 1 + " of " + bs.Count;
        }

        /// <summary>
        /// brings user to last item in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();           
        }

        /// <summary>
        /// click on the button changes the item to the next item in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();           

        }

        /// <summary>
        /// click on the button changes the item to the next item in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();           
        }

        /// <summary>
        /// shows the first item in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();            
        }


        
        /// <summary>
        /// opens a new window FrmSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch(ds, this);

            frmSearch.Show();
            Hide();

        }

        /// <summary>
        /// adds a new item to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                bs.AddNew();
                bxImage.Image = null;

                // ItemsEditable(false);
                // btnSearch.Enabled = true;
                // btnDelete.Enabled = Edit;

                UpdateRecordDisplay();
                // cxBxAvailable.CheckState = CheckState.Unchecked;

                bxImage.AllowDrop = true;

                

            }
            catch (Exception)
            {

                MessageBox.Show("The item cannot be added to the database" +
                    "\nPlease check the values entered in all fields or press Cancel");
            }
        }

        /// <summary>
        /// saves the new added item in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Apply pending changes to the underlying data source
                bs.EndEdit();
                // ds.AcceptChanges();

                UpdateRecordDisplay();
                //update the sqlDataAdapter (da) with the changes made to the table [0]
                //in our dataset (ds)
                int rowsupdated =da.Update(ds.Tables[0]);
                MessageBox.Show($"{rowsupdated} record(s) saved to database");
            }
            catch (ConstraintException)
            {
                MessageBox.Show("The item already exists in the database.");
            }
            catch (Exception ex1)
            {

                MessageBox.Show("The item cannot be added in the database." + ex1.Message);
            }
            
            // EnableNavigationButtons(true); not yet done method

            //Clear and refill the dataset
            ds.Clear();
            da.Fill(ds);

            //bs.ResetBindings(true);


            //Move to last record
            bs.Position = ds.Tables[0].Rows.Count - 1;

        }
        
            
        /// <summary>
        /// accidental click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bxImage_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// allows adding an image by draging and droping file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bxImage_DragDrop(object sender, DragEventArgs e)
        {
            //an array of string wihic will hold the image file path and names
            string[] imageNames = (string[])e.Data.GetData(DataFormats.FileDrop);


            //create a newImage from the first file name in the array
            Image newPicture = Image.FromFile(imageNames[0]);

            //set the new image for the pictureBoc object
            bxImage.Image = newPicture;

            //SaveItemImageToDataSet();
        }

        /// <summary>
        /// Save image in database when adding a new dataset
        /// </summary>
        private void SaveItemImageToDataSet()
        {
            //create a new memory Stream object
            MemoryStream imageData = new MemoryStream();

            //save the image to the Memory Stram object
            bxImage.Image.Save(imageData, System.Drawing.Imaging.ImageFormat.Bmp);

            //returns a byte []
            ds.Tables[0].Rows[bs.Position]["Image"] = imageData.ToArray();

        }

        private void bxImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        /// <summary>
        /// Opens a new window to allow file to be chosen from operating system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            //create a new instance of openFile Dialog
            OpenFileDialog filePicker = new OpenFileDialog();

            //set the filter for the file types that the dialog shows
            filePicker.InitialDirectory = @"c\components_img";

            filePicker.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.pmg|BMP Files (*.bmp)|*.bmp| All Files (*.*)|*.*";

            //if the showDialog result sint he ok button being pressed then set the pictureBox image
            if (filePicker.ShowDialog() == DialogResult.OK)
            {
                bxImage.Load(filePicker.FileName);
            }
        }

        private void btnEdit(object sender, EventArgs e)
        {
            bxImage.AllowDrop = true;
            btnUploadImage.Show();
        }

        /// <summary>
        /// cancels any current modifications 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //cancel any current edit on the binidng source which will revert 
            //the data in all fields (textboxes etc)
            //back to initial values
            bs.CancelEdit();

            //reject any changes made to the datase since the last changes
            ds.RejectChanges();

            UpdateRecordDisplay();
            
        }

        /// <summary>
        /// Delete current file from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                //remove the current item from the list (bs)
                bs.RemoveCurrent();

                //commit the changes to the dataset
                ds.AcceptChanges();
               // da.Update(ds);

                //fix the record display to show the correct number of records
                UpdateRecordDisplay();
                                
            }
        }


        //instance method
        public void MoveToComponentSKU (int sku)
        {
            //use the given ID to move the binding source to the component that has that ID

            //get the index of the item in the binding source (dataset)
            int itemIndex = bs.Find("sku", sku);

            //move to that position in the binding source
            bs.Position = itemIndex;

        }

        /// <summary>
        /// Accidental Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Accidental Click    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label6_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Accidental Click    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmBxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Accidental Click    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txBxSKU_TextChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
