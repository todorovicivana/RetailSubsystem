
namespace Forme
{
    partial class IzmenaClanaUgovora
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
            this.txtOpisClana = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNazivClana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUgovorIDStavka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClanUgovoraID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOpisClana
            // 
            this.txtOpisClana.Location = new System.Drawing.Point(180, 176);
            this.txtOpisClana.Multiline = true;
            this.txtOpisClana.Name = "txtOpisClana";
            this.txtOpisClana.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOpisClana.Size = new System.Drawing.Size(435, 199);
            this.txtOpisClana.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Opis člana ugovora:";
            // 
            // txtNazivClana
            // 
            this.txtNazivClana.Location = new System.Drawing.Point(180, 103);
            this.txtNazivClana.Name = "txtNazivClana";
            this.txtNazivClana.Size = new System.Drawing.Size(435, 22);
            this.txtNazivClana.TabIndex = 10;
            this.txtNazivClana.TextChanged += new System.EventHandler(this.txtNazivClana_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Naziv člana ugovora:";
            // 
            // txtUgovorIDStavka
            // 
            this.txtUgovorIDStavka.Location = new System.Drawing.Point(113, 20);
            this.txtUgovorIDStavka.Name = "txtUgovorIDStavka";
            this.txtUgovorIDStavka.ReadOnly = true;
            this.txtUgovorIDStavka.Size = new System.Drawing.Size(136, 22);
            this.txtUgovorIDStavka.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "UgovorID:";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(273, 398);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(216, 40);
            this.btnIzmeni.TabIndex = 14;
            this.btnIzmeni.Text = "Izmeni član ugovora";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "ČlanUgovoraID:";
            // 
            // txtClanUgovoraID
            // 
            this.txtClanUgovoraID.Location = new System.Drawing.Point(479, 18);
            this.txtClanUgovoraID.Name = "txtClanUgovoraID";
            this.txtClanUgovoraID.ReadOnly = true;
            this.txtClanUgovoraID.Size = new System.Drawing.Size(136, 22);
            this.txtClanUgovoraID.TabIndex = 16;
            this.txtClanUgovoraID.TextChanged += new System.EventHandler(this.txtClanUgovoraID_TextChanged);
            // 
            // IzmenaClanaUgovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 460);
            this.Controls.Add(this.txtClanUgovoraID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.txtOpisClana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNazivClana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUgovorIDStavka);
            this.Controls.Add(this.label1);
            this.Name = "IzmenaClanaUgovora";
            this.Text = "Izmena člana ugovora";
            this.Load += new System.EventHandler(this.IzmenaClanaUgovora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOpisClana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazivClana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUgovorIDStavka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClanUgovoraID;
    }
}