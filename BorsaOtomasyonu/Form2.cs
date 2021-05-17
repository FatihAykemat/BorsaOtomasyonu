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
        public static string loginVeri;
        private void kayitButton_Click(object sender, EventArgs e)
        {
            
            SqlCommand commandRegister = new SqlCommand("Insert into UserTable (UserName ,UserSurname,UserMail,UserPassword,UserKullanici,UserTcNo,UserTelefon,UserAdres,UserPara) values (@pname,@psurname,@pmail,@ppassword,@pkullanici,@ptcno,@ptelefon,@padres,@puserpara)", SqlVariables.connection);
            SqlVariables.CheckConnection(SqlVariables.connection);
            commandRegister.Parameters.AddWithValue("@pname", adBox.Text);
            commandRegister.Parameters.AddWithValue("@psurname", surNameBox.Text);
            commandRegister.Parameters.AddWithValue("@pmail", mailBox.Text);
            commandRegister.Parameters.AddWithValue("@ppassword", sifreBox.Text);
            commandRegister.Parameters.AddWithValue("@pkullanici",kullaniciBox.Text);
            commandRegister.Parameters.AddWithValue("@ptelefon", telefonBox.Text);
            commandRegister.Parameters.AddWithValue("@ptcno", tcnoBox.Text);
            commandRegister.Parameters.AddWithValue("@padres", adresBox.Text);
            commandRegister.Parameters.AddWithValue("@puserpara", 0);

            commandRegister.ExecuteNonQuery();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.loginVeri = kullaniciLogin.Text;
            SqlCommand loginCommand = new SqlCommand("Select * from UserTable where UserKullanici=@pkullanici and UserPassword=@ppassword",SqlVariables.connection);
            
            SqlVariables.CheckConnection(SqlVariables.connection);

            loginCommand.Parameters.AddWithValue("@pkullanici", kullaniciLogin.Text);
            loginCommand.Parameters.AddWithValue("@ppassword", sifreLogin.Text);

            SqlDataAdapter da = new SqlDataAdapter(loginCommand);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Giris Basarili");
               
                form1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya sifre hatalı");
            }
            
        }

       
    }
}
