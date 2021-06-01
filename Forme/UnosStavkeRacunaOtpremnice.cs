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
    public partial class UnosStavkeRacunaOtpremnice : Form
    {
        private DataGridView dgvStavkeRacunaOtpremnice;
        private TextBox txtRacunOtpremnicaID;

        public UnosStavkeRacunaOtpremnice()
        {
           
        }


        public UnosStavkeRacunaOtpremnice(TextBox txtRacunOtpremnicaID, DataGridView dgvStavkeRacunaOtpremnice)
        {
            InitializeComponent();
            this.txtRacunOtpremnicaID = txtRacunOtpremnicaID;
            this.dgvStavkeRacunaOtpremnice = dgvStavkeRacunaOtpremnice;
        }

        public DataGridView DgvStavkeRacunaOtpremnice { get; }

        private void UnosStavkeRacunaOtpremnice_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajSvaVozila(dgvVozilo, this);
            KontrolerKI.KontrolerKI.Instance.PostaviIDRacunOtpremnice(txtRacunOtpremnicaID,txtRacunOtpremnicaIDStavka, this);
        }

        private void btnIzaberiVozilo_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzaberiVozilo(dgvVozilo, txtVoziloID, dgvOprema, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.DodajStavkuRacunOtpremnice(dgvStavkeRacunaOtpremnice, dgvVozilo, txtRacunOtpremnicaIDStavka, txtKolicina, txtVoziloID, this);
        }
    }
}
