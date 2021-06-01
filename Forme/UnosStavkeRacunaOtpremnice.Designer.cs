
namespace Forme
{
    partial class UnosStavkeRacunaOtpremnice
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.gbVozilo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.btnIzaberiVozilo = new System.Windows.Forms.Button();
            this.dgvVozilo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVoziloID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRacunOtpremnicaIDStavka = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbVozilo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(200, 653);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(386, 34);
            this.btnDodaj.TabIndex = 90;
            this.btnDodaj.Text = "Potvrdi unos";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // gbVozilo
            // 
            this.gbVozilo.Controls.Add(this.groupBox1);
            this.gbVozilo.Controls.Add(this.btnIzaberiVozilo);
            this.gbVozilo.Controls.Add(this.dgvVozilo);
            this.gbVozilo.Controls.Add(this.label4);
            this.gbVozilo.Controls.Add(this.txtVoziloID);
            this.gbVozilo.Location = new System.Drawing.Point(24, 67);
            this.gbVozilo.Margin = new System.Windows.Forms.Padding(4);
            this.gbVozilo.Name = "gbVozilo";
            this.gbVozilo.Padding = new System.Windows.Forms.Padding(4);
            this.gbVozilo.Size = new System.Drawing.Size(728, 579);
            this.gbVozilo.TabIndex = 87;
            this.gbVozilo.TabStop = false;
            this.gbVozilo.Text = "Vozilo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOprema);
            this.groupBox1.Location = new System.Drawing.Point(37, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 257);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oprema uz vozilo";
            // 
            // dgvOprema
            // 
            this.dgvOprema.AllowUserToAddRows = false;
            this.dgvOprema.AllowUserToDeleteRows = false;
            this.dgvOprema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.Location = new System.Drawing.Point(29, 35);
            this.dgvOprema.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.ReadOnly = true;
            this.dgvOprema.RowHeadersWidth = 51;
            this.dgvOprema.Size = new System.Drawing.Size(599, 205);
            this.dgvOprema.TabIndex = 84;
            // 
            // btnIzaberiVozilo
            // 
            this.btnIzaberiVozilo.Location = new System.Drawing.Point(583, 250);
            this.btnIzaberiVozilo.Name = "btnIzaberiVozilo";
            this.btnIzaberiVozilo.Size = new System.Drawing.Size(137, 34);
            this.btnIzaberiVozilo.TabIndex = 82;
            this.btnIzaberiVozilo.Text = "Izaberi vozilo";
            this.btnIzaberiVozilo.UseVisualStyleBackColor = true;
            this.btnIzaberiVozilo.Click += new System.EventHandler(this.btnIzaberiVozilo_Click);
            // 
            // dgvVozilo
            // 
            this.dgvVozilo.AllowUserToAddRows = false;
            this.dgvVozilo.AllowUserToDeleteRows = false;
            this.dgvVozilo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVozilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozilo.Location = new System.Drawing.Point(9, 23);
            this.dgvVozilo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVozilo.Name = "dgvVozilo";
            this.dgvVozilo.ReadOnly = true;
            this.dgvVozilo.RowHeadersWidth = 51;
            this.dgvVozilo.Size = new System.Drawing.Size(711, 206);
            this.dgvVozilo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "VoziloID:";
            // 
            // txtVoziloID
            // 
            this.txtVoziloID.Location = new System.Drawing.Point(93, 256);
            this.txtVoziloID.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoziloID.Name = "txtVoziloID";
            this.txtVoziloID.ReadOnly = true;
            this.txtVoziloID.Size = new System.Drawing.Size(304, 22);
            this.txtVoziloID.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "RačunOtpremnicaID:";
            // 
            // txtRacunOtpremnicaIDStavka
            // 
            this.txtRacunOtpremnicaIDStavka.Location = new System.Drawing.Point(200, 16);
            this.txtRacunOtpremnicaIDStavka.Margin = new System.Windows.Forms.Padding(4);
            this.txtRacunOtpremnicaIDStavka.Name = "txtRacunOtpremnicaIDStavka";
            this.txtRacunOtpremnicaIDStavka.ReadOnly = true;
            this.txtRacunOtpremnicaIDStavka.Size = new System.Drawing.Size(154, 22);
            this.txtRacunOtpremnicaIDStavka.TabIndex = 86;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(590, 17);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(154, 22);
            this.txtKolicina.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Količina:";
            // 
            // UnosStavkeRacunaOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 701);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.gbVozilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRacunOtpremnicaIDStavka);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label3);
            this.Name = "UnosStavkeRacunaOtpremnice";
            this.Text = "Unos stavke računa-otpremnice";
            this.Load += new System.EventHandler(this.UnosStavkeRacunaOtpremnice_Load);
            this.gbVozilo.ResumeLayout(false);
            this.gbVozilo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox gbVozilo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Button btnIzaberiVozilo;
        private System.Windows.Forms.DataGridView dgvVozilo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVoziloID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRacunOtpremnicaIDStavka;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label3;
    }
}