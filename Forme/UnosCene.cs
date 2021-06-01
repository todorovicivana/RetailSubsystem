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
    public partial class UnosCene : Form
    {
        public UnosCene()
        {
            InitializeComponent();
        }

       

        private void UnosCene_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PopuniCMBValuta(cmbValuta, this);
            KontrolerKI.KontrolerKI.Instance.UcitajVozilaUDataGrid(dgvVozila, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.DodajCenu(txtVoziloIDCena, txtIznos, cmbValuta, this);
        }
    }
}
