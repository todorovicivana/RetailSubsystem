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
    public partial class PrikazParticija : Form
    {
        public PrikazParticija()
        {
            InitializeComponent();
        }

        private void PrikazParticija_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajParticije(dgvParticije, this);
           
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSveUgovoreZaOdabranuParticiju(dgvUgovor, dgvParticije, this);
        }
    }
}
