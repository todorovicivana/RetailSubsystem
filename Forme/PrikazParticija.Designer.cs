
namespace Forme
{
    partial class PrikazParticija
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvParticije = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUgovor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticije)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(287, 270);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(208, 28);
            this.btnPrikazi.TabIndex = 14;
            this.btnPrikazi.Text = "Izaberi particiju";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvParticije);
            this.groupBox1.Location = new System.Drawing.Point(76, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 224);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Particije";
            // 
            // dgvParticije
            // 
            this.dgvParticije.AllowUserToAddRows = false;
            this.dgvParticije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticije.Location = new System.Drawing.Point(20, 21);
            this.dgvParticije.Margin = new System.Windows.Forms.Padding(4);
            this.dgvParticije.MultiSelect = false;
            this.dgvParticije.Name = "dgvParticije";
            this.dgvParticije.ReadOnly = true;
            this.dgvParticije.RowHeadersWidth = 51;
            this.dgvParticije.Size = new System.Drawing.Size(589, 183);
            this.dgvParticije.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUgovor);
            this.groupBox2.Location = new System.Drawing.Point(28, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 274);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ugovori za izabranu particiju";
            // 
            // dgvUgovor
            // 
            this.dgvUgovor.AllowUserToAddRows = false;
            this.dgvUgovor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUgovor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovor.Location = new System.Drawing.Point(20, 37);
            this.dgvUgovor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUgovor.MultiSelect = false;
            this.dgvUgovor.Name = "dgvUgovor";
            this.dgvUgovor.ReadOnly = true;
            this.dgvUgovor.RowHeadersWidth = 51;
            this.dgvUgovor.Size = new System.Drawing.Size(702, 216);
            this.dgvUgovor.TabIndex = 18;
            // 
            // PrikazParticija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrikazi);
            this.Name = "PrikazParticija";
            this.Text = "Prikaz particija";
            this.Load += new System.EventHandler(this.PrikazParticija_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticije)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvParticije;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvUgovor;
    }
}