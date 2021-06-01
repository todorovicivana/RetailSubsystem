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
    public partial class UnosStavkePredracuna : Form
    {
        
        private DataGridView dgvStavkePredracuna;
        private TextBox txtPredracunID;
        private TextBox txtUkupanIznos;

        public UnosStavkePredracuna()
        {
           
        }

        public UnosStavkePredracuna(DataGridView dgvStavkePredracuna, TextBox txtPredracunID, TextBox txtUkupanIznos)
        {
            InitializeComponent();
            this.dgvStavkePredracuna = dgvStavkePredracuna;
            this.txtPredracunID = txtPredracunID;
            this.txtUkupanIznos = txtUkupanIznos;
        }

        public UnosStavkePredracuna(DataGridView dgvStavkePredracuna, TextBox txtPredracunID)
        {
            InitializeComponent();
            this.dgvStavkePredracuna = dgvStavkePredracuna;
            this.txtPredracunID = txtPredracunID;
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {

        }

        private void UnosStavkePredracuna_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSvaVozila(dgvVozilo, this);
            KontrolerKI.KontrolerKI.Instance.PostaviIDPredracuna(txtPredracunID, txtPredracunIDStavka, this);

        }

        private void dgvVozilo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbVozilo_Enter(object sender, EventArgs e)
        {

        }

        private void btnIzaberiVozilo_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzaberiVozilo(dgvVozilo, txtVoziloID, dgvOprema, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           KontrolerKI.KontrolerKI.Instance.DodajStavkuPredracuna(dgvStavkePredracuna, dgvVozilo, txtPredracunIDStavka, txtKolicina, txtVoziloID, txtUkupanIznos, this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPredracunID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvOprema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtVoziloID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKolicina_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
