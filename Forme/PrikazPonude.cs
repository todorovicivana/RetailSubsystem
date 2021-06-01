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
    public partial class PrikazPonude : Form
    {
        public PrikazPonude()
        {
            InitializeComponent();
        }

        private void PrikazPonude_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajPonudeUDataGrid(dgvPonude, this);
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
                KontrolerKI.KontrolerKI.Instance.UcitajPonudeZaKriterijum(dgvPonude, txtKriterijum.Text, this);
            }
        }

        private void txtKriterijum_TextChanged(object sender, EventArgs e)
        {

            if (txtKriterijum.Text == "")
            {
                KontrolerKI.KontrolerKI.Instance.UcitajPonudeUDataGrid(dgvPonude, this);
            }
        }

        private void txtKriterijum_TextChanged_1(object sender, EventArgs e)
        {
            if (txtKriterijum.Text == "")
            {
                KontrolerKI.KontrolerKI.Instance.UcitajPonudeUDataGrid(dgvPonude, this);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiPonudu(dgvPonude, this);

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            new IzmenaPonude(dgvPonude).ShowDialog();
        }
    }
}
