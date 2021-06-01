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
    public partial class IzmenaStavkeRacunOtpremnice : Form
    {
       
        private DataGridView dgvStavkeRacunaOtpremnice;
        private TextBox txtRacunOtpremnicaID;

        public IzmenaStavkeRacunOtpremnice()
        {
            
        }

        public IzmenaStavkeRacunOtpremnice(DataGridView dgvStavkeRacunaOtpremnice, TextBox txtRacunOtpremnicaID)
        {
            InitializeComponent();
            this.dgvStavkeRacunaOtpremnice = dgvStavkeRacunaOtpremnice;
            this.txtRacunOtpremnicaID = txtRacunOtpremnicaID;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IzmenaStavkeRacunOtpremnice_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PostaviIDRacunOtpremnice(txtRacunOtpremnicaID, txtRacunOtpremnicaIDStavka, this);
            KontrolerKI.KontrolerKI.Instance.UcitajSvaVozila(dgvVozilo, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabranuStavkuRacunOtpremnice(dgvStavkeRacunaOtpremnice,txtStavkaRacunOtpremniceID, txtKolicina, txtVoziloID, dgvVozilo, dgvOprema, this);
        }

        private void btnIzaberiVozilo_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzaberiVozilo(dgvVozilo, txtVoziloID, dgvOprema, this);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzmeniStavkuRacunOtpremnice(txtRacunOtpremnicaIDStavka, txtStavkaRacunOtpremniceID, txtKolicina, txtVoziloID, dgvVozilo, dgvStavkeRacunaOtpremnice, this);
        }
    }
}
