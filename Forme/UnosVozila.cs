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
    public partial class UnosVozila : Form
    {
        public UnosVozila()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UnosVozila_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajIDVozilaInicijalizujListu(txtVoziloID, this);
            KontrolerKI.KontrolerKI.Instance.PopuniCMBVrstaMenjaca(cmbVrstaMenjaca, this);
            txtNazivVozila.Select();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new UnosDelaVozila(txtVoziloID, dgvDeloviVozila).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiDeoVozilaIzGrida(dgvDeloviVozila, btnObrisi, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.SacuvajVozilo(txtVoziloID, txtNazivVozila ,txtNazivModela, txtBrojVrata, txtSnagaMotora, cmbVrstaMenjaca, txtTipVozila, this);
        }

    }
}
