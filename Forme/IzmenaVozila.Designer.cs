
namespace Forme
{
    partial class IzmenaVozila
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.dgvDeloviVozila = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbVrstaMenjaca = new System.Windows.Forms.ComboBox();
            this.txtTipVozila = new System.Windows.Forms.TextBox();
            this.txtSnagaMotora = new System.Windows.Forms.TextBox();
            this.txtBrojVrata = new System.Windows.Forms.TextBox();
            this.txtNazivModela = new System.Windows.Forms.TextBox();
            this.txtNazivVozila = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoziloID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeloviVozila)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.AccessibleDescription = "btnObrisi";
            this.btnObrisi.Location = new System.Drawing.Point(467, 209);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(103, 33);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši deo";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(467, 33);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(103, 33);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj deo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIzmeni);
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Controls.Add(this.dgvDeloviVozila);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Location = new System.Drawing.Point(12, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 266);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delovi vozila";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(467, 117);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(103, 33);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Izmeni deo";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // dgvDeloviVozila
            // 
            this.dgvDeloviVozila.AllowUserToAddRows = false;
            this.dgvDeloviVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeloviVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeloviVozila.Location = new System.Drawing.Point(21, 33);
            this.dgvDeloviVozila.Name = "dgvDeloviVozila";
            this.dgvDeloviVozila.RowHeadersWidth = 51;
            this.dgvDeloviVozila.RowTemplate.Height = 24;
            this.dgvDeloviVozila.Size = new System.Drawing.Size(432, 209);
            this.dgvDeloviVozila.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "KW";
            // 
            // cmbVrstaMenjaca
            // 
            this.cmbVrstaMenjaca.FormattingEnabled = true;
            this.cmbVrstaMenjaca.Location = new System.Drawing.Point(170, 235);
            this.cmbVrstaMenjaca.Name = "cmbVrstaMenjaca";
            this.cmbVrstaMenjaca.Size = new System.Drawing.Size(400, 24);
            this.cmbVrstaMenjaca.TabIndex = 13;
            // 
            // txtTipVozila
            // 
            this.txtTipVozila.Location = new System.Drawing.Point(170, 278);
            this.txtTipVozila.Name = "txtTipVozila";
            this.txtTipVozila.Size = new System.Drawing.Size(400, 22);
            this.txtTipVozila.TabIndex = 12;
            // 
            // txtSnagaMotora
            // 
            this.txtSnagaMotora.Location = new System.Drawing.Point(170, 199);
            this.txtSnagaMotora.Name = "txtSnagaMotora";
            this.txtSnagaMotora.Size = new System.Drawing.Size(142, 22);
            this.txtSnagaMotora.TabIndex = 11;
            this.txtSnagaMotora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBrojVrata
            // 
            this.txtBrojVrata.Location = new System.Drawing.Point(170, 161);
            this.txtBrojVrata.Name = "txtBrojVrata";
            this.txtBrojVrata.Size = new System.Drawing.Size(142, 22);
            this.txtBrojVrata.TabIndex = 10;
            // 
            // txtNazivModela
            // 
            this.txtNazivModela.Location = new System.Drawing.Point(170, 123);
            this.txtNazivModela.Name = "txtNazivModela";
            this.txtNazivModela.Size = new System.Drawing.Size(400, 22);
            this.txtNazivModela.TabIndex = 9;
            // 
            // txtNazivVozila
            // 
            this.txtNazivVozila.Location = new System.Drawing.Point(170, 84);
            this.txtNazivVozila.Name = "txtNazivVozila";
            this.txtNazivVozila.Size = new System.Drawing.Size(400, 22);
            this.txtNazivVozila.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tip vozila:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vrsta menjača:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Snaga motora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Broj vrata:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv modela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NazivVozila:";
            // 
            // txtVoziloID
            // 
            this.txtVoziloID.Location = new System.Drawing.Point(170, 40);
            this.txtVoziloID.Name = "txtVoziloID";
            this.txtVoziloID.ReadOnly = true;
            this.txtVoziloID.Size = new System.Drawing.Size(142, 22);
            this.txtVoziloID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbVrstaMenjaca);
            this.groupBox1.Controls.Add(this.txtTipVozila);
            this.groupBox1.Controls.Add(this.txtSnagaMotora);
            this.groupBox1.Controls.Add(this.txtBrojVrata);
            this.groupBox1.Controls.Add(this.txtNazivModela);
            this.groupBox1.Controls.Add(this.txtNazivVozila);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVoziloID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 342);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o vozilu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "VoziloID:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 643);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Izmeni vozilo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "(Putnicko vozilo / Komercijalno vozilo)";
            // 
            // IzmenaVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Name = "IzmenaVozila";
            this.Text = "Izmena vozila";
            this.Load += new System.EventHandler(this.IzmenaVozila_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeloviVozila)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDeloviVozila;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbVrstaMenjaca;
        private System.Windows.Forms.TextBox txtTipVozila;
        private System.Windows.Forms.TextBox txtSnagaMotora;
        private System.Windows.Forms.TextBox txtBrojVrata;
        private System.Windows.Forms.TextBox txtNazivModela;
        private System.Windows.Forms.TextBox txtNazivVozila;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoziloID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label label9;
    }
}