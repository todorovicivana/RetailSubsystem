
namespace Forme
{
    partial class UnosClanaUgovora
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUgovorIDStavka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivClana = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpisClana = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UgovorID:";
            // 
            // txtUgovorIDStavka
            // 
            this.txtUgovorIDStavka.Location = new System.Drawing.Point(135, 23);
            this.txtUgovorIDStavka.Name = "txtUgovorIDStavka";
            this.txtUgovorIDStavka.ReadOnly = true;
            this.txtUgovorIDStavka.Size = new System.Drawing.Size(136, 22);
            this.txtUgovorIDStavka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv člana ugovora:";
            // 
            // txtNazivClana
            // 
            this.txtNazivClana.Location = new System.Drawing.Point(186, 89);
            this.txtNazivClana.Name = "txtNazivClana";
            this.txtNazivClana.Size = new System.Drawing.Size(467, 22);
            this.txtNazivClana.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opis člana ugovora:";
            // 
            // txtOpisClana
            // 
            this.txtOpisClana.Location = new System.Drawing.Point(188, 144);
            this.txtOpisClana.Multiline = true;
            this.txtOpisClana.Name = "txtOpisClana";
            this.txtOpisClana.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOpisClana.Size = new System.Drawing.Size(465, 199);
            this.txtOpisClana.TabIndex = 5;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(309, 363);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(216, 40);
            this.btnPotvrdi.TabIndex = 8;
            this.btnPotvrdi.Text = "Potvrdi unos";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // UnosClanaUgovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 424);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.txtOpisClana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNazivClana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUgovorIDStavka);
            this.Controls.Add(this.label1);
            this.Name = "UnosClanaUgovora";
            this.Text = "Unos člana ugovora";
            this.Load += new System.EventHandler(this.UnosClanaUgovora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUgovorIDStavka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivClana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpisClana;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}