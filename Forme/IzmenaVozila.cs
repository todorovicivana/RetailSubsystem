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
    public partial class IzmenaVozila : Form
    {
        private DataGridView dgvVozila;

        public IzmenaVozila()
        {
          
        }

        public IzmenaVozila(DataGridView dgvVozila)
        {
            InitializeComponent();
            this.dgvVozila = dgvVozila;
        }

        private void IzmenaVozila_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PopuniCMBVrstaMenjaca(cmbVrstaMenjaca, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabranoVozilo(dgvVozila, dgvDeloviVozila, txtVoziloID, txtNazivVozila, txtNazivModela,
            txtBrojVrata, txtSnagaMotora, cmbVrstaMenjaca, txtTipVozila, this);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new UnosDelaVozila(txtVoziloID,dgvDeloviVozila).ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiDeoVozila(dgvDeloviVozila, btnObrisi, this);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            new IzmenaDelaVozila(txtVoziloID, dgvDeloviVozila).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzmeniVozilo(txtVoziloID, txtNazivVozila, txtNazivModela, txtBrojVrata, txtSnagaMotora, cmbVrstaMenjaca, txtTipVozila, dgvVozila, this);
        }
    }
}
