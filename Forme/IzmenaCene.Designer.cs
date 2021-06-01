
namespace Forme
{
    partial class IzmenaCene
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbValuta = new System.Windows.Forms.ComboBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtVoziloIDCena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCenaVozilaID = new System.Windows.Forms.TextBox();
            this.txtNazivVozila = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVozila);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 243);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dostupna vozila";
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToAddRows = false;
            this.dgvVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Location = new System.Drawing.Point(20, 32);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.RowHeadersWidth = 51;
            this.dgvVozila.RowTemplate.Height = 24;
            this.dgvVozila.Size = new System.Drawing.Size(762, 186);
            this.dgvVozila.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(290, 455);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(258, 34);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Izmeni cenu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbValuta
            // 
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Location = new System.Drawing.Point(582, 400);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(134, 24);
            this.cmbValuta.TabIndex = 14;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(263, 400);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(134, 22);
            this.txtIznos.TabIndex = 13;
            // 
            // txtVoziloIDCena
            // 
            this.txtVoziloIDCena.Location = new System.Drawing.Point(263, 282);
            this.txtVoziloIDCena.Name = "txtVoziloIDCena";
            this.txtVoziloIDCena.Size = new System.Drawing.Size(134, 22);
            this.txtVoziloIDCena.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valuta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Iznos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "VoziloID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "CenaVozilaID:";
            // 
            // txtCenaVozilaID
            // 
            this.txtCenaVozilaID.Location = new System.Drawing.Point(263, 338);
            this.txtCenaVozilaID.Name = "txtCenaVozilaID";
            this.txtCenaVozilaID.ReadOnly = true;
            this.txtCenaVozilaID.Size = new System.Drawing.Size(134, 22);
            this.txtCenaVozilaID.TabIndex = 18;
            // 
            // txtNazivVozila
            // 
            this.txtNazivVozila.Location = new System.Drawing.Point(582, 279);
            this.txtNazivVozila.Name = "txtNazivVozila";
            this.txtNazivVozila.Size = new System.Drawing.Size(134, 22);
            this.txtNazivVozila.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Naziv vozila:";
            // 
            // IzmenaCene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 501);
            this.Controls.Add(this.txtNazivVozila);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCenaVozilaID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbValuta);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtVoziloIDCena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IzmenaCene";
            this.Text = "Izmena cene vozila";
            this.Load += new System.EventHandler(this.IzmenaCene_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbValuta;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.TextBox txtVoziloIDCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCenaVozilaID;
        private System.Windows.Forms.TextBox txtNazivVozila;
        private System.Windows.Forms.Label label5;
    }
}