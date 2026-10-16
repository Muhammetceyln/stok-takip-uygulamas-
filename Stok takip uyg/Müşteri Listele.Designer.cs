namespace Stok_takip_uyg
{
    partial class Müşteri_Listele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Müşteri_Listele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.txttcara = new System.Windows.Forms.TextBox();
            this.Tcara = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Cyan;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.ImageIndex = 1;
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(37, 336);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(164, 54);
            this.btnGüncelle.TabIndex = 25;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Sil.png");
            this.ımageList1.Images.SetKeyName(1, "Yenile İkonu2.png");
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(83, 305);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(140, 22);
            this.txtemail.TabIndex = 24;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(83, 242);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(140, 22);
            this.txtadres.TabIndex = 23;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(83, 179);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(140, 22);
            this.txttelefon.TabIndex = 22;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(83, 116);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(140, 22);
            this.txtadsoyad.TabIndex = 21;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(83, 52);
            this.txtTC.Name = "txtTC";
            this.txtTC.ReadOnly = true;
            this.txtTC.Size = new System.Drawing.Size(140, 22);
            this.txtTC.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "E-mail";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adres";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ad Soyad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "TC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Cyan;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageIndex = 0;
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(623, 406);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(88, 61);
            this.btnsil.TabIndex = 26;
            this.btnsil.Text = "Sil";
            this.btnsil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txttcara
            // 
            this.txttcara.Location = new System.Drawing.Point(565, 23);
            this.txttcara.Name = "txttcara";
            this.txttcara.Size = new System.Drawing.Size(172, 22);
            this.txttcara.TabIndex = 27;
            this.txttcara.TextChanged += new System.EventHandler(this.txttcara_TextChanged);
            // 
            // Tcara
            // 
            this.Tcara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tcara.Location = new System.Drawing.Point(456, 22);
            this.Tcara.Name = "Tcara";
            this.Tcara.Size = new System.Drawing.Size(110, 23);
            this.Tcara.TabIndex = 28;
            this.Tcara.Text = "TC Ara";
            this.Tcara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Müşteri_Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1074, 479);
            this.Controls.Add(this.Tcara);
            this.Controls.Add(this.txttcara);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Müşteri_Listele";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.Müşteri_Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txttcara;
        private System.Windows.Forms.Label Tcara;
        private System.Windows.Forms.ImageList ımageList1;
    }
}