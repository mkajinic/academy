using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CreateUsers1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=MessageApp;Integrated Security=True;Connect Timeout=4;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            // Connect to database 
            SqlConnection conn = new SqlConnection(connection);

            //Try and open a connection to the DB
            conn.Open();

            // Ask user for username
            Console.Write("Please write username : ");
            string username = Console.ReadLine().Trim();

            // Ask user for phonenumber
            Console.Write("Please write phoneNumber : ");
            string number = Console.ReadLine().Trim();

            // Ask user for password
            Console.Write("Please write password : ");
            string password = Console.ReadLine().Trim();


            // Hash the password
            //we are converting string data and converting in bytes
            var sha1 = new SHA1CryptoServiceProvider();
            //even though var is used it is still gonna be same type as SHA1CryptoServiceProvider
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            string result = Convert.ToBase64String(sha1.ComputeHash(bytes));

            //Show the password
            Console.WriteLine("The hashed password is: " + result);


            // write usernames and hashed passwords to the db
            string command = $"INSERT INTO users VALUES ('{number}','{result}','{username}')";

            //Create a comman that we will execute the command
            SqlCommand insertUser = new SqlCommand(command, conn);

            try
            {
                // Execute the command
                insertUser.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                if (se.Number == 2627)
                {

                }
                Console.WriteLine("Could not add user!\n\nThat phone number already exists in the system");
                
            }






            // Close the DB connection
            conn.Close();

            Console.ReadLine();
        }//eND OF MAIN
    }
}
