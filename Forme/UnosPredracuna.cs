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
    public partial class UnosPredracuna : Form
    {
        public UnosPredracuna()
        {
            InitializeComponent();
        }

        private void UnosPredracuna_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajIDPredracunaInicijalizujListu(txtPredracunID, this);
            KontrolerKI.KontrolerKI.Instance.UcitajUgovoreZaComboBox(cmbUgovor, this);
            KontrolerKI.KontrolerKI.Instance.UcitajSveProdavce(cmbProdavac, this);
            KontrolerKI.KontrolerKI.Instance.PopuniCMBNacinPlacanja(cmbNacinPlacanja, this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDatumPrometa_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUgovor_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PostaviKupcaZaIzabraniUgovor(cmbUgovor, txtKupac, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new UnosStavkePredracuna(dgvStavkePredracuna, txtPredracunID).ShowDialog();
        }

        private void dgvStavkePredracuna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiStavkuPredracunaIzGrida(dgvStavkePredracuna, btnObrisi, this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.SacuvajPredracun(txtPredracunID, txtBrojPredracuna, txtDatumIzdavanja, txtDatumPrometa, cmbNacinPlacanja, cmbUgovor, cmbProdavac, txtKupac, this);
        }
    }
}
