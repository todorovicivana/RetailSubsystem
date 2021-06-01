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
    public partial class IzmenaDelaVozila : Form
    {
        private TextBox txtVoziloID;
        private DataGridView dgvDeloviVozila;

        public IzmenaDelaVozila()
        {
           
        }

        public IzmenaDelaVozila(TextBox txtVoziloID, DataGridView dgvDeloviVozila)
        {
            InitializeComponent();
            this.txtVoziloID = txtVoziloID;
            this.dgvDeloviVozila = dgvDeloviVozila;
        }

        private void IzmenaDelaVozila_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSvuOpremu(dgvOprema, this);
            KontrolerKI.KontrolerKI.Instance.PostaviIDVozila(txtVoziloID, txtVoziloIDDeo, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabraniClanUgovora(dgvDeloviVozila, txtDeoVozilaID, txtNapomena, txtVoziloID, dgvOprema, txtOpremaID, this);
        }

        private void btnIzaberiOpremu_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzaberiOpremu(dgvOprema, txtOpremaID, this);
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzmeniDeoVozila(txtVoziloIDDeo, txtDeoVozilaID, txtNapomena, txtOpremaID, dgvOprema, dgvDeloviVozila, this);
        }
    }
}
