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
    public partial class UnosDelaVozila : Form
    {
        private TextBox txtVoziloID;
        private DataGridView dgvDeloviVozila;

        public UnosDelaVozila()
        {
           
        }

        public UnosDelaVozila(TextBox txtVoziloID, DataGridView dgvDeloviVozila)
        {
            InitializeComponent();
            this.txtVoziloID = txtVoziloID;
            this.dgvDeloviVozila = dgvDeloviVozila;
        }

        private void UnosDelaVozila_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSvuOpremu(dgvOprema, this);
            KontrolerKI.KontrolerKI.Instance.PostaviIDVozila(txtVoziloID, txtVoziloIDDeo, this);
        }

        private void btnIzaberiOpremu_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzaberiOpremu(dgvOprema, txtOpremaID, this);
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.DodajDeoVozila(dgvDeloviVozila, dgvOprema, txtVoziloIDDeo, txtNapomena, txtOpremaID, this);
        }
    }
}
