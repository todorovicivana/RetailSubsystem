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
    public partial class UnosPonude : Form
    {
        public UnosPonude()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UnosPonude_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajIDPonudeInicijalizujListu(txtPonudaID, this);
            KontrolerKI.KontrolerKI.Instance.UcitajSveProdavce(cmbProdavac, this);
            KontrolerKI.KontrolerKI.Instance.UcitajSveKupce(cmbKupac, this);
            KontrolerKI.KontrolerKI.Instance.UcitajSveKataloge(cmbKatalog, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new UnosStavkePonude(txtPonudaID, dgvStavkePonude).ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiStavkuPonudeIzGrida(dgvStavkePonude, btnObrisi, this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.SacuvajPonudu(txtPonudaID, txtDatumOd, txtDatumDo, txtBrojPonude, txtRokIsporuke, cmbKatalog, cmbProdavac, cmbKupac, this);
        } 
    }
}
