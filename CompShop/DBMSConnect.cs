using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CompShop
{
    class DBMSConnect
    {
        static readonly string connectionString = @"Data Source=DESKTOP-KPH0SUJ\SQLEXPRESS;Initial Catalog=studentID_CompShop;Integrated Security=True;Trust Server Certificate=True";
        public static SqlConnection sqlConnection = new SqlConnection(connectionString);
        private SqlCommand command;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;

        public DBMSConnect() { 
            sqlConnection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = sqlConnection;
        }

        void OpenConnection()
        {
            if(sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        void CloseConnection()
        {
            if(sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        public DataTable GetDataTable(string query)
        {
            try
            {
                OpenConnection();
                dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(query, connectionString);
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex) {
                MessageBox.Show("Error:" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        public int SetData(string query, SqlParameter[] parameters)
        {
            try
            {
                OpenConnection();

                command = new SqlCommand(query, sqlConnection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
            return 0;
        }
    }
}
 