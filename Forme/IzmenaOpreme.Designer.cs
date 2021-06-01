
namespace Forme
{
    partial class IzmenaOpreme
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtOpisOpreme = new System.Windows.Forms.TextBox();
            this.txtNazivOpreme = new System.Windows.Forms.TextBox();
            this.txtOpremaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Izmeni opremu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOpisOpreme
            // 
            this.txtOpisOpreme.Location = new System.Drawing.Point(164, 134);
            this.txtOpisOpreme.Multiline = true;
            this.txtOpisOpreme.Name = "txtOpisOpreme";
            this.txtOpisOpreme.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOpisOpreme.Size = new System.Drawing.Size(335, 144);
            this.txtOpisOpreme.TabIndex = 12;
            // 
            // txtNazivOpreme
            // 
            this.txtNazivOpreme.Location = new System.Drawing.Point(164, 75);
            this.txtNazivOpreme.Name = "txtNazivOpreme";
            this.txtNazivOpreme.Size = new System.Drawing.Size(335, 22);
            this.txtNazivOpreme.TabIndex = 11;
            // 
            // txtOpremaID
            // 
            this.txtOpremaID.Location = new System.Drawing.Point(164, 18);
            this.txtOpremaID.Name = "txtOpremaID";
            this.txtOpremaID.ReadOnly = true;
            this.txtOpremaID.Size = new System.Drawing.Size(129, 22);
            this.txtOpremaID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Opis opreme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naziv opreme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "OpremaID:";
            // 
            // IzmenaOpreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOpisOpreme);
            this.Controls.Add(this.txtNazivOpreme);
            this.Controls.Add(this.txtOpremaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IzmenaOpreme";
            this.Text = "Izmena opreme";
            this.Load += new System.EventHandler(this.IzmenaOpreme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOpisOpreme;
        private System.Windows.Forms.TextBox txtNazivOpreme;
        private System.Windows.Forms.TextBox txtOpremaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}