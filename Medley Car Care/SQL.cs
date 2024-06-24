using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Syncfusion.PMML;
using System.Data;
using Windows.Storage.Streams;



namespace Medley_Car_Care
{
    internal class SQL
    {
        // Connecton string 

        private readonly string ConnectionString;
        private readonly SqlConnection Con;



        // Constructor
        public SQL()
        {
            ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\visual studio\Medley-Car-Care-Management-System\Medley Car Care\MedleyDB.mdf; Integrated Security = True";
            Con = new SqlConnection(ConnectionString);
        }


        // Helper Functions 

        public void CloseConnection()
        {
            if(Con.State==System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
        }

        public void OpenConnection()
        {
            if (Con.State == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }
        }


        public void ExecuetNonQuery(string query)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable ExecuetQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }


        public SqlDataReader ExecuteReader(string query)
        {
            SqlDataReader rdr;

            OpenConnection();

            SqlCommand cmd = new SqlCommand(query, Con);
            rdr = cmd.ExecuteReader();

            return rdr;
        }

        public object ExecuteScalar(string query)
        {
            object result;
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, Con);
                result = cmd.ExecuteScalar();


            }
            finally
            {
                CloseConnection();
            }
            return result;
        }



        public void ThrowException(SqlException ex)
        {
            MessageBox.Show(ex.ToString());
        }


        // Main Functions 





        

    }
}
