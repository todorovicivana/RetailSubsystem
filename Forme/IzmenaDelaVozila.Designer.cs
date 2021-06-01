
namespace Forme
{
    partial class IzmenaDelaVozila
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
            this.btnIzaberiOpremu = new System.Windows.Forms.Button();
            this.txtOpremaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDodaj = new System.Windows.Forms.Button();
            this.txtVoziloIDDeo = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeoVozilaID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzaberiOpremu);
            this.groupBox1.Controls.Add(this.txtOpremaID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvOprema);
            this.groupBox1.Location = new System.Drawing.Point(25, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 308);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oprema uz vozilo";
            // 
            // btnIzaberiOpremu
            // 
            this.btnIzaberiOpremu.Location = new System.Drawing.Point(491, 252);
            this.btnIzaberiOpremu.Name = "btnIzaberiOpremu";
            this.btnIzaberiOpremu.Size = new System.Drawing.Size(137, 34);
            this.btnIzaberiOpremu.TabIndex = 88;
            this.btnIzaberiOpremu.Text = "Izaberi opremu";
            this.btnIzaberiOpremu.UseVisualStyleBackColor = true;
            this.btnIzaberiOpremu.Click += new System.EventHandler(this.btnIzaberiOpremu_Click);
            // 
            // txtOpremaID
            // 
            this.txtOpremaID.Location = new System.Drawing.Point(119, 266);
            this.txtOpremaID.Name = "txtOpremaID";
            this.txtOpremaID.ReadOnly = true;
            this.txtOpremaID.Size = new System.Drawing.Size(155, 22);
            this.txtOpremaID.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "OpremaID:";
            // 
            // dgvOprema
            // 
            this.dgvOprema.AllowUserToAddRows = false;
            this.dgvOprema.AllowUserToDeleteRows = false;
            this.dgvOprema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.Location = new System.Drawing.Point(29, 35);
            this.dgvOprema.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.ReadOnly = true;
            this.dgvOprema.RowHeadersWidth = 51;
            this.dgvOprema.Size = new System.Drawing.Size(599, 205);
            this.dgvOprema.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "Napomena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "VoziloID:";
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(231, 538);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(243, 34);
            this.btDodaj.TabIndex = 95;
            this.btDodaj.Text = "Izmeni deo vozila";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // txtVoziloIDDeo
            // 
            this.txtVoziloIDDeo.Location = new System.Drawing.Point(144, 19);
            this.txtVoziloIDDeo.Name = "txtVoziloIDDeo";
            this.txtVoziloIDDeo.ReadOnly = true;
            this.txtVoziloIDDeo.Size = new System.Drawing.Size(118, 22);
            this.txtVoziloIDDeo.TabIndex = 94;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(144, 80);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(260, 90);
            this.txtNapomena.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 96;
            this.label4.Text = "DeoVozilaID:";
            // 
            // txtDeoVozilaID
            // 
            this.txtDeoVozilaID.Location = new System.Drawing.Point(562, 16);
            this.txtDeoVozilaID.Name = "txtDeoVozilaID";
            this.txtDeoVozilaID.ReadOnly = true;
            this.txtDeoVozilaID.Size = new System.Drawing.Size(118, 22);
            this.txtDeoVozilaID.TabIndex = 97;
            // 
            // IzmenaDelaVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 580);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeoVozilaID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.txtVoziloIDDeo);
            this.Controls.Add(this.txtNapomena);
            this.Name = "IzmenaDelaVozila";
            this.Text = "Izmena dela vozila";
            this.Load += new System.EventHandler(this.IzmenaDelaVozila_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzaberiOpremu;
        private System.Windows.Forms.TextBox txtOpremaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.TextBox txtVoziloIDDeo;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeoVozilaID;
    }
}