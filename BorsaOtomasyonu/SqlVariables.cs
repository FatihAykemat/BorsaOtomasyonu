using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BorsaOtomasyonu
{
    public class SqlVariables
    {

        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGH2BTL\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State==ConnectionState.Closed)
            {
                tempConnection.Open();
            }
            else
            {

            }
        }
    }
}
