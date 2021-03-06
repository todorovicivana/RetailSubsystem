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
    public partial class PrikazRacunOtpremnice : Form
    {
        public PrikazRacunOtpremnice()
        {
            InitializeComponent();
        }

        private void PrikazRacunOtpremnice_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajRacunOtpremniceUDataGrid(dgvRacunOtpremnice, this);
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

            if (txtKriterijum.Text == "")
            {
                MessageBox.Show("Unesite kriterijum pretrage!");
                return;
            }
            else
            {
                KontrolerKI.KontrolerKI.Instance.UcitajRacunOtpremniceZaKriterijum(dgvRacunOtpremnice, txtKriterijum.Text, this);
            }
        }

        private void txtKriterijum_TextChanged(object sender, EventArgs e)
        {
            if (txtKriterijum.Text == "")
            {
                KontrolerKI.KontrolerKI.Instance.UcitajRacunOtpremniceUDataGrid(dgvRacunOtpremnice, this);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.ObrisiRacunOtpremnicu(dgvRacunOtpremnice, this);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            new IzmenaRacunOtpremnice(dgvRacunOtpremnice).ShowDialog();
        }
    }
}
