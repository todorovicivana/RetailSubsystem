
namespace Forme
{
    partial class IzmenaPonude
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
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtRokIsporuke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatumOd = new System.Windows.Forms.TextBox();
            this.txtDatumDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojPonude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStavkePonude = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbKatalog = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProdavac = new System.Windows.Forms.ComboBox();
            this.txtPonudaID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePonude)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKupac
            // 
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.Location = new System.Drawing.Point(173, 253);
            this.cmbKupac.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(525, 24);
            this.cmbKupac.TabIndex = 90;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(226, 589);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(223, 46);
            this.btnSacuvaj.TabIndex = 92;
            this.btnSacuvaj.Text = "Izmeni ponudu";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtRokIsporuke
            // 
            this.txtRokIsporuke.Location = new System.Drawing.Point(173, 123);
            this.txtRokIsporuke.Margin = new System.Windows.Forms.Padding(4);
            this.txtRokIsporuke.Name = "txtRokIsporuke";
            this.txtRokIsporuke.Size = new System.Drawing.Size(154, 22);
            this.txtRokIsporuke.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "PonudaID:";
            // 
            // txtDatumOd
            // 
            this.txtDatumOd.Location = new System.Drawing.Point(173, 83);
            this.txtDatumOd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatumOd.Name = "txtDatumOd";
            this.txtDatumOd.Size = new System.Drawing.Size(154, 22);
            this.txtDatumOd.TabIndex = 86;
            // 
            // txtDatumDo
            // 
            this.txtDatumDo.Location = new System.Drawing.Point(540, 80);
            this.txtDatumDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatumDo.Name = "txtDatumDo";
            this.txtDatumDo.Size = new System.Drawing.Size(154, 22);
            this.txtDatumDo.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Datum do:";
            // 
            // txtBrojPonude
            // 
            this.txtBrojPonude.Location = new System.Drawing.Point(540, 37);
            this.txtBrojPonude.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojPonude.Name = "txtBrojPonude";
            this.txtBrojPonude.Size = new System.Drawing.Size(153, 22);
            this.txtBrojPonude.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Broj ponude:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 80;
            this.label6.Text = "Na osnovu kataloga:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dgvStavkePonude);
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Location = new System.Drawing.Point(23, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 254);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke ponude";
            // 
            // dgvStavkePonude
            // 
            this.dgvStavkePonude.AllowUserToAddRows = false;
            this.dgvStavkePonude.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkePonude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePonude.Location = new System.Drawing.Point(6, 31);
            this.dgvStavkePonude.Name = "dgvStavkePonude";
            this.dgvStavkePonude.RowHeadersWidth = 51;
            this.dgvStavkePonude.RowTemplate.Height = 24;
            this.dgvStavkePonude.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStavkePonude.Size = new System.Drawing.Size(556, 208);
            this.dgvStavkePonude.TabIndex = 4;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(574, 196);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(137, 34);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(574, 31);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 34);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj stavku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Datum od:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 126);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 82;
            this.label11.Text = "Rok isporuke:";
            // 
            // cmbKatalog
            // 
            this.cmbKatalog.DropDownHeight = 65;
            this.cmbKatalog.FormattingEnabled = true;
            this.cmbKatalog.IntegralHeight = false;
            this.cmbKatalog.Location = new System.Drawing.Point(173, 166);
            this.cmbKatalog.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKatalog.Name = "cmbKatalog";
            this.cmbKatalog.Size = new System.Drawing.Size(525, 24);
            this.cmbKatalog.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Prodavac:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Kupac:";
            // 
            // cmbProdavac
            // 
            this.cmbProdavac.DropDownHeight = 65;
            this.cmbProdavac.FormattingEnabled = true;
            this.cmbProdavac.IntegralHeight = false;
            this.cmbProdavac.Location = new System.Drawing.Point(173, 209);
            this.cmbProdavac.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProdavac.Name = "cmbProdavac";
            this.cmbProdavac.Size = new System.Drawing.Size(525, 24);
            this.cmbProdavac.TabIndex = 77;
            // 
            // txtPonudaID
            // 
            this.txtPonudaID.Location = new System.Drawing.Point(173, 37);
            this.txtPonudaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPonudaID.Name = "txtPonudaID";
            this.txtPonudaID.ReadOnly = true;
            this.txtPonudaID.Size = new System.Drawing.Size(154, 22);
            this.txtPonudaID.TabIndex = 73;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRokIsporuke);
            this.groupBox1.Controls.Add(this.cmbKupac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDatumOd);
            this.groupBox1.Controls.Add(this.txtDatumDo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBrojPonude);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbKatalog);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbProdavac);
            this.groupBox1.Controls.Add(this.txtPonudaID);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 299);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o ponudi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Izmeni stavku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IzmenaPonude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 643);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IzmenaPonude";
            this.Text = "Izmena ponude";
            this.Load += new System.EventHandler(this.IzmenaPonude_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePonude)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKupac;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtRokIsporuke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatumOd;
        private System.Windows.Forms.TextBox txtDatumDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrojPonude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStavkePonude;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbKatalog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProdavac;
        private System.Windows.Forms.TextBox txtPonudaID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}