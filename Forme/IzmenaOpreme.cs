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
    public partial class IzmenaOpreme : Form
    {
        private DataGridView dgvOprema;

        public IzmenaOpreme()
        {
            InitializeComponent();
        }

        public IzmenaOpreme(DataGridView dgvOprema)
        {
            InitializeComponent();
            this.dgvOprema = dgvOprema;
        }

        private void IzmenaOpreme_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajOdabranuOpremu(dgvOprema, txtOpremaID, txtNazivOpreme, txtOpisOpreme, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            KontrolerKI.KontrolerKI.Instance.IzmeniOpremu(txtOpremaID, txtNazivOpreme, txtOpisOpreme, dgvOprema, this);
        }
    }
}
