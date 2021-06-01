
namespace Forme
{
    partial class UnosOpreme
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpremaID = new System.Windows.Forms.TextBox();
            this.txtNazivOpreme = new System.Windows.Forms.TextBox();
            this.txtOpisOpreme = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OpremaID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv opreme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis opreme:";
            // 
            // txtOpremaID
            // 
            this.txtOpremaID.Location = new System.Drawing.Point(164, 23);
            this.txtOpremaID.Name = "txtOpremaID";
            this.txtOpremaID.ReadOnly = true;
            this.txtOpremaID.Size = new System.Drawing.Size(129, 22);
            this.txtOpremaID.TabIndex = 3;
            // 
            // txtNazivOpreme
            // 
            this.txtNazivOpreme.Location = new System.Drawing.Point(164, 80);
            this.txtNazivOpreme.Name = "txtNazivOpreme";
            this.txtNazivOpreme.Size = new System.Drawing.Size(335, 22);
            this.txtNazivOpreme.TabIndex = 4;
            // 
            // txtOpisOpreme
            // 
            this.txtOpisOpreme.Location = new System.Drawing.Point(164, 139);
            this.txtOpisOpreme.Multiline = true;
            this.txtOpisOpreme.Name = "txtOpisOpreme";
            this.txtOpisOpreme.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOpisOpreme.Size = new System.Drawing.Size(335, 144);
            this.txtOpisOpreme.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sačuvaj opremu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UnosOpreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOpisOpreme);
            this.Controls.Add(this.txtNazivOpreme);
            this.Controls.Add(this.txtOpremaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnosOpreme";
            this.Text = "Unos opreme";
            this.Load += new System.EventHandler(this.UnosOpreme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpremaID;
        private System.Windows.Forms.TextBox txtNazivOpreme;
        private System.Windows.Forms.TextBox txtOpisOpreme;
        private System.Windows.Forms.Button button1;
    }
}