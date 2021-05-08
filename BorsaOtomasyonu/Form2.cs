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


namespace BorsaOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void kayitButton_Click(object sender, EventArgs e)
        {
            
            SqlCommand commandRegister = new SqlCommand("Insert into UserTable (UserName ,UserSurname,UserMail,UserPassword) values (@pname,@psurname,@pmail,@ppassword)", SqlVariables.connection);
            SqlVariables.CheckConnection(SqlVariables.connection);
            commandRegister.Parameters.AddWithValue("@pname", kullaniciBox.Text);
            commandRegister.Parameters.AddWithValue("@psurname", surNameBox.Text);
            commandRegister.Parameters.AddWithValue("@pmail", mailBox.Text);
            commandRegister.Parameters.AddWithValue("@ppassword", sifreBox.Text);

            commandRegister.ExecuteNonQuery();

        }
    }
}
