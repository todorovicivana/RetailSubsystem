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
    public partial class IzmenaClanaUgovora : Form
    {
        private TextBox txtUgovorID;
        private DataGridView dgvClanoviUgovora;
    


        public IzmenaClanaUgovora()
        {
          
        }

        public IzmenaClanaUgovora(TextBox txtUgovorID, DataGridView dgvClanoviUgovora)
        {
            InitializeComponent();
            this.txtUgovorID = txtUgovorID;
            this.dgvClanoviUgovora = dgvClanoviUgovora;
        }

        private void IzmenaClanaUgovora_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PostaviIDUgovora(txtUgovorID, txtUgovorIDStavka, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabraniClanUgovora(dgvClanoviUgovora, txtClanUgovoraID ,txtNazivClana, txtOpisClana, this);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
           KontrolerKI.KontrolerKI.Instance.IzmeniClanUgovora(txtUgovorIDStavka, txtClanUgovoraID, txtNazivClana, txtOpisClana, dgvClanoviUgovora, this);
        }

        private void txtClanUgovoraID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNazivClana_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
