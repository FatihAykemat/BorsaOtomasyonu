
namespace BorsaOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.urunOnay = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.onayLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paraBirimiBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paraEkleBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.urunListele = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kategoriBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saticiAdiText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.urunFiyatBox = new System.Windows.Forms.TextBox();
            this.urunMikBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.raporData = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.muhasebe_label = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunListele)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(-1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1095, 530);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.urunOnay);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.onayLabel);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1087, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(59, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Admin Onaylama Sayfası";
            // 
            // urunOnay
            // 
            this.urunOnay.AutoSize = true;
            this.urunOnay.Location = new System.Drawing.Point(243, 69);
            this.urunOnay.Name = "urunOnay";
            this.urunOnay.Size = new System.Drawing.Size(12, 17);
            this.urunOnay.TabIndex = 7;
            this.urunOnay.Text = ".";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ürün Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // onayLabel
            // 
            this.onayLabel.AutoSize = true;
            this.onayLabel.Location = new System.Drawing.Point(70, 69);
            this.onayLabel.Name = "onayLabel";
            this.onayLabel.Size = new System.Drawing.Size(12, 17);
            this.onayLabel.TabIndex = 5;
            this.onayLabel.Text = ".";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(51, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 47);
            this.button5.TabIndex = 4;
            this.button5.Text = "Para Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.urunListele);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1087, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alıcı";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(348, 459);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "En Düşük Fiyat";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(583, 459);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.muhasebe_label);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(719, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 225);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satın Al";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Almak istediğiniz tutar";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(205, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 22);
            this.textBox4.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 178);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 39);
            this.button6.TabIndex = 4;
            this.button6.Text = "Satın Alım isteğini kaydet";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Almak istediğiniz ürün miktarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ürünler";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(192, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 24);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paraBirimiBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.paraEkleBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(719, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 234);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Ekle";
            // 
            // paraBirimiBox
            // 
            this.paraBirimiBox.FormattingEnabled = true;
            this.paraBirimiBox.Items.AddRange(new object[] {
            "USD",
            "EURO",
            "STERLIN",
            "TL"});
            this.paraBirimiBox.Location = new System.Drawing.Point(205, 70);
            this.paraBirimiBox.Name = "paraBirimiBox";
            this.paraBirimiBox.Size = new System.Drawing.Size(121, 24);
            this.paraBirimiBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kullanıcı Listesi";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(82, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 58);
            this.button4.TabIndex = 6;
            this.button4.Text = "Admin Onayına Gönder";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // paraEkleBox
            // 
            this.paraEkleBox.Location = new System.Drawing.Point(82, 115);
            this.paraEkleBox.Name = "paraEkleBox";
            this.paraEkleBox.Size = new System.Drawing.Size(112, 22);
            this.paraEkleBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Eklemek istediğiniz miktar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(662, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ürün Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // urunListele
            // 
            this.urunListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunListele.Location = new System.Drawing.Point(21, 75);
            this.urunListele.Name = "urunListele";
            this.urunListele.RowHeadersWidth = 51;
            this.urunListele.RowTemplate.Height = 24;
            this.urunListele.Size = new System.Drawing.Size(662, 319);
            this.urunListele.TabIndex = 0;
            this.urunListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunListele_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1087, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Satıcı";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kategoriBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.saticiAdiText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.urunFiyatBox);
            this.groupBox1.Controls.Add(this.urunMikBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 310);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekleme";
            // 
            // kategoriBox
            // 
            this.kategoriBox.FormattingEnabled = true;
            this.kategoriBox.Items.AddRange(new object[] {
            "Buğday",
            "Mısır",
            "Pamuk ",
            "Arpa"});
            this.kategoriBox.Location = new System.Drawing.Point(188, 91);
            this.kategoriBox.Name = "kategoriBox";
            this.kategoriBox.Size = new System.Drawing.Size(130, 24);
            this.kategoriBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Admin Onayına Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saticiAdiText
            // 
            this.saticiAdiText.Location = new System.Drawing.Point(188, 46);
            this.saticiAdiText.Name = "saticiAdiText";
            this.saticiAdiText.Size = new System.Drawing.Size(130, 22);
            this.saticiAdiText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Satıcı Adı";
            // 
            // urunFiyatBox
            // 
            this.urunFiyatBox.Location = new System.Drawing.Point(188, 183);
            this.urunFiyatBox.Name = "urunFiyatBox";
            this.urunFiyatBox.Size = new System.Drawing.Size(130, 22);
            this.urunFiyatBox.TabIndex = 5;
            // 
            // urunMikBox
            // 
            this.urunMikBox.Location = new System.Drawing.Point(188, 140);
            this.urunMikBox.Name = "urunMikBox";
            this.urunMikBox.Size = new System.Drawing.Size(130, 22);
            this.urunMikBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kategorisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Miktarı";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.dateTimePicker2);
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.raporData);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1087, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rapor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(971, 275);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 34);
            this.button7.TabIndex = 1;
            this.button7.Text = "Rapor Al";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // raporData
            // 
            this.raporData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raporData.Location = new System.Drawing.Point(35, 53);
            this.raporData.Name = "raporData";
            this.raporData.RowHeadersWidth = 51;
            this.raporData.RowTemplate.Height = 24;
            this.raporData.Size = new System.Drawing.Size(736, 352);
            this.raporData.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(846, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(846, 225);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(842, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tarih Aralığı Seçme ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(12, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Muhasebe ücreti: ";
            // 
            // muhasebe_label
            // 
            this.muhasebe_label.AutoSize = true;
            this.muhasebe_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.muhasebe_label.Location = new System.Drawing.Point(24, 52);
            this.muhasebe_label.Name = "muhasebe_label";
            this.muhasebe_label.Size = new System.Drawing.Size(13, 20);
            this.muhasebe_label.TabIndex = 8;
            this.muhasebe_label.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 539);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Program İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunListele)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox urunFiyatBox;
        private System.Windows.Forms.TextBox urunMikBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView urunListele;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox saticiAdiText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paraEkleBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label onayLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label urunOnay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox kategoriBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox paraBirimiBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView raporData;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label muhasebe_label;
        private System.Windows.Forms.Label label13;
    }
}

