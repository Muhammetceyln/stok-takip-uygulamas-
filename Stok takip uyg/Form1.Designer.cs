namespace Stok_takip_uyg
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtToplamF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatışF = new System.Windows.Forms.TextBox();
            this.txtÜrünMik = new System.Windows.Forms.TextBox();
            this.txtÜrünad = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnsil = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnsat = new System.Windows.Forms.Button();
            this.lblgeneltop = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kategorisil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(972, 484);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Location = new System.Drawing.Point(13, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(54, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(227, 128);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(140, 22);
            this.txtTel.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(227, 81);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(140, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(227, 34);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(140, 22);
            this.txtTC.TabIndex = 0;
            this.txtTC.TextChanged += new System.EventHandler(this.textTC_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtToplamF);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSatışF);
            this.groupBox2.Controls.Add(this.txtÜrünMik);
            this.groupBox2.Controls.Add(this.txtÜrünad);
            this.groupBox2.Controls.Add(this.txtBarkod);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(13, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 270);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // txtToplamF
            // 
            this.txtToplamF.Location = new System.Drawing.Point(227, 211);
            this.txtToplamF.Name = "txtToplamF";
            this.txtToplamF.Size = new System.Drawing.Size(140, 22);
            this.txtToplamF.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.Location = new System.Drawing.Point(54, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Toplam Fiyat";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(54, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Satış Fiyatı";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(54, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ürün Miktarı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(54, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Adı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(54, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barkod";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSatışF
            // 
            this.txtSatışF.Location = new System.Drawing.Point(227, 169);
            this.txtSatışF.Name = "txtSatışF";
            this.txtSatışF.Size = new System.Drawing.Size(140, 22);
            this.txtSatışF.TabIndex = 6;
            this.txtSatışF.TextChanged += new System.EventHandler(this.txtSatışF_TextChanged);
            // 
            // txtÜrünMik
            // 
            this.txtÜrünMik.Location = new System.Drawing.Point(227, 127);
            this.txtÜrünMik.Name = "txtÜrünMik";
            this.txtÜrünMik.Size = new System.Drawing.Size(140, 22);
            this.txtÜrünMik.TabIndex = 5;
            this.txtÜrünMik.Text = "0";
            this.txtÜrünMik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtÜrünMik.TextChanged += new System.EventHandler(this.txtÜrünMik_TextChanged);
            // 
            // txtÜrünad
            // 
            this.txtÜrünad.Location = new System.Drawing.Point(227, 85);
            this.txtÜrünad.Name = "txtÜrünad";
            this.txtÜrünad.Size = new System.Drawing.Size(140, 22);
            this.txtÜrünad.TabIndex = 4;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(227, 43);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(140, 22);
            this.txtBarkod.TabIndex = 3;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Cyan;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnekle.ImageIndex = 13;
            this.btnekle.ImageList = this.ımageList1;
            this.btnekle.Location = new System.Drawing.Point(89, 618);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(163, 71);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ekle";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Müşteri Ekle4.png");
            this.ımageList1.Images.SetKeyName(1, "Müşteri Listele2.png");
            this.ımageList1.Images.SetKeyName(2, "Satışlar.png");
            this.ımageList1.Images.SetKeyName(3, "Sil.png");
            this.ımageList1.Images.SetKeyName(4, "temizle.png");
            this.ımageList1.Images.SetKeyName(5, "Yenile İkonu2.png");
            this.ımageList1.Images.SetKeyName(6, "Sat.png");
            this.ımageList1.Images.SetKeyName(7, "Satışlar2.png");
            this.ımageList1.Images.SetKeyName(8, "Sil.png");
            this.ımageList1.Images.SetKeyName(9, "Ürün ekle.png");
            this.ımageList1.Images.SetKeyName(10, "Ürün Listesi.png");
            this.ımageList1.Images.SetKeyName(11, "Kategori.png");
            this.ımageList1.Images.SetKeyName(12, "Marka.png");
            this.ımageList1.Images.SetKeyName(13, "Ekle.png");
            this.ımageList1.Images.SetKeyName(14, "İptal.png");
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Cyan;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageIndex = 4;
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(1021, 616);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(193, 59);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.Cyan;
            this.btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btniptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniptal.ImageIndex = 14;
            this.btniptal.ImageList = this.ımageList1;
            this.btniptal.Location = new System.Drawing.Point(1021, 680);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(193, 66);
            this.btniptal.TabIndex = 5;
            this.btniptal.Text = "İptal";
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnsat
            // 
            this.btnsat.BackColor = System.Drawing.Color.Cyan;
            this.btnsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsat.ImageIndex = 6;
            this.btnsat.ImageList = this.ımageList1;
            this.btnsat.Location = new System.Drawing.Point(710, 618);
            this.btnsat.Name = "btnsat";
            this.btnsat.Size = new System.Drawing.Size(193, 59);
            this.btnsat.TabIndex = 6;
            this.btnsat.Text = "Satış Yap";
            this.btnsat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsat.UseVisualStyleBackColor = false;
            this.btnsat.Click += new System.EventHandler(this.btnsat_Click);
            // 
            // lblgeneltop
            // 
            this.lblgeneltop.BackColor = System.Drawing.Color.Transparent;
            this.lblgeneltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgeneltop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgeneltop.Location = new System.Drawing.Point(370, 647);
            this.lblgeneltop.Name = "lblgeneltop";
            this.lblgeneltop.Size = new System.Drawing.Size(134, 28);
            this.lblgeneltop.TabIndex = 7;
            this.lblgeneltop.Text = "Genel Toplam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(674, 638);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(549, 639);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 38);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 122);
            this.panel2.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Cyan;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.ImageIndex = 7;
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(1186, 37);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(216, 62);
            this.button9.TabIndex = 9;
            this.button9.Text = "Satışları Listeleme";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Cyan;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.ImageIndex = 10;
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(903, 37);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(216, 62);
            this.button8.TabIndex = 8;
            this.button8.Text = "Ürün Listeleme";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Cyan;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageIndex = 9;
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(667, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(216, 62);
            this.button7.TabIndex = 7;
            this.button7.Text = "Ürün Ekleme";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 1;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(412, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 62);
            this.button6.TabIndex = 6;
            this.button6.Text = "Müşteri Listeleme";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Cyan;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 0;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(205, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 62);
            this.button5.TabIndex = 5;
            this.button5.Text = "Müşteri Ekle";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 12;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(1390, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 70);
            this.button2.TabIndex = 11;
            this.button2.Text = "Marka";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 11;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(1390, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Kategori";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kategorisil
            // 
            this.kategorisil.BackColor = System.Drawing.Color.Cyan;
            this.kategorisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.kategorisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kategorisil.ImageIndex = 8;
            this.kategorisil.ImageList = this.ımageList1;
            this.kategorisil.Location = new System.Drawing.Point(1390, 367);
            this.kategorisil.Name = "kategorisil";
            this.kategorisil.Size = new System.Drawing.Size(194, 82);
            this.kategorisil.TabIndex = 12;
            this.kategorisil.Text = "Kategori /Marka Sil";
            this.kategorisil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kategorisil.UseVisualStyleBackColor = false;
            this.kategorisil.Click += new System.EventHandler(this.kategorisil_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::Stok_takip_uyg.Properties.Resources.depo_Arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 745);
            this.Controls.Add(this.kategorisil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblgeneltop);
            this.Controls.Add(this.btnsat);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takibi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSatışF;
        private System.Windows.Forms.TextBox txtÜrünMik;
        private System.Windows.Forms.TextBox txtÜrünad;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamF;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnsat;
        private System.Windows.Forms.Label lblgeneltop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kategorisil;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

