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
using System.Xml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
        public int minValue2 = 0;
      

    

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
        decimal toplam = 0;
        decimal DovizGetir()
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            decimal USD, EURO, STERLIN;
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
          
            EURO = Convert.ToDecimal(xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerText.Replace('.', ','));
            STERLIN = Convert.ToDecimal(xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerText.Replace('.', ','));
            USD = Convert.ToDecimal(xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerText.Replace('.', ','));
            if (paraBirimiBox.SelectedItem.ToString() == "USD")
            {
                toplam = USD * Convert.ToDecimal(paraEkleBox.Text);

            }
            else if (paraBirimiBox.SelectedItem.ToString()=="EURO")
            {
                toplam = EURO * Convert.ToDecimal(paraEkleBox.Text);
            }
            else if (paraBirimiBox.SelectedItem.ToString()=="STERLIN")
            {
                toplam = STERLIN * Convert.ToDecimal(paraEkleBox.Text);
            }
            else if (paraBirimiBox.SelectedItem.ToString()=="TL")
            {
                toplam =1*Convert.ToDecimal(paraEkleBox.Text);
            }



            return toplam ;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            DovizGetir();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update UserTable set UserPara+=@puserpara2 where UserName=@username";
            cmd.Parameters.AddWithValue("@username", comboBox1.Text);
            cmd.Parameters.AddWithValue("@puserpara2",toplam);

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
            minValue2 = minValue;
            
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
        public DateTime time;
        DataSet dt2 = new DataSet();
        public void button6_Click(object sender, EventArgs e)
        {
            verCek();
            urunSaticiAdiGetir();
            SqlCommand cmd;
            connection.Open();
            cmd = connection.CreateCommand();            
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update UrunTable set UrunMiktar-=@purunmiktar  where UrunKategori=@purunkat and UrunFiyat=@urunfiyat";        
            cmd.Parameters.AddWithValue("@purunkat", comboBox2.Text);
            cmd.Parameters.AddWithValue("@purunmiktar", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@urunfiyat", textBox2.Text);
            /*

            DataRow drow = dt2.NewRow();
            drow["Tarih"] =  DateTime.Now.ToShortDateString();
            drow["Ürün Tipi"]=comboBox2.SelectedItem.ToString();
            drow["Alım Tutarı"] = textBox4.Text;
            drow["Miktar"] = textBox1.Text;
            dt2.Rows.Add(drow);
            */
            
            SqlCommand ekleCommand = new SqlCommand("insert into RaporTable(Tarih,UrunTipi,AlimTutari,Miktar) values (@ptarih,@puruntipi,@palimtutari,@pmiktar)", SqlVariables.connection);
            SqlVariables.CheckConnection(SqlVariables.connection);


            ekleCommand.Parameters.AddWithValue("@ptarih", Convert.ToDateTime( DateTime.Now.ToShortDateString()));
            ekleCommand.Parameters.AddWithValue("@puruntipi",comboBox2.SelectedItem.ToString());
            ekleCommand.Parameters.AddWithValue("@palimtutari", Convert.ToInt32(textBox4.Text));
            ekleCommand.Parameters.AddWithValue("@pmiktar",Convert.ToInt32(textBox1.Text));
            ekleCommand.ExecuteNonQuery();
            if (Convert.ToInt32(textBox4.Text)<minValue2)
            {
                MessageBox.Show("İstediginiz fiyatta urun yok , istediğiniz fiyat gelene kadar beklenecek");
            }
            else if(Convert.ToInt32(textBox4.Text)>=minValue2)
            {
                cmd.ExecuteNonQuery();
            }
            
           
            //MessageBox.Show(value.ToString());
            SqlCommand komut = connection.CreateCommand();
            double muhasebe_ucret = (Convert.ToDouble(value) * 1) / 100;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "update UserTable set UserPara-=@puserpara where UserKullanici=@puserkullanici";
            komut.Parameters.AddWithValue("@puserpara", Convert.ToDecimal(value+(value*1)/100));
            komut.Parameters.AddWithValue("@puserkullanici", saticiAdiText.Text);
            komut.ExecuteNonQuery();
            //MessageBox.Show(Convert.ToString((value*1)/100));
            //muhasebe_label.Text = Convert.ToString(Convert.ToDecimal((value * 1) / 100));
            muhasebe_label.Text = muhasebe_ucret.ToString();
            SqlCommand komut3 = connection.CreateCommand();

            komut3.CommandType = CommandType.Text;
            komut3.CommandText = "update UserTable set UserPara+=@puserpara where UserKullanici='muhasebeci'";
            komut3.Parameters.AddWithValue("@puserpara",Convert.ToDecimal( muhasebe_ucret));
            komut3.ExecuteNonQuery();
            SqlCommand komut2 = connection.CreateCommand();

            komut2.CommandType = CommandType.Text;
            komut2.CommandText = "update UserTable  set UserPara+=@puserpara where UserKullanici=@userkullanici";
            komut2.Parameters.AddWithValue("@puserpara", Convert.ToDecimal(value));
            komut2.Parameters.AddWithValue("@userkullanici",textBox3.Text);
            komut2.ExecuteNonQuery();
            connection.Close();            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGetir();
            kategoriDataGetir();
            saticiAdiText.Text = loginVeri;
            raporData.AllowUserToAddRows = true;
            raporData.AllowUserToDeleteRows = true;
            raporData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            /*
            dt2.Columns.Add("Tarih");
            dt2.Columns.Add("Ürün Tipi");
            dt2.Columns.Add("Alım Tutarı");
            dt2.Columns.Add("Miktar");
            raporData.DataSource = dt2;
            */
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

        private void button7_Click(object sender, EventArgs e)
        {
            dt2.Clear();
            SqlVariables.CheckConnection(SqlVariables.connection);
            SqlDataAdapter adtr2 = new SqlDataAdapter("select Tarih, UrunTipi,AlimTutari,Miktar from RaporTable where Tarih between @tarih1 and @tarih2", SqlVariables.connection);
            adtr2.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Value);
            adtr2.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker2.Value);
            //adtr2.Fill(dt2, "RaporTable");
            adtr2.Fill(dt2, "RaporTable");
            raporData.DataSource = dt2.Tables["RaporTable"];

            BaseFont STF_Helvetica_Turkish = BaseFont.CreateFont("Helvetica", "CP1254", BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);
            PdfPTable pdfTable = new PdfPTable(raporData.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in raporData.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontNormal));
                pdfTable.AddCell(cell);
            }
            int row = raporData.Rows.Count;
            int cell2 = raporData.Rows[1].Cells.Count;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < cell2; j++)
                {
                    if (raporData.Rows[i].Cells[j].Value == null)
                    {

                        raporData.Rows[i].Cells[j].Value = "null";
                    }
                    pdfTable.AddCell(raporData.Rows[i].Cells[j].Value.ToString());


                }
            }
            //PDF'e Aktar
            string folderPath = @"C:\rapor\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Rapor.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("PDF Oluşturuldu " + folderPath);

        }
    }
}
