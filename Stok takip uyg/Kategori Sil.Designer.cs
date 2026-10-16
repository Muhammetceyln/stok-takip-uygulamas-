namespace Stok_takip_uyg
{
    partial class Kategori_Sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kategori_Sil));
            this.label1 = new System.Windows.Forms.Label();
            this.combokategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combomarka = new System.Windows.Forms.ComboBox();
            this.kategorisil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.markasil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combokategori
            // 
            this.combokategori.FormattingEnabled = true;
            this.combokategori.Location = new System.Drawing.Point(129, 51);
            this.combokategori.Name = "combokategori";
            this.combokategori.Size = new System.Drawing.Size(154, 24);
            this.combokategori.TabIndex = 1;
            this.combokategori.SelectedIndexChanged += new System.EventHandler(this.combokategori_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(308, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combomarka
            // 
            this.combomarka.FormattingEnabled = true;
            this.combomarka.Location = new System.Drawing.Point(388, 51);
            this.combomarka.Name = "combomarka";
            this.combomarka.Size = new System.Drawing.Size(191, 24);
            this.combomarka.TabIndex = 3;
            // 
            // kategorisil
            // 
            this.kategorisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategorisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kategorisil.ImageIndex = 0;
            this.kategorisil.ImageList = this.ımageList1;
            this.kategorisil.Location = new System.Drawing.Point(86, 101);
            this.kategorisil.Name = "kategorisil";
            this.kategorisil.Size = new System.Drawing.Size(157, 52);
            this.kategorisil.TabIndex = 4;
            this.kategorisil.Text = "Kategoriyi Sil";
            this.kategorisil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kategorisil.UseVisualStyleBackColor = true;
            this.kategorisil.Click += new System.EventHandler(this.kategorisil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Sil.png");
            // 
            // markasil
            // 
            this.markasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markasil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.markasil.ImageIndex = 0;
            this.markasil.ImageList = this.ımageList1;
            this.markasil.Location = new System.Drawing.Point(410, 101);
            this.markasil.Name = "markasil";
            this.markasil.Size = new System.Drawing.Size(157, 52);
            this.markasil.TabIndex = 5;
            this.markasil.Text = "Markayı Sil";
            this.markasil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.markasil.UseVisualStyleBackColor = true;
            this.markasil.Click += new System.EventHandler(this.markasil_Click);
            // 
            // Kategori_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 172);
            this.Controls.Add(this.markasil);
            this.Controls.Add(this.kategorisil);
            this.Controls.Add(this.combomarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combokategori);
            this.Controls.Add(this.label1);
            this.Name = "Kategori_Sil";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori/Marka Sil";
            this.Load += new System.EventHandler(this.Kategori_Sil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combokategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combomarka;
        private System.Windows.Forms.Button kategorisil;
        private System.Windows.Forms.Button markasil;
        private System.Windows.Forms.ImageList ımageList1;
    }
}