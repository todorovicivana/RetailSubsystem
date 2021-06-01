
namespace Forme
{
    partial class UnosPredracuna
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
            this.txtDatumIzdavanja = new System.Windows.Forms.TextBox();
            this.txtDatumPrometa = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUgovor = new System.Windows.Forms.ComboBox();
            this.txtPredracunID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProdavac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojPredracuna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStavkePredracuna = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePredracuna)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDatumIzdavanja
            // 
            this.txtDatumIzdavanja.Location = new System.Drawing.Point(169, 124);
            this.txtDatumIzdavanja.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatumIzdavanja.Name = "txtDatumIzdavanja";
            this.txtDatumIzdavanja.Size = new System.Drawing.Size(154, 22);
            this.txtDatumIzdavanja.TabIndex = 86;
            // 
            // txtDatumPrometa
            // 
            this.txtDatumPrometa.Location = new System.Drawing.Point(540, 121);
            this.txtDatumPrometa.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatumPrometa.Name = "txtDatumPrometa";
            this.txtDatumPrometa.Size = new System.Drawing.Size(154, 22);
            this.txtDatumPrometa.TabIndex = 85;
            this.txtDatumPrometa.TextChanged += new System.EventHandler(this.txtDatumPrometa_TextChanged);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(215, 600);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(223, 46);
            this.btnSacuvaj.TabIndex = 84;
            this.btnSacuvaj.Text = "Sačuvaj predračun";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
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
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Prodavac:";
            // 
            // cmbUgovor
            // 
            this.cmbUgovor.DropDownHeight = 65;
            this.cmbUgovor.FormattingEnabled = true;
            this.cmbUgovor.IntegralHeight = false;
            this.cmbUgovor.Location = new System.Drawing.Point(169, 79);
            this.cmbUgovor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUgovor.Name = "cmbUgovor";
            this.cmbUgovor.Size = new System.Drawing.Size(525, 24);
            this.cmbUgovor.TabIndex = 77;
            this.cmbUgovor.SelectedIndexChanged += new System.EventHandler(this.cmbUgovor_SelectedIndexChanged);
            // 
            // txtPredracunID
            // 
            this.txtPredracunID.Location = new System.Drawing.Point(170, 37);
            this.txtPredracunID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPredracunID.Name = "txtPredracunID";
            this.txtPredracunID.ReadOnly = true;
            this.txtPredracunID.Size = new System.Drawing.Size(154, 22);
            this.txtPredracunID.TabIndex = 73;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Datum prometa:";
            // 
            // cmbProdavac
            // 
            this.cmbProdavac.DropDownHeight = 65;
            this.cmbProdavac.FormattingEnabled = true;
            this.cmbProdavac.IntegralHeight = false;
            this.cmbProdavac.Location = new System.Drawing.Point(170, 209);
            this.cmbProdavac.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProdavac.Name = "cmbProdavac";
            this.cmbProdavac.Size = new System.Drawing.Size(525, 24);
            this.cmbProdavac.TabIndex = 81;
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
            // txtBrojPredracuna
            // 
            this.txtBrojPredracuna.Location = new System.Drawing.Point(540, 37);
            this.txtBrojPredracuna.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojPredracuna.Name = "txtBrojPredracuna";
            this.txtBrojPredracuna.Size = new System.Drawing.Size(153, 22);
            this.txtBrojPredracuna.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Broj predračuna:";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.cmbProdavac);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbUgovor);
            this.groupBox1.Controls.Add(this.txtPredracunID);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 299);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o predračunu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbNacinPlacanja
            // 
            this.cmbNacinPlacanja.FormattingEnabled = true;
            this.cmbNacinPlacanja.Location = new System.Drawing.Point(169, 164);
            this.cmbNacinPlacanja.Name = "cmbNacinPlacanja";
            this.cmbNacinPlacanja.Size = new System.Drawing.Size(202, 24);
            this.cmbNacinPlacanja.TabIndex = 89;
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(169, 256);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.ReadOnly = true;
            this.txtKupac.Size = new System.Drawing.Size(525, 22);
            this.txtKupac.TabIndex = 88;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStavkePredracuna);
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 254);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke predračuna";
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
            this.dgvStavkePredracuna.Size = new System.Drawing.Size(556, 208);
            this.dgvStavkePredracuna.TabIndex = 4;
            this.dgvStavkePredracuna.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStavkePredracuna_CellContentClick);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(568, 155);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(137, 34);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(568, 92);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 34);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj stavku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // UnosPredracuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 659);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvaj);
            this.Name = "UnosPredracuna";
            this.Text = "Unos predračuna";
            this.Load += new System.EventHandler(this.UnosPredracuna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePredracuna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatumIzdavanja;
        private System.Windows.Forms.TextBox txtDatumPrometa;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUgovor;
        private System.Windows.Forms.TextBox txtPredracunID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProdavac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrojPredracuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.DataGridView dgvStavkePredracuna;
        private System.Windows.Forms.ComboBox cmbNacinPlacanja;
    }
}