using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class UnosClanaUgovora : Form
    {
        private DataGridView dgvClanoviUgovora;
        private TextBox txtUgovorID;

        public UnosClanaUgovora()
        {
            
        }

        public UnosClanaUgovora(TextBox txtUgovorID, DataGridView dgvClanoviUgovora)
        {
            InitializeComponent();
            this.txtUgovorID = txtUgovorID;
            this.dgvClanoviUgovora = dgvClanoviUgovora;
        }

        private void UnosClanaUgovora_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PostaviIDUgovora(txtUgovorID,txtUgovorIDStavka, this);
          
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
           KontrolerKI.KontrolerKI.Instance.DodajClanUgovora(txtUgovorIDStavka, txtNazivClana, txtOpisClana, dgvClanoviUgovora, this);
        }




    }
}
