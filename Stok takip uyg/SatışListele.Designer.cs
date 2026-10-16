namespace Stok_takip_uyg
{
    partial class SatışListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatışListele));
            this.ekran = new System.Windows.Forms.DataGridView();
            this.Sil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).BeginInit();
            this.SuspendLayout();
            // 
            // ekran
            // 
            this.ekran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ekran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ekran.Location = new System.Drawing.Point(12, -1);
            this.ekran.Name = "ekran";
            this.ekran.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ekran.RowTemplate.Height = 24;
            this.ekran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ekran.Size = new System.Drawing.Size(1418, 651);
            this.ekran.TabIndex = 0;
            // 
            // Sil
            // 
            this.Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Sil.ImageIndex = 0;
            this.Sil.ImageList = this.ımageList1;
            this.Sil.Location = new System.Drawing.Point(1436, 225);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(88, 95);
            this.Sil.TabIndex = 1;
            this.Sil.Text = "Sil";
            this.Sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Sil.png");
            // 
            // SatışListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1826, 608);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.ekran);
            this.Name = "SatışListele";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listelesi";
            this.Load += new System.EventHandler(this.SatışListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ekran;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.ImageList ımageList1;
    }
}