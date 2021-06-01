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
    public partial class UnosStavkePonude : Form
    {
        private TextBox txtPonudaID;
        private DataGridView dgvStavkePonude;

        public UnosStavkePonude()
        {

        }

        public UnosStavkePonude(TextBox txtPonudaID, DataGridView dgvStavkePonude)
        {

            InitializeComponent();
            this.txtPonudaID = txtPonudaID;
            this.dgvStavkePonude = dgvStavkePonude;
        }

        private void UnosStavkePonude_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSvaVozila(dgvVozilo, this);
            KontrolerKI.KontrolerKI.Instance.PostaviIDPonude(txtPonudaID, txtPonudaIDStavka, this);
        }

        private void btnIzaberiVozilo_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzaberiVozilo(dgvVozilo, txtVoziloID, dgvOprema, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.DodajStavkuPonude(dgvStavkePonude, dgvVozilo, txtPonudaIDStavka, txtNapomena, txtVoziloID, this);
        }
    }
}
