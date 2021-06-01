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
    public partial class IzmenaStavkePonude : Form
    {
        private TextBox txtPonudaID;
        private DataGridView dgvStavkePonude;

        public IzmenaStavkePonude()
        {
           
        }

        public IzmenaStavkePonude(TextBox txtPonudaID, DataGridView dgvStavkePonude)
        {
            InitializeComponent();
            this.txtPonudaID = txtPonudaID;
            this.dgvStavkePonude = dgvStavkePonude;
        }

        private void IzmenaStavkePonude_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSvaVozila(dgvVozilo, this);
            KontrolerKI.KontrolerKI.Instance.PostaviIDPonude(txtPonudaID, txtPonudaIDStavka, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabranuStavkuPonude(dgvStavkePonude, txtStavkaPonudeID, txtNapomena, txtVoziloID, dgvVozilo, dgvOprema, this);
        }

        private void btnIzaberiVozilo_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzaberiVozilo(dgvVozilo, txtVoziloID, dgvOprema, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzmeniStavkuPonude(txtPonudaIDStavka, txtStavkaPonudeID, txtNapomena, txtVoziloID, dgvVozilo, dgvStavkePonude, this);

        }
    }
}
