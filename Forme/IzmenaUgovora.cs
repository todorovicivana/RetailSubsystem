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
    public partial class IzmenaUgovora : Form
    {
        private DataGridView dgvUgovori;

        public IzmenaUgovora()
        {
            
        }

        public IzmenaUgovora(DataGridView dgvUgovori)
        {
            InitializeComponent();
            this.dgvUgovori = dgvUgovori;
        }

        private void IzmenaUgovora_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSveProdavce(cmbProdavac, this);
            KontrolerKI.KontrolerKI.Instance.UcitajNarudzbenice(cmbNarudzbenica, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabraniUgovor(dgvUgovori, dgvClanoviUgovora, txtUgovorID, txtBrojUgovora, txtDatumPotpisivanja,
              cmbNarudzbenica, txtKupac, cmbProdavac, this);
        }

        private void cmbNarudzbenica_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PostaviKupcaZaIzabranuNarudzbenicu(cmbNarudzbenica, txtKupac, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new UnosClanaUgovora(txtUgovorID, dgvClanoviUgovora).ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiClanUgovora(dgvClanoviUgovora, btnObrisi, this);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            new IzmenaClanaUgovora(txtUgovorID, dgvClanoviUgovora).ShowDialog();
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzmeniUgovor(txtUgovorID, txtBrojUgovora, txtDatumPotpisivanja, cmbNarudzbenica, txtKupac, cmbProdavac, dgvUgovori, this);
        }
    }
}
