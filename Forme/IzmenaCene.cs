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
    public partial class IzmenaCene : Form
    {
        private DataGridView dgvCene;

        public IzmenaCene()
        {
           
        }

        public IzmenaCene(DataGridView dgvCene)
        {
            InitializeComponent();
            this.dgvCene = dgvCene;
        }

        private void IzmenaCene_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.PopuniCMBValuta(cmbValuta, this);
            KontrolerKI.KontrolerKI.Instance.UcitajVozilaUDataGrid(dgvVozila, this);
            KontrolerKI.KontrolerKI.Instance.UcitajOdabranuCenu(dgvCene, txtVoziloIDCena, txtCenaVozilaID, txtIznos, cmbValuta, txtNazivVozila, this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.IzmeniCenu(txtVoziloIDCena, txtCenaVozilaID, txtIznos, cmbValuta, txtNazivVozila, dgvCene, this);
        }
    }
}
