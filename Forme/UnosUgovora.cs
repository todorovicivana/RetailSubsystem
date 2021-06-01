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
    public partial class UnosUgovora : Form
    {
        public UnosUgovora()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

   

        private void UnosUgovora_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajIDUgovoraInicijalizujListu(txtUgovorID, this);
            KontrolerKI.KontrolerKI.Instance.UcitajNarudzbenice(cmbNarudzbenica, this);
            KontrolerKI.KontrolerKI.Instance.UcitajSveProdavce(cmbProdavac, this);
           
        }

        private void txtBrojUgovora_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbNarudzbenica_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PostaviKupcaZaIzabranuNarudzbenicu(cmbNarudzbenica, txtKupac, this);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new UnosClanaUgovora(txtUgovorID,dgvClanoviUgovora).ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiClanUgovoraIzGrida(dgvClanoviUgovora, btnObrisi, this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
           KontrolerKI.KontrolerKI.Instance.SacuvajUgovor(txtUgovorID, txtBrojUgovora, cmbNarudzbenica, txtDatumPotpisivanja, cmbProdavac, txtKupac, this);
        }
    }
}
