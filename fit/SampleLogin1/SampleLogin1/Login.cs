using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleLogin1
{
    public partial class Login : Form
    {
        //Reference to a database connection
        SqlConnection dbConnection;

        public Login()
        {
            InitializeComponent();
        }

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
                string findUser = $"SELECT * FROM users WHERE username " +
                    $"= '{txBxUserName.Text.Trim()}' AND passwordHash = '{hashedPassword}' ";

                //Make SQLCommand
                SqlCommand searchForUser = new SqlCommand(findUser, dbConnection);

                //Execute command and read the results
                SqlDataReader results = searchForUser.ExecuteReader();

                //If we have results from out query...
                if (results.HasRows)
                {
                    //then we found a user with those credentials
                    //amd read the first result/record
                    results.Read();
                    //Welcome the user
                    MessageBox.Show("Welcome " + results.GetString(0) + "\n\nYour user ID is: " + results.GetInt32(1));
                                                                         //1 means read index 1 (0 would be ID, 1 is username, 2 is password)
                    MessagesWindow messageWindow = new MessagesWindow(results.GetString(1));

                    //we should close the results of database after use
                    results.Close();

                    messageWindow.Show();
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

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                dbConnection = connectToDB.GetDbConnection();
                dbConnection.Open();
                MessageBox.Show("Connected to database!");
            }
            catch (SqlException se)
            {

                MessageBox.Show("Problem connected to the database!\n" + se.Message);
            }
            
        }
    }

    internal class SHA1CyrptoServiceProvider
    {
        public SHA1CyrptoServiceProvider()
        {
        }
    }
}
