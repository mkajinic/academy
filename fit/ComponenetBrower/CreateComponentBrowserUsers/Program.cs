using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CreateComponentBrowserUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string connection = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = ComponentDB; Integrated Security = True; Connect Timeout = 4; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            // Connect to database 
            SqlConnection conn = new SqlConnection(connection);

            //Try and open a connection to the DB
            conn.Open();

            // Ask user for username
            Console.Write("Please write username: ");
            string username = Console.ReadLine().Trim().ToLower();

            // Ask user for password
            Console.Write("Please write password: ");
            string password = Console.ReadLine().Trim();

            // Ask user for FirstName and LastName
            Console.Write("Please write your first name: ");
            string firstName = Console.ReadLine().Trim();

            Console.Write("Please write your lastname name: ");
            string lastName = Console.ReadLine().Trim();

            // Is the user is Admin or not
            Console.Write("Is this user Admin? (enter Y/N)");
            bool admin = (Console.ReadLine().Trim().ToLower().StartsWith("y"))? true : false;


          


            // Hash the password
            //we are converting string data and converting in bytes
            var sha1 = new SHA1CryptoServiceProvider();
            //even though var is used it is still gonna be same type as SHA1CryptoServiceProvider
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            string result = Convert.ToBase64String(sha1.ComputeHash(bytes));

            //Show the password
            Console.WriteLine("The hashed password is: " + result);


            // write usernames and hashed passwords to the db
            string command = $"INSERT INTO Users VALUES ('{firstName}', '{lastName}', '{username}','{result}', '{admin}')";

            //Create a comman that we will execute the command
            SqlCommand insertUser = new SqlCommand(command, conn);
           

            try
            {
                // Execute the command
                insertUser.ExecuteNonQuery();
                Console.WriteLine("User {0} created.", username);
            }
            catch (SqlException se)
            {
                if (se.Number == 2627)
               {
                   Console.WriteLine("Could not add user!\n\nThat username already exists in the system");
                  Console.ReadLine();
                }
                

            }
            finally
            {
                conn.Close();
                
            }


            Console.ReadLine();



        }//eND OF MAIN
    }
}
