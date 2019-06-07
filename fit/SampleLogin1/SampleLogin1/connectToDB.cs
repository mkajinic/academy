using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SampleLogin1
{
    class connectToDB
    {
        private static string connectionInfo = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=MessageApp;Integrated Security=True;Connect Timeout=4;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static SqlConnection dbConnection;

        public static SqlConnection GetDbConnection()
        {
            if (dbConnection == null)
            {
                try
                {
                    dbConnection = new SqlConnection(connectionInfo);
                    return dbConnection;
                }
                catch (Exception)
                {

                    Console.WriteLine("Something went wrong");
                    return dbConnection;
                }
                   
            }
            else
            {
                return dbConnection;
            }
        }


    }
}
