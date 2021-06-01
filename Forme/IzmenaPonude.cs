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
    public partial class IzmenaPonude : Form
    {
        private DataGridView dgvPonude;

        public IzmenaPonude()
        {
           
        }

        public IzmenaPonude(DataGridView dgvPonude)
        {
            InitializeComponent();
            this.dgvPonude = dgvPonude;
        }

        private void IzmenaPonude_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSveProdavce(cmbProdavac, this);
            KontrolerKI.KontrolerKI.Instance.UcitajSveKataloge(cmbKatalog, this);
            KontrolerKI.KontrolerKI.Instance.UcitajSveKupce(cmbKupac, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabranuPonudu(dgvPonude, dgvStavkePonude, txtPonudaID, txtBrojPonude, txtDatumOd, txtDatumDo, txtRokIsporuke,
              cmbKatalog, cmbKupac, cmbProdavac, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new UnosStavkePonude(txtPonudaID, dgvStavkePonude).ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiStavkuPonude(dgvStavkePonude, btnObrisi, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new IzmenaStavkePonude(txtPonudaID, dgvStavkePonude).ShowDialog();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzmeniPonudu(txtPonudaID, txtDatumOd, txtDatumDo, txtBrojPonude, txtRokIsporuke, cmbKatalog, cmbProdavac, cmbKupac, dgvPonude, this);

        }
    }
}
