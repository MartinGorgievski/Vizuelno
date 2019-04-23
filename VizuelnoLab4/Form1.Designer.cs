namespace VizuelnoLab4
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
            this.lstProdukti = new System.Windows.Forms.ListBox();
            this.lstKosnicka = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddKosnicka = new System.Windows.Forms.Button();
            this.btnDelKosnicka = new System.Windows.Forms.Button();
            this.btnAddProdukt = new System.Windows.Forms.Button();
            this.btnDelProdukt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVkupno = new System.Windows.Forms.TextBox();
            this.btnIsprazniProdukt = new System.Windows.Forms.Button();
            this.btnIsprazniKosnicka = new System.Windows.Forms.Button();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProdukti
            // 
            this.lstProdukti.FormattingEnabled = true;
            this.lstProdukti.Location = new System.Drawing.Point(12, 27);
            this.lstProdukti.Name = "lstProdukti";
            this.lstProdukti.Size = new System.Drawing.Size(256, 329);
            this.lstProdukti.TabIndex = 0;
            this.lstProdukti.SelectedIndexChanged += new System.EventHandler(this.lstProdukti_SelectedIndexChanged);
            // 
            // lstKosnicka
            // 
            this.lstKosnicka.FormattingEnabled = true;
            this.lstKosnicka.Location = new System.Drawing.Point(532, 27);
            this.lstKosnicka.Name = "lstKosnicka";
            this.lstKosnicka.Size = new System.Drawing.Size(256, 277);
            this.lstKosnicka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Листа на продукти:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кошничка:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numKolicina);
            this.groupBox1.Controls.Add(this.btnDelProdukt);
            this.groupBox1.Controls.Add(this.btnAddProdukt);
            this.groupBox1.Controls.Add(this.btnDelKosnicka);
            this.groupBox1.Controls.Add(this.btnAddKosnicka);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtCat);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(275, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 322);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Име";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(10, 37);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(235, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(10, 76);
            this.txtCat.Name = "txtCat";
            this.txtCat.ReadOnly = true;
            this.txtCat.Size = new System.Drawing.Size(235, 20);
            this.txtCat.TabIndex = 2;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(10, 115);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCena.Size = new System.Drawing.Size(108, 20);
            this.txtCena.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Категорија:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена:";
            // 
            // btnAddKosnicka
            // 
            this.btnAddKosnicka.Location = new System.Drawing.Point(7, 162);
            this.btnAddKosnicka.Name = "btnAddKosnicka";
            this.btnAddKosnicka.Size = new System.Drawing.Size(140, 23);
            this.btnAddKosnicka.TabIndex = 6;
            this.btnAddKosnicka.Text = "Додади во кошничка >>";
            this.btnAddKosnicka.UseVisualStyleBackColor = true;
            this.btnAddKosnicka.Click += new System.EventHandler(this.btnAddKosnicka_Click);
            // 
            // btnDelKosnicka
            // 
            this.btnDelKosnicka.Location = new System.Drawing.Point(7, 208);
            this.btnDelKosnicka.Name = "btnDelKosnicka";
            this.btnDelKosnicka.Size = new System.Drawing.Size(238, 23);
            this.btnDelKosnicka.TabIndex = 7;
            this.btnDelKosnicka.Text = "Избриши од кошничка";
            this.btnDelKosnicka.UseVisualStyleBackColor = true;
            this.btnDelKosnicka.Click += new System.EventHandler(this.btnDelKosnicka_Click);
            // 
            // btnAddProdukt
            // 
            this.btnAddProdukt.Location = new System.Drawing.Point(7, 254);
            this.btnAddProdukt.Name = "btnAddProdukt";
            this.btnAddProdukt.Size = new System.Drawing.Size(238, 23);
            this.btnAddProdukt.TabIndex = 8;
            this.btnAddProdukt.Text = "Додади нов продукт";
            this.btnAddProdukt.UseVisualStyleBackColor = true;
            this.btnAddProdukt.Click += new System.EventHandler(this.btnAddProdukt_Click);
            // 
            // btnDelProdukt
            // 
            this.btnDelProdukt.Location = new System.Drawing.Point(7, 293);
            this.btnDelProdukt.Name = "btnDelProdukt";
            this.btnDelProdukt.Size = new System.Drawing.Size(238, 23);
            this.btnDelProdukt.TabIndex = 9;
            this.btnDelProdukt.Text = "Избриши продукт";
            this.btnDelProdukt.UseVisualStyleBackColor = true;
            this.btnDelProdukt.Click += new System.EventHandler(this.btnDelProdukt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Вкупно:";
            // 
            // txtVkupno
            // 
            this.txtVkupno.Location = new System.Drawing.Point(578, 317);
            this.txtVkupno.Name = "txtVkupno";
            this.txtVkupno.ReadOnly = true;
            this.txtVkupno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVkupno.Size = new System.Drawing.Size(210, 20);
            this.txtVkupno.TabIndex = 10;
            // 
            // btnIsprazniProdukt
            // 
            this.btnIsprazniProdukt.Location = new System.Drawing.Point(12, 373);
            this.btnIsprazniProdukt.Name = "btnIsprazniProdukt";
            this.btnIsprazniProdukt.Size = new System.Drawing.Size(256, 23);
            this.btnIsprazniProdukt.TabIndex = 10;
            this.btnIsprazniProdukt.Text = "Испразни ја листата на продукти?";
            this.btnIsprazniProdukt.UseVisualStyleBackColor = true;
            this.btnIsprazniProdukt.Click += new System.EventHandler(this.btnIsprazniProdukt_Click);
            // 
            // btnIsprazniKosnicka
            // 
            this.btnIsprazniKosnicka.Location = new System.Drawing.Point(535, 373);
            this.btnIsprazniKosnicka.Name = "btnIsprazniKosnicka";
            this.btnIsprazniKosnicka.Size = new System.Drawing.Size(256, 23);
            this.btnIsprazniKosnicka.TabIndex = 11;
            this.btnIsprazniKosnicka.Text = "Испразни ја кошничката?";
            this.btnIsprazniKosnicka.UseVisualStyleBackColor = true;
            this.btnIsprazniKosnicka.Click += new System.EventHandler(this.btnIsprazniKosnicka_Click);
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(153, 164);
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(92, 20);
            this.numKolicina.TabIndex = 10;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.btnIsprazniKosnicka);
            this.Controls.Add(this.btnIsprazniProdukt);
            this.Controls.Add(this.txtVkupno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKosnicka);
            this.Controls.Add(this.lstProdukti);
            this.Name = "Form1";
            this.Text = "Потрошувачка кошничка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProdukti;
        private System.Windows.Forms.ListBox lstKosnicka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelProdukt;
        private System.Windows.Forms.Button btnAddProdukt;
        private System.Windows.Forms.Button btnDelKosnicka;
        private System.Windows.Forms.Button btnAddKosnicka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVkupno;
        private System.Windows.Forms.Button btnIsprazniProdukt;
        private System.Windows.Forms.Button btnIsprazniKosnicka;
        private System.Windows.Forms.NumericUpDown numKolicina;
    }
}

