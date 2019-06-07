using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComponentBrowser;
using System.Security.Cryptography;

namespace ComponenetBrower
{
    public partial class FrmLogin : Form
    {
        //This will hold a reference to our SQL database collection
         private SqlConnection dbConnection;



        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //Try and get database connection and save the reference to ou this object SQlConnection reference
                //dbConnection
                dbConnection = ConnectToDB.GetDbConnection();
                dbConnection.Open();
                MessageBox.Show("Connection to Component DB");
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Database connection problem in: \n" +  ex.Message);
            }
        }

        /// <summary>
        /// gets the entered username and password allowing login if correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //get the entered username and password 
            // (trim white space)

            if (!String.IsNullOrEmpty(txBxUserName.Text) &&
                !String.IsNullOrEmpty(txBxPassword.Text))
            {
                //then hash password using the same method as the createUsers app
                var sha1 = new SHA1CryptoServiceProvider();

                byte[] bytes = Encoding.UTF8.GetBytes(txBxPassword.Text);
                string hashedPassword = Convert.ToBase64String(sha1.ComputeHash(bytes));

                // Create a query to check to see if the users exist
                //in the users table of database
                            //string findUser = $"SELECT * FROM Users WHERE AppUsername " +
                           // $"= '{txBxUserName.Text.Trim()}' AND HashedPassword = '{hashedPassword}' ";
                string findUser = $"SELECT * FROM Users WHERE AppUsername " +
                    $"= @username AND HashedPassword = @password";

                //Make SQLCommand
                SqlCommand searchForUser = new SqlCommand(findUser, dbConnection);

                //Make Sql Parameters
                SqlParameter uName = new SqlParameter("@username", SqlDbType.NVarChar);
                SqlParameter pw = new SqlParameter("@password", SqlDbType.Char);

                //Set the values of out parameter
                uName.Value = txBxUserName.Text.Trim().ToLower();
                pw.Value = hashedPassword;

                //Add the parameters to the SqlCommand
                searchForUser.Parameters.Add(uName);
                searchForUser.Parameters.Add(pw);


                //Execute command and read the results
                SqlDataReader results = searchForUser.ExecuteReader();

                //If we have results from out query...
                if (results.HasRows)
                {
                    //then we found a user with those credentials
                    //amd read the first result/record
                    results.Read();
                    //Welcome the user
                    //MessageBox.Show("Welcome " + results.GetString(1) + "\n\nYour user ID is: " + results.GetInt32(0));
                    //1 means read index 1 (0 would be ID, 1 is username, 2 is password)

                    //create and show a message window
                    //adapt to see if the user is user or admin- 9hide the buttons or disable them for the user)
                    //bool admin/user show the componnt browser form, when we login open a 
                    //componentbrowser to find out if it is user/admin and then decide you will have resulst.getboolean 
                    //of index 5 (sixth column in table)
                    //Just search button is bisible for user-read only- looks better
                    FrmComponentBrowser componentBrowserWindow = new FrmComponentBrowser(results.GetString(1), results.GetString(2), results.GetBoolean(5));

                    //we should close the results of database after use
                    results.Close();

                    componentBrowserWindow.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("User not found!");
                    txBxUserName.Clear();
                    txBxPassword.Clear();
                    results.Close();
                }

                //If the users is authenticated then show the messages form 
                // and close this login form
            }
            else
            {
                MessageBox.Show("Please check if you have entered both username and password");
            }
        }

        /// <summary>
        /// login by using enter key instead  mouse click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TryLoginOnEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call the login button click event handler method
                //We can use the value of null for both arguments in this case as they are not inside the body 
                //of th btnLogin_Click method
                btnLogin_Click(null, null);
            }
        }

        /// <summary>
        /// switches on next textBox by using enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txBxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txBxPassword.Focus();
            }
        }
    }
}
