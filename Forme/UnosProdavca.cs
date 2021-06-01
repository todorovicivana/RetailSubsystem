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
    public partial class UnosProdavca : Form
    {
        public UnosProdavca()
        {
            InitializeComponent();
        }

        private void UnosProdavca_Load(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.UcitajIDProdavca(txtProdavacID, this);
            txtImePrezimeProdavca.Select();
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KontrolerKI.Instance.SacuvajProdavca(txtProdavacID, txtImePrezimeProdavca, this);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
