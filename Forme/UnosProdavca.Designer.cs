
namespace Forme
{
    partial class UnosProdavca
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdavacID = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtImePrezimeProdavca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProdavacID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime i prezime prodavca:";
            // 
            // txtProdavacID
            // 
            this.txtProdavacID.Location = new System.Drawing.Point(201, 22);
            this.txtProdavacID.Name = "txtProdavacID";
            this.txtProdavacID.ReadOnly = true;
            this.txtProdavacID.Size = new System.Drawing.Size(91, 22);
            this.txtProdavacID.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(345, 128);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(161, 34);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sačuvaj prodavca";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtImePrezimeProdavca
            // 
            this.txtImePrezimeProdavca.Location = new System.Drawing.Point(201, 74);
            this.txtImePrezimeProdavca.Name = "txtImePrezimeProdavca";
            this.txtImePrezimeProdavca.Size = new System.Drawing.Size(305, 22);
            this.txtImePrezimeProdavca.TabIndex = 7;
            // 
            // UnosProdavca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 186);
            this.Controls.Add(this.txtImePrezimeProdavca);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtProdavacID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnosProdavca";
            this.Text = "Unos prodavca";
            this.Load += new System.EventHandler(this.UnosProdavca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdavacID;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtImePrezimeProdavca;
    }
}