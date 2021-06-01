
namespace Forme
{
    partial class IzmenaPredracuna
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
            this.btnIzmeniRO = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.dgvStavkePredracuna = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatumIzdavanja = new System.Windows.Forms.TextBox();
            this.txtDatumPrometa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBrojPredracuna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUgovor = new System.Windows.Forms.ComboBox();
            this.txtPredracunID = new System.Windows.Forms.TextBox();
            this.cmbProdavac = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePredracuna)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzmeniRO
            // 
            this.btnIzmeniRO.Location = new System.Drawing.Point(202, 606);
            this.btnIzmeniRO.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniRO.Name = "btnIzmeniRO";
            this.btnIzmeniRO.Size = new System.Drawing.Size(223, 46);
            this.btnIzmeniRO.TabIndex = 100;
            this.btnIzmeniRO.Text = "Izmeni predračun";
            this.btnIzmeniRO.UseVisualStyleBackColor = true;
            this.btnIzmeniRO.Click += new System.EventHandler(this.btnIzmeniRO_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIzmeni);
            this.groupBox2.Controls.Add(this.dgvStavkePredracuna);
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Location = new System.Drawing.Point(12, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 254);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke predračuna";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(579, 115);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(137, 34);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni stavku";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // dgvStavkePredracuna
            // 
            this.dgvStavkePredracuna.AllowUserToAddRows = false;
            this.dgvStavkePredracuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkePredracuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePredracuna.Location = new System.Drawing.Point(6, 31);
            this.dgvStavkePredracuna.Name = "dgvStavkePredracuna";
            this.dgvStavkePredracuna.RowHeadersWidth = 51;
            this.dgvStavkePredracuna.RowTemplate.Height = 24;
            this.dgvStavkePredracuna.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStavkePredracuna.Size = new System.Drawing.Size(556, 209);
            this.dgvStavkePredracuna.TabIndex = 4;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(579, 206);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(137, 34);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(579, 31);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 34);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj stavku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbNacinPlacanja
            // 
            this.cmbNacinPlacanja.FormattingEnabled = true;
            this.cmbNacinPlacanja.Location = new System.Drawing.Point(190, 167);
            this.cmbNacinPlacanja.Name = "cmbNacinPlacanja";
            this.cmbNacinPlacanja.Size = new System.Drawing.Size(204, 24);
            this.cmbNacinPlacanja.TabIndex = 89;
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(190, 251);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.ReadOnly = true;
            this.txtKupac.Size = new System.Drawing.Size(525, 22);
            this.txtKupac.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "PredračunID:";
            // 
            // txtDatumIzdavanja
            // 
            this.txtDatumIzdavanja.Location = new System.Drawing.Point(190, 124);
            this.txtDatumIzdavanja.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatumIzdavanja.Name = "txtDatumIzdavanja";
            this.txtDatumIzdavanja.Size = new System.Drawing.Size(154, 22);
            this.txtDatumIzdavanja.TabIndex = 86;
            // 
            // txtDatumPrometa
            // 
            this.txtDatumPrometa.Location = new System.Drawing.Point(562, 124);
            this.txtDatumPrometa.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatumPrometa.Name = "txtDatumPrometa";
            this.txtDatumPrometa.Size = new System.Drawing.Size(154, 22);
            this.txtDatumPrometa.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Datum prometa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUkupanIznos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbProdavac);
            this.groupBox1.Controls.Add(this.cmbNacinPlacanja);
            this.groupBox1.Controls.Add(this.txtKupac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDatumIzdavanja);
            this.groupBox1.Controls.Add(this.txtDatumPrometa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBrojPredracuna);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbUgovor);
            this.groupBox1.Controls.Add(this.txtPredracunID);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 299);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o predračunu";
            // 
            // txtBrojPredracuna
            // 
            this.txtBrojPredracuna.Location = new System.Drawing.Point(561, 37);
            this.txtBrojPredracuna.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojPredracuna.Name = "txtBrojPredracuna";
            this.txtBrojPredracuna.Size = new System.Drawing.Size(153, 22);
            this.txtBrojPredracuna.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Broj predračuna:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 80;
            this.label6.Text = "Na osnovu ugovora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Datum izdavanja:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 82;
            this.label11.Text = "Način plaćanja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "ProdavacID:";
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
            // cmbUgovor
            // 
            this.cmbUgovor.FormattingEnabled = true;
            this.cmbUgovor.Location = new System.Drawing.Point(190, 82);
            this.cmbUgovor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUgovor.Name = "cmbUgovor";
            this.cmbUgovor.Size = new System.Drawing.Size(525, 24);
            this.cmbUgovor.TabIndex = 77;
            this.cmbUgovor.SelectedIndexChanged += new System.EventHandler(this.cmbPredracun_SelectedIndexChanged);
            // 
            // txtPredracunID
            // 
            this.txtPredracunID.Location = new System.Drawing.Point(190, 37);
            this.txtPredracunID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPredracunID.Name = "txtPredracunID";
            this.txtPredracunID.ReadOnly = true;
            this.txtPredracunID.Size = new System.Drawing.Size(154, 22);
            this.txtPredracunID.TabIndex = 73;
            // 
            // cmbProdavac
            // 
            this.cmbProdavac.FormattingEnabled = true;
            this.cmbProdavac.Location = new System.Drawing.Point(190, 209);
            this.cmbProdavac.Name = "cmbProdavac";
            this.cmbProdavac.Size = new System.Drawing.Size(525, 24);
            this.cmbProdavac.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 91;
            this.label8.Text = "Ukupan iznos:";
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Location = new System.Drawing.Point(561, 167);
            this.txtUkupanIznos.Margin = new System.Windows.Forms.Padding(4);
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.Size = new System.Drawing.Size(154, 22);
            this.txtUkupanIznos.TabIndex = 92;
            // 
            // IzmenaPredracuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 671);
            this.Controls.Add(this.btnIzmeniRO);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IzmenaPredracuna";
            this.Text = "Izmena predračuna";
            this.Load += new System.EventHandler(this.IzmenaPredracuna_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePredracuna)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeniRO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.DataGridView dgvStavkePredracuna;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbNacinPlacanja;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatumIzdavanja;
        private System.Windows.Forms.TextBox txtDatumPrometa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBrojPredracuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUgovor;
        private System.Windows.Forms.TextBox txtPredracunID;
        private System.Windows.Forms.TextBox txtUkupanIznos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProdavac;
    }
}