
namespace Forme
{
    partial class UnosRacunOtpremnice
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
            this.dgvStavkeRacunaOtpremnice = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cmbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProdavacID = new System.Windows.Forms.TextBox();
            this.txtDatumIzdavanja = new System.Windows.Forms.TextBox();
            this.txtDatumPrometa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojRacunaOtpremnice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPredracun = new System.Windows.Forms.ComboBox();
            this.txtRacunOtpremnicaID = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacunaOtpremnice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStavkeRacunaOtpremnice
            // 
            this.dgvStavkeRacunaOtpremnice.AllowUserToAddRows = false;
            this.dgvStavkeRacunaOtpremnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeRacunaOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacunaOtpremnice.Location = new System.Drawing.Point(6, 31);
            this.dgvStavkeRacunaOtpremnice.Name = "dgvStavkeRacunaOtpremnice";
            this.dgvStavkeRacunaOtpremnice.RowHeadersWidth = 51;
            this.dgvStavkeRacunaOtpremnice.RowTemplate.Height = 24;
            this.dgvStavkeRacunaOtpremnice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStavkeRacunaOtpremnice.Size = new System.Drawing.Size(556, 209);
            this.dgvStavkeRacunaOtpremnice.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(579, 66);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 34);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj stavku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStavkeRacunaOtpremnice);
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 254);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke računa-otpremnice";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(579, 152);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(137, 34);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // cmbNacinPlacanja
            // 
            this.cmbNacinPlacanja.FormattingEnabled = true;
            this.cmbNacinPlacanja.Location = new System.Drawing.Point(190, 167);
            this.cmbNacinPlacanja.Name = "cmbNacinPlacanja";
            this.cmbNacinPlacanja.Size = new System.Drawing.Size(256, 24);
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
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "RačunOtpremnicaID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProdavacID);
            this.groupBox1.Controls.Add(this.cmbNacinPlacanja);
            this.groupBox1.Controls.Add(this.txtKupac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDatumIzdavanja);
            this.groupBox1.Controls.Add(this.txtDatumPrometa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBrojRacunaOtpremnice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbPredracun);
            this.groupBox1.Controls.Add(this.txtRacunOtpremnicaID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 299);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o računu-otpremnici";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtProdavacID
            // 
            this.txtProdavacID.Location = new System.Drawing.Point(190, 208);
            this.txtProdavacID.Name = "txtProdavacID";
            this.txtProdavacID.Size = new System.Drawing.Size(70, 22);
            this.txtProdavacID.TabIndex = 92;
            this.txtProdavacID.TextChanged += new System.EventHandler(this.txtProdavacID_TextChanged);
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
            // txtBrojRacunaOtpremnice
            // 
            this.txtBrojRacunaOtpremnice.Location = new System.Drawing.Point(562, 35);
            this.txtBrojRacunaOtpremnice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojRacunaOtpremnice.Name = "txtBrojRacunaOtpremnice";
            this.txtBrojRacunaOtpremnice.Size = new System.Drawing.Size(153, 22);
            this.txtBrojRacunaOtpremnice.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Broj računa-otpremnice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 80;
            this.label6.Text = "Na osnovu predračuna:";
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
            // cmbPredracun
            // 
            this.cmbPredracun.DropDownHeight = 65;
            this.cmbPredracun.FormattingEnabled = true;
            this.cmbPredracun.IntegralHeight = false;
            this.cmbPredracun.Location = new System.Drawing.Point(190, 82);
            this.cmbPredracun.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPredracun.Name = "cmbPredracun";
            this.cmbPredracun.Size = new System.Drawing.Size(525, 24);
            this.cmbPredracun.TabIndex = 77;
            this.cmbPredracun.SelectedIndexChanged += new System.EventHandler(this.cmbPredracun_SelectedIndexChanged);
            // 
            // txtRacunOtpremnicaID
            // 
            this.txtRacunOtpremnicaID.Location = new System.Drawing.Point(190, 37);
            this.txtRacunOtpremnicaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRacunOtpremnicaID.Name = "txtRacunOtpremnicaID";
            this.txtRacunOtpremnicaID.ReadOnly = true;
            this.txtRacunOtpremnicaID.Size = new System.Drawing.Size(154, 22);
            this.txtRacunOtpremnicaID.TabIndex = 73;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(216, 589);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(223, 46);
            this.btnSacuvaj.TabIndex = 89;
            this.btnSacuvaj.Text = "Sačuvaj račun-otpremnicu";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // UnosRacunOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvaj);
            this.Name = "UnosRacunOtpremnice";
            this.Text = "Unos račun-otpremnice";
            this.Load += new System.EventHandler(this.UnosRacunOtpremnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacunaOtpremnice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStavkeRacunaOtpremnice;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ComboBox cmbNacinPlacanja;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDatumIzdavanja;
        private System.Windows.Forms.TextBox txtDatumPrometa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrojRacunaOtpremnice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPredracun;
        private System.Windows.Forms.TextBox txtRacunOtpremnicaID;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtProdavacID;
    }
}