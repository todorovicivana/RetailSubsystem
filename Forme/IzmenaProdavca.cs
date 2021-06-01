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
    public partial class IzmenaProdavca : Form
    {
        private DataGridView dgvProdavci;

        public IzmenaProdavca()
        {
           
        }

        public IzmenaProdavca(DataGridView dgvProdavci)
        {
            InitializeComponent();
            this.dgvProdavci = dgvProdavci;
        }

        private void IzmenaProdavca_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajOdabranogProdavca(dgvProdavci, txtProdavacID, txtImePrezimeProdavca, this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzmeniProdavca(txtProdavacID, txtImePrezimeProdavca, dgvProdavci, this);
        }
    }
}
