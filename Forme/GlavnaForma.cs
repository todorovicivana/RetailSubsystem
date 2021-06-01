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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void racunOtpremnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ponudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unosPredracunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosPredracuna().ShowDialog();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {

        }

        private void prikazIIzmenaPredracunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrikazPredracuna().ShowDialog();
        }

        private void unosRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosRacunOtpremnice().ShowDialog();
        }

        private void prikazIzmenaBrisanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrikazRacunOtpremnice().ShowDialog();
        }

        private void prikazIzmenaBrisanjeUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrikazUgovora().ShowDialog();
        }

        private void opremaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unosUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosUgovora().ShowDialog();
        }

        private void ugovorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prikazParticijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrikazParticija().ShowDialog();
        }

        private void unosProdavcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosProdavca().ShowDialog();
        }

        private void prikazIzmenaBrisanjeProdavcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrikazProdavca().ShowDialog();
        }

        private void unosPonudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosPonude().ShowDialog();
        }

        private void prikazIzmenaBrisanjePonudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrikazPonude().ShowDialog();
        }

        private void unosVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosVozila().ShowDialog();
        }

        private void unosOpremeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosOpreme().ShowDialog();
        }

        private void prikazIzmenaBrisanjeOpremeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrikazOpreme().ShowDialog();
        }

        private void prikazIzmenaBrisanjeVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrikazVozila().ShowDialog();
        }

        private void unosCeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosCene().ShowDialog();
        }

        private void prikazIzmenaBrisanjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PrikazCene().ShowDialog();
        }
    }
}
