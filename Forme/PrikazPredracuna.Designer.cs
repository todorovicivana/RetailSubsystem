
namespace Forme
{
    partial class PrikazPredracuna
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
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPredracuni = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredracuni)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(453, 17);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(576, 22);
            this.txtKriterijum.TabIndex = 1;
            this.txtKriterijum.TextChanged += new System.EventHandler(this.txtKriterijum_TextChanged);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(1053, 11);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(137, 34);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPredracuni);
            this.groupBox1.Location = new System.Drawing.Point(28, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 318);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predračuni";
            // 
            // dgvPredracuni
            // 
            this.dgvPredracuni.AllowUserToAddRows = false;
            this.dgvPredracuni.AllowUserToDeleteRows = false;
            this.dgvPredracuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPredracuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredracuni.Location = new System.Drawing.Point(22, 22);
            this.dgvPredracuni.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPredracuni.Name = "dgvPredracuni";
            this.dgvPredracuni.ReadOnly = true;
            this.dgvPredracuni.RowHeadersWidth = 51;
            this.dgvPredracuni.Size = new System.Drawing.Size(1108, 269);
            this.dgvPredracuni.TabIndex = 85;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(311, 411);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(190, 34);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni predračun";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(544, 411);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(190, 34);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši predračun";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 17);
            this.label2.TabIndex = 95;
            this.label2.Text = "Pretraga po broju predračuna/načinu plaćanja/kupcu/prodavcu:";
            // 
            // PrikazPredracuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtKriterijum);
            this.Name = "PrikazPredracuna";
            this.Text = "Prikaz predračuna";
            this.Load += new System.EventHandler(this.PrikazPredracuna_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredracuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvPredracuni;
        private System.Windows.Forms.Label label2;
    }
}