namespace WindowsFormsApp3
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
            this.lblKisiSayı = new System.Windows.Forms.Label();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.btnUcretHesapla = new System.Windows.Forms.Button();
            this.chcIndirim = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKisiSayı
            // 
            this.lblKisiSayı.AutoSize = true;
            this.lblKisiSayı.Location = new System.Drawing.Point(27, 55);
            this.lblKisiSayı.Name = "lblKisiSayı";
            this.lblKisiSayı.Size = new System.Drawing.Size(56, 13);
            this.lblKisiSayı.TabIndex = 0;
            this.lblKisiSayı.Text = "Kişi Sayısı ";
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Location = new System.Drawing.Point(114, 55);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKisiSayisi.TabIndex = 1;
            // 
            // btnUcretHesapla
            // 
            this.btnUcretHesapla.Location = new System.Drawing.Point(127, 167);
            this.btnUcretHesapla.Name = "btnUcretHesapla";
            this.btnUcretHesapla.Size = new System.Drawing.Size(130, 47);
            this.btnUcretHesapla.TabIndex = 2;
            this.btnUcretHesapla.Text = "Ücret Hesapla";
            this.btnUcretHesapla.UseVisualStyleBackColor = true;
            this.btnUcretHesapla.Click += new System.EventHandler(this.btnUcretHesapla_Click);
            // 
            // chcIndirim
            // 
            this.chcIndirim.AutoSize = true;
            this.chcIndirim.Location = new System.Drawing.Point(30, 115);
            this.chcIndirim.Name = "chcIndirim";
            this.chcIndirim.Size = new System.Drawing.Size(111, 17);
            this.chcIndirim.TabIndex = 3;
            this.chcIndirim.Text = "İndirim Kodum Var";
            this.chcIndirim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bilet Fiyatı 1000 TL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chcIndirim);
            this.Controls.Add(this.btnUcretHesapla);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.lblKisiSayı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKisiSayı;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.Button btnUcretHesapla;
        private System.Windows.Forms.CheckBox chcIndirim;
        private System.Windows.Forms.Label label1;
    }
}

