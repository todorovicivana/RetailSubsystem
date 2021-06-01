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
    public partial class PrikazOpreme : Form
    {
        public PrikazOpreme()
        {
            InitializeComponent();
        }

        private void PrikazOpreme_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSvuOpremu(dgvOprema, this);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (txtKriterijum.Text == "")
            {
                MessageBox.Show("Unesite kriterijum pretrage!");
                return;
            }
            else
            {
                KontrolerKI.KontrolerKI.Instance.UcitajOpremuZaKriterijum(dgvOprema, txtKriterijum.Text, this);
            }
        }

        private void txtKriterijum_TextChanged(object sender, EventArgs e)
        {
            if (txtKriterijum.Text == "")
            {
                KontrolerKI.KontrolerKI.Instance.UcitajSvuOpremu(dgvOprema, this);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiOpremu(dgvOprema, this);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            new IzmenaOpreme(dgvOprema).ShowDialog();
        }
    }
}
