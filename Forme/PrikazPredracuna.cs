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
    public partial class PrikazPredracuna : Form
    {
        public PrikazPredracuna()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(txtKriterijum.Text=="")
            {
                MessageBox.Show("Unesite kriterijum pretrage!");
                return;
            }
            else
            {
                KontrolerKI.KontrolerKI.Instance.UcitajPredracuneZaKriterijum(dgvPredracuni,txtKriterijum.Text, this);
            }
        }

        private void PrikazPredracuna_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajPredracuneUDataGrid(dgvPredracuni, this);
        }

        private void dgvPredracuni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtKriterijum_TextChanged(object sender, EventArgs e)
        {
            if(txtKriterijum.Text=="")
            {
                KontrolerKI.KontrolerKI.Instance.UcitajPredracuneUDataGrid(dgvPredracuni, this);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            new IzmenaPredracuna(dgvPredracuni).ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiPredracun(dgvPredracuni, this);
        }
    }
}
