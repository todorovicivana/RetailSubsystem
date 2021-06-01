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
    public partial class IzmenaStavkePredracuna : Form
    {
        private DataGridView dgvStavkePredracuna;
        private TextBox txtPredracunID;
        private TextBox txtUkupanIznos;

        public IzmenaStavkePredracuna()
        {
           
        }

        public IzmenaStavkePredracuna(DataGridView dgvStavkePredracuna, TextBox txtPredracunID, TextBox txtUkupanIznos)
        {
            InitializeComponent();
            this.dgvStavkePredracuna = dgvStavkePredracuna;
            this.txtPredracunID = txtPredracunID;
            this.txtUkupanIznos = txtUkupanIznos;
        }

        private void IzmenaStavkePredracuna_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSvaVozila(dgvVozilo, this);
            KontrolerKI.KontrolerKI.Instance.PostaviIDPredracuna(txtPredracunID, txtPredracunIDStavka, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabranuStavkuPredracuna(dgvStavkePredracuna, txtStavkaPredracunaID, txtKolicina, txtVoziloID, dgvVozilo, dgvOprema, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzmeniStavkuPredracuna(txtPredracunIDStavka, txtStavkaPredracunaID, txtKolicina, txtVoziloID, dgvVozilo, dgvStavkePredracuna, txtUkupanIznos, this);
        }

        private void btnIzaberiVozilo_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzaberiVozilo(dgvVozilo, txtVoziloID, dgvOprema, this);

        }
    }
}
