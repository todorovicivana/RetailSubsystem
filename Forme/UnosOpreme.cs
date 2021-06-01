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
    public partial class UnosOpreme : Form
    {
        public UnosOpreme()
        {
            InitializeComponent();
        }

        private void UnosOpreme_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajIDOpreme(txtOpremaID, this);
            txtNazivOpreme.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.SacuvajOpremu(txtOpremaID, txtNazivOpreme, txtOpisOpreme, this);
        }
    }
}
