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
    public partial class IzmenaPredracuna : Form
    {
        private DataGridView dgvPredracuni;

        public IzmenaPredracuna()
        {
            
        }

        public IzmenaPredracuna(DataGridView dgvPredracuni)
        {
            InitializeComponent();
            this.dgvPredracuni = dgvPredracuni;
        }

        private void cmbPredracun_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PostaviKupcaZaIzabraniUgovor(cmbUgovor, txtKupac, this);
        }

        private void IzmenaPredracuna_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajUgovoreZaComboBox(cmbUgovor, this);
            KontrolerKI.KontrolerKI.Instance.UcitajSveProdavce(cmbProdavac, this);
            KontrolerKI.KontrolerKI.Instance.PopuniCMBNacinPlacanja(cmbNacinPlacanja, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabraniPredracun(dgvPredracuni, dgvStavkePredracuna, txtPredracunID, txtBrojPredracuna, txtDatumIzdavanja, txtDatumPrometa, cmbNacinPlacanja, cmbProdavac,
             cmbUgovor, txtKupac, txtUkupanIznos, this);
        }

        private void btnIzmeniRO_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzmeniPredracun(txtPredracunID, txtBrojPredracuna, txtDatumIzdavanja, txtDatumPrometa, cmbNacinPlacanja, cmbUgovor, cmbProdavac, txtKupac, txtUkupanIznos, dgvPredracuni, this);

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            new IzmenaStavkePredracuna(dgvStavkePredracuna, txtPredracunID, txtUkupanIznos).ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new UnosStavkePredracuna(dgvStavkePredracuna,txtPredracunID,txtUkupanIznos).ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiStavkuPredracuna(dgvStavkePredracuna, btnObrisi, txtUkupanIznos, this);
        }
    }
}
