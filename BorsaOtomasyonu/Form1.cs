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
using System.Data;

namespace BorsaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGH2BTL;Initial Catalog=UserDB;Integrated Security=True");
       
        DataSet dt = new DataSet();
        private void button2_Click(object sender, EventArgs e)
        {
            dt.Clear();
            SqlVariables.CheckConnection(SqlVariables.connection);
            SqlDataAdapter adtr = new SqlDataAdapter("select * from UrunTable", SqlVariables.connection);

            adtr.Fill(dt,"UrunTable");

            urunListele.DataSource = dt.Tables["UrunTable"];

        }

       

        private void urunListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
            urunFiyatBox.Text= urunListele.CurrentRow.Cells["UrunFiyat"].Value.ToString();
            urunMikBox.Text = urunListele.CurrentRow.Cells["urunMiktar"].Value.ToString();

        }

        public void dataGetir()
        {
            SqlCommand command = new SqlCommand();

            command.CommandText = "select *from UserTable";
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            SqlDataReader dr;
            connection.Open();
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["UserName"]);
            }
            connection.Close();
        }
        public void kategoriDataGetir()
        {
            SqlCommand command = new SqlCommand();

            command.CommandText = "select *from UrunTable";
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            SqlDataReader dr;
            connection.Open();
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(dr["UrunKategori"]);
            }
            connection.Close();
        }
        

        public string loginVeri;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGetir();
            kategoriDataGetir();
            saticiAdiText.Text = loginVeri;
        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from UserTable where UserName='" + comboBox1.SelectedItem.ToString() + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                
                paraEkleBox.Text = dr["UserPara"].ToString();

            }
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPage1");
            onayLabel.Text = paraEkleBox.Text + " tutarında para onay beklemektedir";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update UserTable set UserPara+=@puserpara2 where UserName=@username";
            cmd.Parameters.AddWithValue("@username", comboBox1.Text);
            cmd.Parameters.AddWithValue("@puserpara2", Convert.ToDecimal(paraEkleBox.Text));

            cmd.ExecuteNonQuery();
            connection.Close();

            paraEkleBox.Text = "";
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Para Hesaba Eklenmiştir");
            onayLabel.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            SqlCommand ekleCommand = new SqlCommand("insert into UrunTable(UrunKategori,UrunMiktar,UrunFiyat,UrunSaticiAdi) values (@purunkategori,@purunmiktar,@purunfiyat,@purunsaticiadi)", SqlVariables.connection);
            SqlVariables.CheckConnection(SqlVariables.connection);

            
            ekleCommand.Parameters.AddWithValue("@purunkategori", kategoriBox.SelectedItem);
            ekleCommand.Parameters.AddWithValue("@purunfiyat", double.Parse(urunFiyatBox.Text));
                ekleCommand.Parameters.AddWithValue("@purunmiktar", int.Parse(urunMikBox.Text));
                ekleCommand.Parameters.AddWithValue("@purunsaticiadi", saticiAdiText.Text);
                ekleCommand.ExecuteNonQuery();
            
            MessageBox.Show("Ürün Ekle");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPage1");
            urunOnay.Text = "Ürün ekleme onayı beklenmektedir";
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Ürün satıcı hesabına eklenmiştir");
            urunOnay.Text = "";
        }
       
        public int value =0;
       
        public int verCek()
        {
            
            int minValue=0;
            textBox2.Text = (from DataGridViewRow row in urunListele.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                             select Convert.ToInt32(row.Cells[2].FormattedValue)).Min().ToString();

            minValue = Convert.ToInt32( textBox2.Text);
            
            int girilenMiktar = Convert.ToInt32(textBox1.Text);
            value = minValue * girilenMiktar;
            return value;

           
        }
        public void urunSaticiAdiGetir()
        {
            SqlCommand command = new SqlCommand();

            command.CommandText = "select UrunSaticiAdi from UrunTable where UrunFiyat=@purunfiyat";
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("purunfiyat", textBox2.Text);
            SqlDataReader dr;
            connection.Open();
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                //comboBox2.Items.Add(dr["UrunSaticiAdi"]);
                textBox3.Text = dr["UrunSaticiAdi"].ToString();
            }
            connection.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            verCek();
            urunSaticiAdiGetir();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update UrunTable set UrunMiktar-=@purunmiktar  where UrunKategori=@purunkat and UrunFiyat=@urunfiyat";        
            cmd.Parameters.AddWithValue("@purunkat", comboBox2.Text);
            cmd.Parameters.AddWithValue("@purunmiktar", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@urunfiyat", textBox2.Text);


            cmd.ExecuteNonQuery();
           
            //MessageBox.Show(value.ToString());
            SqlCommand komut = connection.CreateCommand();

            komut.CommandType = CommandType.Text;
            komut.CommandText = "update UserTable set UserPara-=@puserpara where UserKullanici=@puserkullanici";
            komut.Parameters.AddWithValue("@puserpara", Convert.ToDecimal(value));
            komut.Parameters.AddWithValue("@puserkullanici", saticiAdiText.Text);
            komut.ExecuteNonQuery();

            SqlCommand komut2 = connection.CreateCommand();

            komut2.CommandType = CommandType.Text;
            komut2.CommandText = "update UserTable  set UserPara+=@puserpara where UserKullanici=@userkullanici";
            komut2.Parameters.AddWithValue("@puserpara", Convert.ToDecimal(value));
            komut2.Parameters.AddWithValue("@userkullanici",textBox3.Text);
            komut2.ExecuteNonQuery();
            connection.Close();            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable tablo = new DataTable();
            connection.Open();
            SqlDataAdapter data = new SqlDataAdapter("select *from UrunTable where UrunKategori like '%"+comboBox2.SelectedItem.ToString()+"'",SqlVariables.connection);

            data.Fill(tablo);
            urunListele.DataSource = tablo;
            connection.Close();
        }

       
    }
}
