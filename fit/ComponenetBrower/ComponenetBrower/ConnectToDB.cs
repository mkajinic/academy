using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ComponentBrowser
{
    class ConnectToDB
    {
        private static string connectionInfo = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = ComponentDB; Integrated Security = True; Connect Timeout = 4;";

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
                catch (Exception ex)
                {

                    //Rethrowing the exception
                    //We throw the exception up the method call chain
                    //Which means that the caller should to deal with the possibility of an exception
                    throw ex;
                    
                }
                   
            }
            else
            {
                return dbConnection;
            }
        }


    }
}
