
namespace Forme
{
    partial class PrikazOpreme
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
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOprema);
            this.groupBox1.Location = new System.Drawing.Point(15, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 296);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oprema";
            // 
            // dgvOprema
            // 
            this.dgvOprema.AllowUserToAddRows = false;
            this.dgvOprema.AllowUserToDeleteRows = false;
            this.dgvOprema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.Location = new System.Drawing.Point(18, 31);
            this.dgvOprema.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.ReadOnly = true;
            this.dgvOprema.RowHeadersWidth = 51;
            this.dgvOprema.Size = new System.Drawing.Size(567, 244);
            this.dgvOprema.TabIndex = 85;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(654, 12);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(137, 27);
            this.btnPretrazi.TabIndex = 99;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(248, 17);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(377, 22);
            this.txtKriterijum.TabIndex = 95;
            this.txtKriterijum.TextChanged += new System.EventHandler(this.txtKriterijum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 94;
            this.label1.Text = "Pretraži po nazivu/opisu opreme:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(654, 249);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(137, 34);
            this.btnObrisi.TabIndex = 98;
            this.btnObrisi.Text = "Obriši opremu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(654, 164);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(137, 34);
            this.btnIzmeni.TabIndex = 97;
            this.btnIzmeni.Text = "Izmeni opremu";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // PrikazOpreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 375);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtKriterijum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Name = "PrikazOpreme";
            this.Text = "Prikaz opreme";
            this.Load += new System.EventHandler(this.PrikazOpreme_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
    }
}