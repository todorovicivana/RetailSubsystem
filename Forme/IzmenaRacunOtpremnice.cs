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
    public partial class IzmenaRacunOtpremnice : Form
    {
        private DataGridView dgvRacunOtpremnice;

        public IzmenaRacunOtpremnice()
        {
         
        }

        public IzmenaRacunOtpremnice(DataGridView dgvRacunOtpremnice)
        {
            InitializeComponent();
            this.dgvRacunOtpremnice = dgvRacunOtpremnice;
        }

        private void IzmenaRacunOtpremnice_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajPredracune(cmbPredracun, this);
            KontrolerKI.KontrolerKI.Instance.PopuniCMBNacinPlacanja(cmbNacinPlacanja, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabranuRacunOtpremnicu(dgvRacunOtpremnice, dgvStavkeRacunaOtpremnice, txtRacunOtpremnicaID, txtBrojRacunaOtpremnice, txtDatumIzdavanja, txtDatumPrometa, cmbNacinPlacanja, txtImePrezimeProdavca,
              cmbPredracun, txtProdavacID, txtKupac, this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDatumIzdavanja_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPredracun_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PostaviKupcaZaIzabraniPredracun(cmbPredracun, txtKupac, this);
        }

        private void btnIzaberiProdavca_Click(object sender, EventArgs e)
        {
            if (txtProdavacID.Text == "")
            {
                MessageBox.Show("Unesite ID Prodavca!");
                return;
            }
            else if (!(KontrolerKI.KontrolerKI.Instance.PostojiProdavacUBazi(txtProdavacID, this)))
            {
                MessageBox.Show("Prodavac sa unetom vrednošću ID-a ne postoji u bazi!");
                txtImePrezimeProdavca.Text = "";
                txtProdavacID.Clear();
                txtProdavacID.Focus();
                return;
            }
            else
            {
                KontrolerKI.KontrolerKI.Instance.vratiImePrezimeProdavcaNaOsnovuIDTextBox(txtProdavacID, txtImePrezimeProdavca, this);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiStavkuRacunOtpremnice(dgvStavkeRacunaOtpremnice, btnObrisi, this);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            new IzmenaStavkeRacunOtpremnice(dgvStavkeRacunaOtpremnice, txtRacunOtpremnicaID).ShowDialog();
        }

        private void btnIzmeniRO_Click(object sender, EventArgs e)
        {
           KontrolerKI.KontrolerKI.Instance.IzmeniRacunOtpremnicu(txtRacunOtpremnicaID, txtBrojRacunaOtpremnice, txtDatumIzdavanja, txtDatumPrometa, cmbNacinPlacanja, cmbPredracun, txtKupac, txtProdavacID, txtImePrezimeProdavca, dgvRacunOtpremnice, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new UnosStavkeRacunaOtpremnice(txtRacunOtpremnicaID, dgvStavkeRacunaOtpremnice).ShowDialog();
        }
    }
}
