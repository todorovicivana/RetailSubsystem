
namespace Forme
{
    partial class PrikazRacunOtpremnice
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
            this.dgvRacunOtpremnice = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacunOtpremnice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRacunOtpremnice);
            this.groupBox1.Location = new System.Drawing.Point(25, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 326);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Račun - otpremnice";
            // 
            // dgvRacunOtpremnice
            // 
            this.dgvRacunOtpremnice.AllowUserToAddRows = false;
            this.dgvRacunOtpremnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacunOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacunOtpremnice.Location = new System.Drawing.Point(15, 31);
            this.dgvRacunOtpremnice.Name = "dgvRacunOtpremnice";
            this.dgvRacunOtpremnice.RowHeadersWidth = 51;
            this.dgvRacunOtpremnice.RowTemplate.Height = 24;
            this.dgvRacunOtpremnice.Size = new System.Drawing.Size(1016, 275);
            this.dgvRacunOtpremnice.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(897, 21);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(177, 28);
            this.btnPretrazi.TabIndex = 89;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(362, 24);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(470, 22);
            this.txtKriterijum.TabIndex = 88;
            this.txtKriterijum.TextChanged += new System.EventHandler(this.txtKriterijum_TextChanged);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(589, 425);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(177, 34);
            this.btnObrisi.TabIndex = 92;
            this.btnObrisi.Text = "Obriši račun-otpremnicu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(362, 425);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(177, 34);
            this.btnIzmeni.TabIndex = 91;
            this.btnIzmeni.Text = "Izmeni račun-otpremnicu";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Pretraga po načinu plaćanja/kupcu/prodavcu:";
            // 
            // PrikazRacunOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtKriterijum);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Name = "PrikazRacunOtpremnice";
            this.Text = "Prikaz račun - otpremnice";
            this.Load += new System.EventHandler(this.PrikazRacunOtpremnice_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacunOtpremnice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.DataGridView dgvRacunOtpremnice;
        private System.Windows.Forms.Label label2;
    }
}