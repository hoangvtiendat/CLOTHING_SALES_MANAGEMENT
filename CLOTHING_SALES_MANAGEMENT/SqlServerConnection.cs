using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOTHING_SALES_MANAGEMENT
{
    class SqlServerConnection
    {
        private string connectionString =@"Data Source=LAPTOP-68GDOI8K\MAYCUONG;Initial Catalog=CMU_CS_447_GROUP_PROJECT;Integrated Security=True";


        private SqlConnection connection;

        public SqlServerConnection()
        {
            connection = new SqlConnection(connectionString); // Fix the constructor call
        }
        
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                throw new Exception("Error Open connection: ", ex);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Close connection: ", ex);
            }
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                int result = command.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error execute Non query: ", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception("Error ExecuteQuery: ", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Execute Scalar:", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
