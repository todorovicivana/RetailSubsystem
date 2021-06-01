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
    public partial class UnosRacunOtpremnice : Form
    {
        public UnosRacunOtpremnice()
        {
            InitializeComponent();
        }

        private void UnosRacunOtpremnice_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajIDRacunaOtpremniceInicijalizujListu(txtRacunOtpremnicaID, this);
            KontrolerKI.KontrolerKI.Instance.UcitajPredracune(cmbPredracun, this);
            KontrolerKI.KontrolerKI.Instance.PopuniCMBNacinPlacanja(cmbNacinPlacanja, this);
        }

        private void cmbPredracun_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PostaviKupcaZaIzabraniPredracun(cmbPredracun, txtKupac, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new UnosStavkeRacunaOtpremnice(txtRacunOtpremnicaID,dgvStavkeRacunaOtpremnice).ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiStavkuRacunOtpremniceIzGrida(dgvStavkeRacunaOtpremnice, btnObrisi, this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.SacuvajRacunOtpremnicu(txtProdavacID, txtRacunOtpremnicaID, txtBrojRacunaOtpremnice, txtDatumIzdavanja, txtDatumPrometa, cmbNacinPlacanja, cmbPredracun, txtKupac, this);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtProdavacID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
