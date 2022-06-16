using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;
using Server;

namespace KontrolerKI
{
    public class KontrolerKI
    {
        private static KontrolerKI _instance;

        private Kupac kupac = new Kupac();
        private Prodavac prodavac = new Prodavac();
        private Oprema oprema = new Oprema();
        private DeoVozila deoVozila = new DeoVozila();
        private CenaVozila cenaVozila = new CenaVozila();
        private Ponuda ponuda;
        private Predracun predracun;
        private StavkaPredracuna stavkaPredracuna = new StavkaPredracuna();
        private StavkaPonude stavkaPonude = new StavkaPonude();
        private ClanUgovora clanUgovora = new ClanUgovora();
        private RacunOtpremnica racunOtpremnica;
        private Vozilo vozilo;
        private Ugovor ugovor;
        private StavkaRacunaOtpremnice stavkaRacunaOtpremnice = new StavkaRacunaOtpremnice();
        private Narudzbenica narudzbenica = new Narudzbenica();
        private Particije part = new Particije();
        BindingList<StavkaPredracuna> listaStavki;
        BindingList<StavkaRacunaOtpremnice> listaStavkiRacunaOtpremnice;
        BindingList<StavkaPonude> listaStavkiPonude;
        BindingList<DeoVozila> listaDelova;
        BindingList<CenaVozila> listaC = new BindingList<CenaVozila>();
        BindingList<ClanUgovora> listaClanova;

        private KontrolerKI()
        {

        }
        public static KontrolerKI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KontrolerKI();
                }
                return _instance;
            }
        }

        public void UcitajSveCene(DataGridView dgvCene, Form prikazCene)
        {

            try
            {
                dgvCene.DataSource = new BindingList<CenaVozila>(Broker.dajSesiju().ucitajSveCene());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita cene!\n" + ex.Message);
                prikazCene.Close();
                return;
            }
        }

        public void UcitajOdabranuCenu(DataGridView dgvCene, TextBox txtVoziloIDCena, TextBox txtCenaVozilaID, TextBox txtIznos, ComboBox cmbValuta, TextBox txtNazivVozila, Form izmenaCene)
        {

            try
            {
                cenaVozila = (CenaVozila)dgvCene.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite cenu vozila!");
                return;

            }

            txtVoziloIDCena.Text = cenaVozila.VoziloID.ToString();
            txtCenaVozilaID.Text = cenaVozila.CenaVozilaID.ToString();
            txtIznos.Text = cenaVozila.Iznos.ToString();
            if (cenaVozila.Valuta == "RSD")
            {
                cmbValuta.SelectedIndex = 0;
            }
            else
            {
                cmbValuta.SelectedIndex = 1;
            }
            txtNazivVozila.Text = cenaVozila.NazivVozila;
        }

        public void IzmeniCenu(TextBox txtVoziloIDCena, TextBox txtCenaVozilaID, TextBox txtIznos, ComboBox cmbValuta, TextBox txtNazivVozila, DataGridView dgvCene, Form izmenaCene)
        {
            if (string.IsNullOrWhiteSpace(txtVoziloIDCena.Text) || string.IsNullOrWhiteSpace(txtIznos.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            CenaVozila cenaVozilaStara = (CenaVozila)dgvCene.CurrentRow.DataBoundItem;
            int stariIDVozila = cenaVozilaStara.VoziloID;
            string stariNazivVozila = cenaVozilaStara.NazivVozila;

            cenaVozila = new CenaVozila();
            cenaVozila.CenaVozilaID = Convert.ToInt32(txtCenaVozilaID.Text);
           
            if (txtVoziloIDCena.Text != "" && (Broker.dajSesiju().postojiIDVozila(Convert.ToInt32(txtVoziloIDCena.Text))))
            {
                try
                {
                    cenaVozila.VoziloID = Convert.ToInt32(txtVoziloIDCena.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Unesite VoziloID!");
                    return;
                }
            }

            try
            {
                cenaVozila.Iznos = Convert.ToDouble(txtIznos.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite iznos!");
                return;
            }

            cenaVozila.Valuta = (string)cmbValuta.SelectedItem;
            if (cenaVozila.Valuta == "")
            {
                MessageBox.Show("Izaberite valutu!");
                return;
            }

            cenaVozila.NazivVozila = txtNazivVozila.Text;
            if(cenaVozila.NazivVozila=="")
            {
                MessageBox.Show("Nedostaje naziv vozila!");
                return;
            }

            if(cenaVozila.VoziloID!=stariIDVozila)
            {
                string rez = Broker.dajSesiju().izmeniCenu(cenaVozila);
                MessageBox.Show(rez);
                txtVoziloIDCena.Text = stariIDVozila.ToString();
                return;
            }
            else if(cenaVozila.NazivVozila != stariNazivVozila)
            {
                string rez = Broker.dajSesiju().izmeniCenu(cenaVozila);
                MessageBox.Show(rez);
                txtNazivVozila.Text = stariNazivVozila;
                return;
            }
            else
            {
                string rez = Broker.dajSesiju().izmeniCenu2(cenaVozila);
                MessageBox.Show(rez);
                izmenaCene.Close();
                dgvCene.DataSource = new BindingList<CenaVozila>(Broker.dajSesiju().ucitajSveCene());
                return;
               
            }
           
           
        }

        public void UcitajCeneZaKriterijum(DataGridView dgvCene, string kriterijum, Form prikazCene)
        {
            try
            {
                dgvCene.DataSource = new BindingList<CenaVozila>(Broker.dajSesiju().ucitajCeneZaKriterijum(kriterijum));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita cene za dati kriterijum!\n" + ex.Message);
                prikazCene.Close();
                return;
            }
        }

        public void ObrisiCenu(DataGridView dgvCene, Form prikazCene)
        {

            try
            {
                cenaVozila = (CenaVozila)dgvCene.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite cenu!");
                return;
            }

            string rez = Broker.dajSesiju().obrisiCenu(cenaVozila);
            MessageBox.Show(rez);
            UcitajSveCene(dgvCene, prikazCene);
        }

        

        public void UcitajVozilaUDataGrid(DataGridView dgvVozila, Form prikazVozila)
        {
            try
            {
                dgvVozila.DataSource = new BindingList<Vozilo>(Broker.dajSesiju().ucitajSvaVozila());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita vozila!\n" + ex.Message);
                prikazVozila.Close();
                return;
            }
        }

        public void DodajCenu(TextBox txtVoziloIDCena, TextBox txtIznos, ComboBox cmbValuta, Form unosCene)
        {
            if (string.IsNullOrWhiteSpace(txtVoziloIDCena.Text) || string.IsNullOrWhiteSpace(txtIznos.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            cenaVozila = new CenaVozila();

            if (txtVoziloIDCena.Text != "")
            {
                try
                {
                    cenaVozila.VoziloID = Convert.ToInt32(txtVoziloIDCena.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Unesite VoziloID!");
                    return;
                }
            }
            try
            {
                cenaVozila.Iznos = Convert.ToDouble(txtIznos.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite iznos!");
                return;
            }

            cenaVozila.Valuta = (string)cmbValuta.SelectedItem;
            if (cenaVozila.Valuta == "")
            {
                MessageBox.Show("Izaberite valutu!");
                return;
            }


            string rez = Broker.dajSesiju().sacuvajCenuVozila(cenaVozila);
            if (rez == "Sistem je uspešno sačuvao cenu vozila!")
            {
                MessageBox.Show(rez + " Naziv vozila: " + Broker.dajSesiju().vratiNazivVozilaZaOdredjenuCenu(cenaVozila.VoziloID));
                unosCene.Close();
                return;
            }
            else
            {
                MessageBox.Show(rez);
                txtVoziloIDCena.Clear();
                return;
            }
        
        }

        public void PopuniCMBValuta(ComboBox cmbValuta, Form unosCene)
        {
            BindingList<string> listaValuta = new BindingList<string>();
            try
            {

                listaValuta.Add("RSD");
                listaValuta.Add("EUR");

                foreach (string v in listaValuta)
                {
                    cmbValuta.Items.Add(v);
                }
                cmbValuta.Text = "Izaberite valutu!";
                cmbValuta.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita valute!\n" + ex.Message);
                unosCene.Close();
                return;
            }
        }

        public void UcitajOdabraniClanUgovora(DataGridView dgvDeloviVozila, TextBox txtDeoVozilaID, TextBox txtNapomena, TextBox txtVoziloID, DataGridView dgvOprema, TextBox txtOpremaID, Form izmenaDelaVozila)
        {
            try
            {
                deoVozila = (DeoVozila)dgvDeloviVozila.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite deo vozila!");
                return;

            }

            txtDeoVozilaID.Text = deoVozila.DeoVozilaID.ToString();
            txtVoziloID.Text = deoVozila.VoziloID.ToString();
            txtNapomena.Text = deoVozila.Napomena;
            txtNapomena.Select();
            txtOpremaID.Text = deoVozila.Oprema.OpremaID.ToString();

         
        }

        public void IzmeniVozilo(TextBox txtVoziloID, TextBox txtNazivVozila, TextBox txtNazivModela, TextBox txtBrojVrata, TextBox txtSnagaMotora, ComboBox cmbVrstaMenjaca, TextBox txtTipVozila, DataGridView dgvVozila, Form izmenaVozila)
        {

            if (string.IsNullOrWhiteSpace(txtNazivVozila.Text) || string.IsNullOrWhiteSpace(txtNazivModela.Text) || string.IsNullOrWhiteSpace(txtBrojVrata.Text) || string.IsNullOrWhiteSpace(txtSnagaMotora.Text) || string.IsNullOrWhiteSpace(txtTipVozila.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            Vozilo vozilo = new Vozilo();

            vozilo.VoziloID = Convert.ToInt32(txtVoziloID.Text);

            vozilo.NazivVozila = txtNazivVozila.Text;
            if (vozilo.NazivVozila == "")
            {
                MessageBox.Show("Unesite naziv vozila!");
                return;
            }

            vozilo.NazivModela = txtNazivModela.Text;
            if (vozilo.NazivModela == "")
            {
                MessageBox.Show("Unesite naziv modela!");
                return;
            }

            try
            {
                vozilo.BrojVrata = Convert.ToInt32(txtBrojVrata.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite validan broj vrata!");
                txtBrojVrata.Focus();
                return;
            }

            if (vozilo.BrojVrata <= 0)
            {
                MessageBox.Show("Broj vrata mora biti pozitivan broj!");
                txtBrojVrata.Focus();
                return;
            }

            try
            {
                vozilo.SnagaMotora = Convert.ToInt32(txtSnagaMotora.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite validnu snagu motora!");
                txtSnagaMotora.Focus();
                return;
            }

            if (vozilo.SnagaMotora <= 0)
            {
                MessageBox.Show("Snaga motora mora biti pozitivan broj!");
                txtSnagaMotora.Focus();
                return;
            }

            vozilo.VrstaMenjaca = (string)cmbVrstaMenjaca.SelectedItem;
            if (vozilo.VrstaMenjaca == null)
            {
                MessageBox.Show("Izaberite vrstu menjača!");
                return;
            }

            string uneto = txtTipVozila.Text;

            bool proveri(string unet)
            {
                unet = uneto;
                foreach (char c in unet)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            if (txtTipVozila.Text == "")
            {
                MessageBox.Show("Unesite tip vozila!");
                return;
            }
            else if (proveri(txtTipVozila.ToString()) == true)
            {
                MessageBox.Show("Tip vozila može sadržati samo slova!");
                return;
            }
            else
            {
                vozilo.TipVozila = txtTipVozila.Text;
            }


            vozilo.ListaDelovaVozila = new BindingList<DeoVozila>(Broker.dajSesiju().ucitajDeloveVozilaZaOdredjenoVozilo(vozilo.VoziloID));
            if (vozilo.ListaDelovaVozila.Count < 1)
            {
                MessageBox.Show("Vozilo mora imati makar 1 deo!\n");
                return;
            }

            string rez=Broker.dajSesiju().izmeniVozilo(vozilo);
            MessageBox.Show(rez);
            izmenaVozila.Close();
            dgvVozila.DataSource = new BindingList<Vozilo>(Broker.dajSesiju().ucitajSvaVozila());
        }

        public void IzmeniDeoVozila(TextBox txtVoziloIDDeo, TextBox txtDeoVozilaID, TextBox txtNapomena, TextBox txtOpremaID, DataGridView dgvOprema, DataGridView dgvDeloviVozila, Form izmenaDelaVozila)
        {
            if (string.IsNullOrWhiteSpace(txtNapomena.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            deoVozila = new DeoVozila();

            deoVozila.VoziloID = Convert.ToInt32(txtVoziloIDDeo.Text);
            deoVozila.DeoVozilaID = Convert.ToInt32(txtDeoVozilaID.Text);

            deoVozila.Napomena = txtNapomena.Text;
            if (deoVozila.Napomena == "")
            {
                MessageBox.Show("Unesite napomenu!");
                return;
            }

            try
            {
                oprema = (Oprema)dgvOprema.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Izaberite željenu opremu!");
                return;
            }

            if (txtOpremaID.Text == "")
            {
                MessageBox.Show("Izaberite željenu opremu!");
                return;
            }
            else
            {
                deoVozila.Oprema = oprema;
                deoVozila.Oprema.OpremaID = Convert.ToInt32(txtOpremaID.Text);
            }

            string rez=Broker.dajSesiju().izmeniDeoVozila(deoVozila);
            MessageBox.Show(rez);
            dgvDeloviVozila.DataSource = Broker.dajSesiju().ucitajDeloveVozilaZaOdredjenoVozilo(deoVozila.VoziloID);
            izmenaDelaVozila.Close();
        }

        public void UcitajOdabranoVozilo(DataGridView dgvVozila, DataGridView dgvDeloviVozila, TextBox txtVoziloID, TextBox txtNazivVozila, TextBox txtNazivModela, TextBox txtBrojVrata, TextBox txtSnagaMotora, ComboBox cmbVrstaMenjaca, TextBox txtTipVozila, Form izmenaVozila)
        {

            try
            {
                vozilo = (Vozilo)dgvVozila.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite vozilo!");
                return;
            }

            txtVoziloID.Text = vozilo.VoziloID.ToString();
            txtNazivVozila.Text = vozilo.NazivVozila;
            txtNazivModela.Text = vozilo.NazivModela;
            txtBrojVrata.Text = vozilo.BrojVrata.ToString();
            txtSnagaMotora.Text = vozilo.SnagaMotora.ToString();
            txtTipVozila.Text = vozilo.TipVozila;
            if (vozilo.VrstaMenjaca == "Manuelni menjac")
            {
                cmbVrstaMenjaca.SelectedIndex = 0;
            }
            else
            {
                cmbVrstaMenjaca.SelectedIndex = 1;
            }
            dgvDeloviVozila.DataSource = new BindingList<DeoVozila>(Broker.dajSesiju().ucitajDeloveVozilaZaOdredjenoVozilo(vozilo.VoziloID));
        }

        public void ObrisiDeoVozila(DataGridView dgvDeloviVozila, Button btnObrisi, Form izmenaVozila)
        {

            try
            {
                deoVozila = (DeoVozila)dgvDeloviVozila.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite deo vozila!\n");
                return;
            }

            Broker.dajSesiju().obrisiDeoVozila(deoVozila);
            MessageBox.Show("Sistem je uspešno obrisao deo vozila!");
            dgvDeloviVozila.DataSource = Broker.dajSesiju().ucitajDeloveVozilaZaOdredjenoVozilo(deoVozila.VoziloID);
        }

        public void UcitajVozilaZaKriterijum(DataGridView dgvVozila, string kriterijum, Form prikazVozila)
        {
            try
            {
                dgvVozila.DataSource = new BindingList<Vozilo>(Broker.dajSesiju().ucitajVozilaZaKriterijum(kriterijum));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita vozila za dati kriterijum!\n" + ex.Message);
                prikazVozila.Close();
                return;
            }
        }

        public void ObrisiVozilo(DataGridView dgvVozila, Form prikazVozila)
        {
            try
            {
                vozilo = (Vozilo)dgvVozila.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite vozilo!");
                return;
            }

            try
            {

                if (vozilo.ListaDelovaVozila.Count != 0)
                Broker.dajSesiju().ObrisiDeloveVozila(vozilo);

                Broker.dajSesiju().ObrisiVozilo(vozilo);


                UcitajVozilaUDataGrid(dgvVozila, prikazVozila);
                MessageBox.Show("Sistem je uspešno obrisao vozilo i delove vozila!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da obriše vozilo!\n" + ex.Message);
                prikazVozila.Close();
                return;
            }
        }

      

        public void SacuvajOpremu(TextBox txtOpremaID, TextBox txtNazivOpreme, TextBox txtOpisOpreme, Form unosOpreme)
        {

            if (string.IsNullOrWhiteSpace(txtNazivOpreme.Text) || string.IsNullOrWhiteSpace(txtOpisOpreme.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            oprema = new Oprema();

            oprema.OpremaID = Convert.ToInt32(txtOpremaID.Text);

            oprema.NazivOpreme = txtNazivOpreme.Text;
            if (oprema.NazivOpreme == "")
            {
                MessageBox.Show("Unesite naziv opreme!");
                return;
            }

            oprema.Opis = txtOpisOpreme.Text;
            if (oprema.Opis == "")
            {
                MessageBox.Show("Unesite opis!");
                return;
            }

            string rez = Broker.dajSesiju().sacuvajOpremu(oprema);
            MessageBox.Show(rez);
            unosOpreme.Close();
            return;
        }

        public void ObrisiPredracun(DataGridView dgvPredracuni, Form prikazPredracuna)
        {
            try
            {
                predracun = (Predracun)dgvPredracuni.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite predračun!");
                return;
            }

            try
            {


                if (predracun.ListaStavki.Count != 0)
                Broker.dajSesiju().ObrisiStavkePredracuna(predracun);

                Broker.dajSesiju().ObrisiPredracun(predracun);

             
                UcitajPredracuneUDataGrid(dgvPredracuni, prikazPredracuna);
                MessageBox.Show("Sistem je uspešno obrisao predračun i stavke predračuna!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da obriše predračun!\n" + ex.Message);
                prikazPredracuna.Close();
                return;
            }
        }

        public void IzmeniStavkuPredracuna(TextBox txtPredracunIDStavka, TextBox txtStavkaPredracunaID, TextBox txtKolicina, TextBox txtVoziloID, DataGridView dgvVozilo, DataGridView dgvStavkePredracuna, TextBox txtUkupanIznos, Form izmenaStavkePredracuna)
        {

            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            stavkaPredracuna = new StavkaPredracuna();

            stavkaPredracuna.PredracunID = Convert.ToInt32(txtPredracunIDStavka.Text);
            stavkaPredracuna.StavkaPredracunaID = Convert.ToInt32(txtStavkaPredracunaID.Text);

            try
            {
                stavkaPredracuna.Kolicina = Convert.ToInt32(txtKolicina.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neispravno uneta količina! " + ex.Message);
                return;
            }

            if (stavkaPredracuna.Kolicina < 1)
            {
                MessageBox.Show("Kolicina mora biti pozitivna!");
                return;
            }

            try
            {
                vozilo = (Vozilo)dgvVozilo.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }

            if (txtVoziloID.Text == "")
            {
                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }
            else
            {
                stavkaPredracuna.Vozilo = vozilo;
                stavkaPredracuna.Vozilo.VoziloID = Convert.ToInt32(txtVoziloID.Text);
            }

            Broker.dajSesiju().izmeniStavkuPredracuna(stavkaPredracuna);
            MessageBox.Show("Stavka predračuna je izmenjena!\n");
            dgvStavkePredracuna.DataSource = Broker.dajSesiju().ucitajStavkePredracunaZaOdredjeniPredracun(stavkaPredracuna.PredracunID);
            txtUkupanIznos.Text = Broker.dajSesiju().ucitajUkupanIznosZaOdredjeniPredracun(stavkaPredracuna.PredracunID).ToString();
            izmenaStavkePredracuna.Close();

        }

        public void ObrisiStavkuPredracuna(DataGridView dgvStavkePredracuna, Button btnObrisi, TextBox txtUkupanIznos , Form izmenaPredracuna)
        {

            try
            {
                stavkaPredracuna = (StavkaPredracuna)dgvStavkePredracuna.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite stavku predračuna!\n");
                return;
            }

            Broker.dajSesiju().obrisiStavkuPredracuna(stavkaPredracuna);
            MessageBox.Show("Sistem je uspešno obrisao stavku predračuna!");
            dgvStavkePredracuna.DataSource = Broker.dajSesiju().ucitajStavkePredracunaZaOdredjeniPredracun(stavkaPredracuna.PredracunID);
            try
            {
                txtUkupanIznos.Text = Broker.dajSesiju().ucitajUkupanIznosZaOdredjeniPredracun(stavkaPredracuna.PredracunID).ToString();
            }
            catch(Exception)
            {
                txtUkupanIznos.Text = "";
            }

        }

        public void UcitajOdabranuStavkuPredracuna(DataGridView dgvStavkePredracuna, TextBox txtStavkaPredracunaID, TextBox txtKolicina, TextBox txtVoziloID, DataGridView dgvVozilo, DataGridView dgvOprema, Form izmenaStavkePredracuna)
        {
            try
            {
                stavkaPredracuna = (StavkaPredracuna)dgvStavkePredracuna.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite stavku predračuna!");
                return;

            }

            txtStavkaPredracunaID.Text = stavkaPredracuna.StavkaPredracunaID.ToString();
            txtVoziloID.Text = stavkaPredracuna.Vozilo.VoziloID.ToString();
            txtKolicina.Text = stavkaPredracuna.Kolicina.ToString();
            txtKolicina.Select();
            dgvOprema.DataSource = new BindingList<Oprema>(Broker.dajSesiju().ucitajListuOpremeZaOdredjenoVozilo(stavkaPredracuna.Vozilo.VoziloID));
        }

        public void IzmeniPredracun(TextBox txtPredracunID, TextBox txtBrojPredracuna, TextBox txtDatumIzdavanja, TextBox txtDatumPrometa, ComboBox cmbNacinPlacanja, ComboBox cmbUgovor, ComboBox cmbProdavac, TextBox txtKupac, TextBox txtUkupanIznos, DataGridView dgvPredracuni, Form izmenaPredracuna)
        {


            if (string.IsNullOrWhiteSpace(txtBrojPredracuna.Text) || string.IsNullOrWhiteSpace(txtDatumIzdavanja.Text) || string.IsNullOrWhiteSpace(txtDatumPrometa.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            Predracun predracun = new Predracun();

            predracun.PredracunID = Convert.ToInt32(txtPredracunID.Text);

            try
            {
                BrojPredracuna bp = new BrojPredracuna();
                bp.Godina = Convert.ToInt32(txtBrojPredracuna.Text.Split('/')[0]);
                bp.RedniBroj = Convert.ToInt32(txtBrojPredracuna.Text.Split('/')[1]);
                predracun.BrojPredracuna = bp;
            }
            catch (Exception)
            {
                MessageBox.Show("Neispravno unet broj predračuna!\nIspravan format: (godina/redni broj)!\n");
                return;
            }


            predracun.Ugovor = (Ugovor)cmbUgovor.SelectedItem;
            if (predracun.Ugovor == null)
            {
                MessageBox.Show("Izaberite ugovor!\n");
                return;
            }
            else
            {
                predracun.Kupac = new Kupac();
                predracun.Kupac.KupacJMBG = predracun.Ugovor.Kupac.KupacJMBG;
            }


            try
            {
                predracun.DatumIzdavanja = DateTime.ParseExact(txtDatumIzdavanja.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum izdavanja u formatu dd.MM.yyyy!");
                return;
            }

            try
            {
                predracun.DatumPrometa = DateTime.ParseExact(txtDatumPrometa.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum prometa u formatu dd.MM.yyyy!");
                return;
            }

            predracun.NacinPlacanja = (string)cmbNacinPlacanja.SelectedItem;
            if (predracun.NacinPlacanja == null)
            {
                MessageBox.Show("Izaberite način plaćanja!\n");
                return;
            }

            predracun.Prodavac = (Prodavac)cmbProdavac.SelectedItem;
            if (predracun.Prodavac == null)
            {
                MessageBox.Show("Izaberite prodavca!");
                return;
            }

            predracun.ListaStavki = new BindingList<StavkaPredracuna>(Broker.dajSesiju().ucitajStavkePredracunaZaOdredjeniPredracun(predracun.PredracunID));
            if (predracun.ListaStavki.Count < 1)
            {
                MessageBox.Show("Predračun mora imati makar 1 stavku!\n");
                return;
            }

            double ukupanIznosIzPolja = Convert.ToDouble(txtUkupanIznos.Text);
            double ukupanIznosNakonIzmene = Broker.dajSesiju().ucitajUkupanIznosZaOdredjeniPredracun(predracun.PredracunID); 
            if (ukupanIznosNakonIzmene!=ukupanIznosIzPolja)
            {
                string rez = Broker.dajSesiju().izmeniPredracunUkupanIznos(predracun, ukupanIznosIzPolja);
                MessageBox.Show(rez);
                txtUkupanIznos.Text = Broker.dajSesiju().ucitajUkupanIznosZaOdredjeniPredracun(predracun.PredracunID).ToString();
                return;
            }
            else
            {
                try
                {
                    Broker.dajSesiju().izmeniPredracun(predracun);
                    MessageBox.Show("Sistem je izmenio predračun!");
                    izmenaPredracuna.Close();
                    dgvPredracuni.DataSource = new BindingList<Predracun>(Broker.dajSesiju().ucitajPredracune());
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da izmeni predračun!\n" + ex.Message);
                    izmenaPredracuna.Close();
                    return;
                }

            }
        }

        public void UcitajOdabraniPredracun(DataGridView dgvPredracuni, DataGridView dgvStavkePredracuna, TextBox txtPredracunID, TextBox txtBrojPredracuna, TextBox txtDatumIzdavanja, TextBox txtDatumPrometa, ComboBox cmbNacinPlacanja, ComboBox cmbProdavac, ComboBox cmbUgovor, TextBox txtKupac, TextBox txtUkupanIznos, Form izmenaPredracuna)
        {

            try
            {
                predracun = (Predracun)dgvPredracuni.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite predračun!");
                return;
            }

            txtPredracunID.Text = predracun.PredracunID.ToString();
            txtBrojPredracuna.Text = predracun.BrojPredracuna.ToString();
            txtDatumIzdavanja.Text = predracun.DatumIzdavanja.ToString("dd.MM.yyyy");
            txtDatumPrometa.Text = predracun.DatumPrometa.ToString("dd.MM.yyyy");
            cmbUgovor.SelectedIndex = predracun.Ugovor.UgovorID - 1;
            if (predracun.NacinPlacanja == "Bezgotovinsko placanje")
            {
                cmbNacinPlacanja.SelectedIndex = 0;
            }
            else if (predracun.NacinPlacanja == "Gotovinsko placanje")
            {
                cmbNacinPlacanja.SelectedIndex = 1;
            }
            else if (predracun.NacinPlacanja == "Platna kartica")
            {
                cmbNacinPlacanja.SelectedIndex = 2;
            }
            cmbProdavac.SelectedIndex = predracun.Prodavac.ProdavacID - 1;
            txtKupac.Text = predracun.Kupac.ImePrezimeKupca;
            txtUkupanIznos.Text = Broker.dajSesiju().ucitajUkupanIznosZaOdredjeniPredracun(predracun.PredracunID).ToString();
            dgvStavkePredracuna.DataSource = new BindingList<StavkaPredracuna>(Broker.dajSesiju().ucitajStavkePredracunaZaOdredjeniPredracun(predracun.PredracunID));
        }

        public void PostaviIDPredracuna(TextBox txtPredracunID, TextBox txtPredracunIDStavka, Form unosStavkePredracuna)
        {
            try
            {
                txtPredracunIDStavka.Text = txtPredracunID.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da postavi PredračunID!\n" + ex.Message);
                unosStavkePredracuna.Close();
                return;
            }
        }

        public void IzmeniOpremu(TextBox txtOpremaID, TextBox txtNazivOpreme, TextBox txtOpisOpreme, DataGridView dgvOprema, Form izmenaOpreme)
        {
            if (string.IsNullOrWhiteSpace(txtNazivOpreme.Text) || string.IsNullOrWhiteSpace(txtOpisOpreme.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            oprema = new Oprema();

            oprema.OpremaID = Convert.ToInt32(txtOpremaID.Text);

            oprema.NazivOpreme = txtNazivOpreme.Text;
            if (oprema.NazivOpreme == "")
            {
                MessageBox.Show("Unesite naziv opreme!");
                return;
            }

            oprema.Opis = txtOpisOpreme.Text;
            if (oprema.Opis == "")
            {
                MessageBox.Show("Unesite opis!");
                return;
            }

            string rez = Broker.dajSesiju().izmeniOpremu(oprema);
            MessageBox.Show(rez);
            izmenaOpreme.Close();
            dgvOprema.DataSource = new BindingList<Oprema>(Broker.dajSesiju().ucitajSvuOpremu());
            return;
        }

        public void UcitajOdabranuOpremu(DataGridView dgvOprema, TextBox txtOpremaID, TextBox txtNazivOpreme, TextBox txtOpisOpreme, Form izmenaOpreme)
        {
            try
            {
                oprema = (Oprema)dgvOprema.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite opremu!");
                return;

            }

            txtOpremaID.Text = oprema.OpremaID.ToString();
            txtNazivOpreme.Text = oprema.NazivOpreme;
            txtOpisOpreme.Text = oprema.Opis;

        }

        public void ObrisiOpremu(DataGridView dgvOprema, Form prikazOpreme)
        {

            try
            {
                oprema = (Oprema)dgvOprema.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite opremu!");
                return;
            }

            string rez = Broker.dajSesiju().obrisiOpremu(oprema);
            MessageBox.Show(rez);
            UcitajSvuOpremu(dgvOprema, prikazOpreme);
        }

        public void UcitajOpremuZaKriterijum(DataGridView dgvOprema, string kriterijum, Form prikazOpreme)
        {
            try
            {
                dgvOprema.DataSource = new BindingList<Oprema>(Broker.dajSesiju().ucitajOpremuZaKriterijum(kriterijum));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita opremu za dati kriterijum!\n" + ex.Message);
                prikazOpreme.Close();
                return;
            }
        }

      

        public void UcitajIDOpreme(TextBox txtOpremaID, Form unosOpreme)
        {
            try
            {
                txtOpremaID.Text = Broker.dajSesiju().vratiIDOpreme().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita OpremaID!\n" + ex.Message);
                unosOpreme.Close();
                return;
            }
        }



        public void ObrisiDeoVozilaIzGrida(DataGridView dgvDeloviVozila, object btnObrisi, Form unosVozila)
        {
            try
            {
                deoVozila = (DeoVozila)dgvDeloviVozila.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite deo vozila!");
                return;
            }

            listaDelova.Remove(deoVozila);
        }

        public void SacuvajVozilo(TextBox txtVoziloID, TextBox txtNazivVozila, TextBox txtNazivModela, TextBox txtBrojVrata, TextBox txtSnagaMotora, ComboBox cmbVrstaMenjaca, TextBox txtTipVozila, Form unosVozila)
        {

            if (string.IsNullOrWhiteSpace(txtNazivVozila.Text) || string.IsNullOrWhiteSpace(txtNazivModela.Text) || string.IsNullOrWhiteSpace(txtBrojVrata.Text) || string.IsNullOrWhiteSpace(txtSnagaMotora.Text) || string.IsNullOrWhiteSpace(txtTipVozila.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            vozilo = new Vozilo();

            vozilo.VoziloID = Convert.ToInt32(txtVoziloID.Text);

            vozilo.NazivVozila = txtNazivVozila.Text;
            if (vozilo.NazivVozila == "")
            {
                MessageBox.Show("Unesite naziv vozila!");
                return;
            }

            vozilo.NazivModela = txtNazivModela.Text;
            if (vozilo.NazivModela == "")
            {
                MessageBox.Show("Unesite naziv modela!");
                return;
            }

            try
            {
                vozilo.BrojVrata = Convert.ToInt32(txtBrojVrata.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite validan broj vrata!");
                txtBrojVrata.Focus();
                return;
            }

            if (vozilo.BrojVrata <= 0)
            {
                MessageBox.Show("Broj vrata mora biti pozitivan broj!");
                txtBrojVrata.Focus();
                return;
            }

            try
            {
                vozilo.SnagaMotora = Convert.ToInt32(txtSnagaMotora.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite validnu snagu motora!");
                txtSnagaMotora.Focus();
                return;
            }

            if (vozilo.SnagaMotora <= 0)
            {
                MessageBox.Show("Snaga motora mora biti pozitivan broj!");
                txtSnagaMotora.Focus();
                return;
            }

            vozilo.VrstaMenjaca = (string)cmbVrstaMenjaca.SelectedItem;
            if (vozilo.VrstaMenjaca == null)
            {
                MessageBox.Show("Izaberite vrstu menjača!");
                return;
            }

            vozilo.TipVozila = txtTipVozila.Text;
            if (txtTipVozila.Text == "")
            {
                MessageBox.Show("Unesite tip vozila!");
                return;
            }
            
            vozilo.ListaDelovaVozila = new BindingList<DeoVozila>(listaDelova);

            if (vozilo.ListaDelovaVozila.Count < 1)
            {
                MessageBox.Show("Vozilo mora imati makar 1 deo!\n");
                return;
            }

            string rez = Broker.dajSesiju().sacuvajVozilo(vozilo);
            if (rez== "Sistem je uspešno sačuvao vozilo!")
            {
                MessageBox.Show(rez);
                unosVozila.Close();
                return;
            }
            else
            {
                MessageBox.Show(rez);
                txtTipVozila.Clear();
                return;
            }
           
          
        
        }

     
        public void PopuniCMBVrstaMenjaca(ComboBox cmbVrstaMenjaca, Form unosVozila)
        {
            BindingList<string> listaVrstaMenjaca = new BindingList<string>();
            try
            {

                listaVrstaMenjaca.Add("Manuelni menjac");
                listaVrstaMenjaca.Add("Automatski menjac");

                foreach (string vm in listaVrstaMenjaca)
                {
                    cmbVrstaMenjaca.Items.Add(vm);
                }
                cmbVrstaMenjaca.Text = "Izaberite vrstu menjača!";
                cmbVrstaMenjaca.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita vrste menjača!\n" + ex.Message);
                unosVozila.Close();
                return;
            }
        }

        public void DodajDeoVozila(DataGridView dgvDeloviVozila, DataGridView dgvOprema, TextBox txtVoziloIDDeo, TextBox txtNapomena, TextBox txtOpremaID, Form unosDelaVozila)
        {
            if (string.IsNullOrWhiteSpace(txtNapomena.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            deoVozila = new DeoVozila();

            deoVozila.VoziloID = Convert.ToInt32(txtVoziloIDDeo.Text);

            deoVozila.Napomena = txtNapomena.Text;
            if (deoVozila.Napomena == "")
            {
                MessageBox.Show("Unesite napomenu!");
                return;
            }

            try
            {
                oprema = (Oprema)dgvOprema.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Izaberite željenu opremu!");
                return;
            }

            if (txtOpremaID.Text == "")
            {
                MessageBox.Show("Izaberite željenu opremu!");
                return;
            }
            else
            {
                deoVozila.Oprema = oprema;
                deoVozila.Oprema.OpremaID = Convert.ToInt32(txtOpremaID.Text);
            }

            if (Broker.dajSesiju().postojiVoziloUBazi(deoVozila.VoziloID))
            {
                Broker.dajSesiju().sacuvajDeoVozila(deoVozila);
                dgvDeloviVozila.DataSource = Broker.dajSesiju().ucitajDeloveVozilaZaOdredjenoVozilo(deoVozila.VoziloID);
                MessageBox.Show("Sistem je uspešno sačuvao deo vozila!\n");
                unosDelaVozila.Close();
            }
            else
            {
                listaDelova.Add(deoVozila);
                dgvDeloviVozila.DataSource = listaDelova;
                MessageBox.Show("Deo vozila je dodat!\n");
                unosDelaVozila.Close();
            }
        }

        public void IzaberiOpremu(DataGridView dgvOprema, TextBox txtOpremaID, Form unosDelaVozila)
        {
            try
            {
                oprema = (Oprema)dgvOprema.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite opremu!");
                return;
            }

            txtOpremaID.Text = oprema.OpremaID.ToString();
        }

        public void PostaviIDVozila(TextBox txtVoziloID, TextBox txtVoziloIDDeo, Form unosDelaVozila)
        {
            try
            {
                txtVoziloIDDeo.Text = txtVoziloID.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da postavi VoziloID!\n" + ex.Message);
                unosDelaVozila.Close();
                return;
            }
        }

        public void UcitajSvuOpremu(DataGridView dgvOprema, Form unosDelaVozila)
        {
            try
            {
                dgvOprema.DataSource = new BindingList<Oprema>(Broker.dajSesiju().ucitajSvuOpremu());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita opremu!\n" + ex.Message);
                unosDelaVozila.Close();
                return;
            }
        }


        public void UcitajIDVozilaInicijalizujListu(TextBox txtVoziloID, Form unosVozila)
        {
            try
            {
                txtVoziloID.Text = Broker.dajSesiju().vratiIDVozila().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita VoziloID!\n" + ex.Message);
                unosVozila.Close();
                return;
            }

            vozilo = new Vozilo();
            listaDelova = new BindingList<DeoVozila>();
        }



        public void UcitajOdabranuPonudu(DataGridView dgvPonude, DataGridView dgvStavkePonude, TextBox txtPonudaID, TextBox txtBrojPonude, TextBox txtDatumOd, TextBox txtDatumDo, TextBox txtRokIsporuke, ComboBox cmbKatalog, ComboBox cmbKupac, ComboBox cmbProdavac, Form izmenaPonude)
        {
            try
            {
                ponuda = (Ponuda)dgvPonude.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite ponudu!");
                return;
            }

            txtPonudaID.Text = ponuda.PonudaID.ToString();
            txtBrojPonude.Text = ponuda.BrojPonude.ToString();
            txtDatumOd.Text = ponuda.DatumOd.ToString("dd.MM.yyyy");
            txtDatumDo.Text = ponuda.DatumDo.ToString("dd.MM.yyyy");
            txtRokIsporuke.Text = ponuda.RokIsporuke;
            cmbKatalog.SelectedIndex = ponuda.Katalog.KatalogID - 1;
            cmbProdavac.SelectedIndex = ponuda.Prodavac.ProdavacID - 1;
            foreach (Kupac k in cmbKupac.Items)
            {
                if (k.KupacJMBG.Equals(ponuda.Kupac.KupacJMBG))
                    cmbKupac.SelectedItem = k;
            }
            dgvStavkePonude.DataSource = new BindingList<StavkaPonude>(Broker.dajSesiju().ucitajStavkePonudeZaOdredjenuPonudu(ponuda.PonudaID));
        }

        public void IzmeniPonudu(TextBox txtPonudaID, TextBox txtDatumOd, TextBox txtDatumDo, TextBox txtBrojPonude, TextBox txtRokIsporuke, ComboBox cmbKatalog, ComboBox cmbProdavac, ComboBox cmbKupac, DataGridView dgvPonude, Form izmenaPonude)
        {

            if (string.IsNullOrWhiteSpace(txtBrojPonude.Text) || string.IsNullOrWhiteSpace(txtDatumOd.Text) || string.IsNullOrWhiteSpace(txtDatumDo.Text) || string.IsNullOrWhiteSpace(txtRokIsporuke.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            Ponuda ponuda = new Ponuda();

            ponuda.PonudaID = Convert.ToInt32(txtPonudaID.Text);

            string uneto = txtBrojPonude.Text;

            bool proveraBrojPonude(string unet)
            {
                unet = uneto;
                foreach (char c in unet)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            if (proveraBrojPonude(txtBrojPonude.ToString()) == true)
            {
                ponuda.BrojPonude = Convert.ToInt32(txtBrojPonude.Text);
            }
            else
            {
                MessageBox.Show("Unesite ispravno broj ponude!");
                return;
            }



            ponuda.Katalog = (Katalog)cmbKatalog.SelectedItem;
            if (ponuda.Katalog == null)
            {
                MessageBox.Show("Izaberite katalog!\n");
                return;
            }

            ponuda.Prodavac = (Prodavac)cmbProdavac.SelectedItem;
            if (ponuda.Prodavac == null)
            {
                MessageBox.Show("Izaberite prodavca!\n");
                return;
            }


            ponuda.Kupac = (Kupac)cmbKupac.SelectedItem;
            if (ponuda.Kupac == null)
            {
                MessageBox.Show("Izaberite kupca!\n");
                return;
            }

            try
            {
                ponuda.DatumOd = DateTime.ParseExact(txtDatumOd.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum od u formatu dd.MM.yyyy!");
                return;
            }

            try
            {
                ponuda.DatumDo = DateTime.ParseExact(txtDatumDo.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum do u formatu dd.MM.yyyy!");
                return;
            }

            ponuda.RokIsporuke = txtRokIsporuke.Text;
            if (ponuda.RokIsporuke == "")
            {
                MessageBox.Show("Unesite rok isporuke!\n");
                return;
            }
            else
            {
                ponuda.RokIsporuke = txtRokIsporuke.Text;
            }

            ponuda.ListaStavki = new BindingList<StavkaPonude>(Broker.dajSesiju().ucitajStavkePonudeZaOdredjenuPonudu(ponuda.PonudaID));
            if (ponuda.ListaStavki.Count < 1)
            {
                MessageBox.Show("Ponuda mora imati makar 1 stavku!\n");
                return;
            }

            try
            {
                Broker.dajSesiju().izmeniPonudu(ponuda);
                Broker.dajSesiju().izmeniPonudu2(ponuda);
                MessageBox.Show("Sistem je izmenio ponudu!");
                izmenaPonude.Close();
                dgvPonude.DataSource = new BindingList<Ponuda>(Broker.dajSesiju().ucitajPonudeUDataGrid());
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da izmeni ponudu!\n" + ex.Message);
                izmenaPonude.Close();
                return;
            }
        }

        public void IzmeniStavkuPonude(TextBox txtPonudaIDStavka, TextBox txtStavkaPonudeID, TextBox txtNapomena, TextBox txtVoziloID, DataGridView dgvVozilo, DataGridView dgvStavkePonude, Form izmenaStavkePonude)
        {
            if (string.IsNullOrWhiteSpace(txtNapomena.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            stavkaPonude = new StavkaPonude();

            stavkaPonude.PonudaID = Convert.ToInt32(txtPonudaIDStavka.Text);
            stavkaPonude.StavkaPonudeID = Convert.ToInt32(txtStavkaPonudeID.Text);
            stavkaPonude.Napomena = txtNapomena.Text;
            if (stavkaPonude.Napomena == "")
            {
                MessageBox.Show("Unesite napomenu!");
                return;
            }
            try
            {
                vozilo = (Vozilo)dgvVozilo.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }

            if (txtVoziloID.Text == "")
            {
                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }
            else
            {
                stavkaPonude.Vozilo = vozilo;
                stavkaPonude.Vozilo.VoziloID = Convert.ToInt32(txtVoziloID.Text);
            }


            Broker.dajSesiju().izmeniStavkuPonude(stavkaPonude);
            MessageBox.Show("Stavka ponude je izmenjena!\n");
            dgvStavkePonude.DataSource = Broker.dajSesiju().ucitajStavkePonudeZaOdredjenuPonudu(stavkaPonude.PonudaID);
            izmenaStavkePonude.Close();
        }

        public void UcitajOdabranuStavkuPonude(DataGridView dgvStavkePonude, TextBox txtStavkaPonudeID, TextBox txtNapomena, TextBox txtVoziloID, DataGridView dgvVozilo, DataGridView dgvOprema, Form izmenaStavkePonude)
        {
            try
            {
                stavkaPonude = (StavkaPonude)dgvStavkePonude.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite stavku ponude!");
                return;

            }

            txtStavkaPonudeID.Text = stavkaPonude.StavkaPonudeID.ToString();
            txtVoziloID.Text = stavkaPonude.Vozilo.VoziloID.ToString();
            txtNapomena.Text = stavkaPonude.Napomena;
            txtNapomena.Select();
            dgvOprema.DataSource = new BindingList<Oprema>(Broker.dajSesiju().ucitajListuOpremeZaOdredjenoVozilo(stavkaPonude.Vozilo.VoziloID));
        }

        public void ObrisiStavkuPonude(DataGridView dgvStavkePonude, Button btnObrisi, Form izmenaPonude)
        {
            try
            {
                stavkaPonude = (StavkaPonude)dgvStavkePonude.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite stavku ponude!\n");
                return;
            }

            Broker.dajSesiju().obrisiStavkuPonude(stavkaPonude);
            MessageBox.Show("Sistem je uspešno obrisao stavku ponude!");
            dgvStavkePonude.DataSource = Broker.dajSesiju().ucitajStavkePonudeZaOdredjenuPonudu(stavkaPonude.PonudaID);
        }

      

        public void UcitajPonudeUDataGrid(DataGridView dgvPonude, Form prikazPonude)
        {
            try
            {
                dgvPonude.DataSource = new BindingList<Ponuda>(Broker.dajSesiju().ucitajPonudeUDataGrid());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita ponude!\n" + ex.Message);
                prikazPonude.Close();
                return;
            }
        }

        public void ObrisiPonudu(DataGridView dgvPonude, Form prikazPonude)
        {
            try
            {
                ponuda = (Ponuda)dgvPonude.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite ponudu!");
                return;
            }

            try
            {
                // moze i bez ovoga i *
                List<Ponuda> ponude = ((BindingList<Ponuda>)dgvPonude.DataSource).ToList<Ponuda>();

                // Obrisace se i bez ovoga zbog Cascade ogranicenja u bazi
                if (ponuda.ListaStavki.Count != 0)
                    Broker.dajSesiju().ObrisiStavkePonude(ponuda);

                Broker.dajSesiju().ObrisiPonudu(ponuda);

                // *
                ponude.Remove(ponuda);
                UcitajPonudeUDataGrid(dgvPonude, prikazPonude);
                MessageBox.Show("Sistem je uspešno obrisao ponude i stavke ponude!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da obriše ponudu!\n" + ex.Message);
                prikazPonude.Close();
                return;
            }
        }

        public void UcitajPonudeZaKriterijum(DataGridView dgvPonude, string kriterijum, Form prikazPonude)
        {
            string uneto = kriterijum;

            bool proveriKriterijum(string unet) // da li su svi uneti karakteri brojevi
            {
                unet = uneto;
                foreach (char c in unet)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            // pretraga prema broju ponude
            if (proveriKriterijum(kriterijum) == true)
            {

                int kriterijumBrojPonude = Convert.ToInt32(kriterijum);
                try
                {
                    dgvPonude.DataSource = new BindingList<Ponuda>(Broker.dajSesiju().ucitajPonudeZaBrojPonude(kriterijumBrojPonude));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da učita ponude za dati kriterijum!\n" + ex.Message);
                    prikazPonude.Close();
                    return;
                }
            }
            // pretraga po kupcu/prodavcu
            else
            {
                try
                {
                    dgvPonude.DataSource = new BindingList<Ponuda>(Broker.dajSesiju().ucitajPonudeZaKriterijum(kriterijum));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da učita ponude za dati kriterijum!\n" + ex.Message);
                    prikazPonude.Close();
                    return;
                }
            }
        }



        public void UcitajIDPonudeInicijalizujListu(TextBox txtPonudaID, Form unosPonude)
        {
            try
            {
                txtPonudaID.Text = Broker.dajSesiju().vratiIDPonude().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita PonudaID!\n" + ex.Message);
                unosPonude.Close();
                return;
            }
            ponuda = new Ponuda();
            listaStavkiPonude = new BindingList<StavkaPonude>();
        }

        public void ObrisiStavkuPonudeIzGrida(DataGridView dgvStavkePonude, Button btnObrisi, Form unosPonude)
        {
            try
            {
                stavkaPonude = (StavkaPonude)dgvStavkePonude.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite stavku ponude!");
                return;
            }

            listaStavkiPonude.Remove(stavkaPonude);
        }

        public void SacuvajPonudu(TextBox txtPonudaID, TextBox txtDatumOd, TextBox txtDatumDo, TextBox txtBrojPonude, TextBox txtRokIsporuke, ComboBox cmbKatalog, ComboBox cmbProdavac, ComboBox cmbKupac, Form unosPonude)
        {


            if (string.IsNullOrWhiteSpace(txtBrojPonude.Text) || string.IsNullOrWhiteSpace(txtDatumOd.Text) || string.IsNullOrWhiteSpace(txtDatumDo.Text) || string.IsNullOrWhiteSpace(txtRokIsporuke.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            ponuda = new Ponuda();

            ponuda.PonudaID = Convert.ToInt32(txtPonudaID.Text);

            string uneto = txtBrojPonude.Text;

            bool proveraBrojPonude(string unet)
            {
                unet = uneto;
                foreach (char c in unet)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            if (proveraBrojPonude(txtBrojPonude.ToString()) == true)
            {
                ponuda.BrojPonude = Convert.ToInt32(txtBrojPonude.Text);
            }
            else
            {
                MessageBox.Show("Unesite ispravno broj ponude!");
                return;
            }



            ponuda.Katalog = (Katalog)cmbKatalog.SelectedItem;
            if (ponuda.Katalog == null)
            {
                MessageBox.Show("Izaberite katalog!\n");
                return;
            }

            ponuda.Prodavac = (Prodavac)cmbProdavac.SelectedItem;
            if (ponuda.Prodavac == null)
            {
                MessageBox.Show("Izaberite prodavca!\n");
                return;
            }


            ponuda.Kupac = (Kupac)cmbKupac.SelectedItem;
            if (ponuda.Kupac == null)
            {
                MessageBox.Show("Izaberite kupca!\n");
                return;
            }

            try
            {
                ponuda.DatumOd = DateTime.ParseExact(txtDatumOd.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum od u formatu dd.MM.yyyy!");
                return;
            }

            try
            {
                ponuda.DatumDo = DateTime.ParseExact(txtDatumDo.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum do u formatu dd.MM.yyyy!");
                return;
            }

            ponuda.RokIsporuke = txtRokIsporuke.Text;
            if (ponuda.RokIsporuke == "")
            {
                MessageBox.Show("Unesite rok isporuke!\n");
                return;
            }
            else
            {
                ponuda.RokIsporuke = txtRokIsporuke.Text;
            }

            ponuda.ListaStavki = new BindingList<StavkaPonude>(listaStavkiPonude);

            if (ponuda.ListaStavki.Count < 1)
            {
                MessageBox.Show("Ponuda mora imati makar 1 stavku!\n");
                return;
            }

            try
            {
                Broker.dajSesiju().sacuvajPonudu(ponuda);
                MessageBox.Show("Sistem je sačuvao ponudu!");
                unosPonude.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da sačuva ponudu!\n" + ex.Message);
                unosPonude.Close();
                return;
            }
        }

        public void PostaviIDPonude(TextBox txtPonudaID, TextBox txtPonudaIDStavka, Form unosStavkePonude)
        {
            try
            {
                txtPonudaIDStavka.Text = txtPonudaID.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da postavi PonudaID!\n" + ex.Message);
                unosStavkePonude.Close();
                return;
            }
        }

        public void DodajStavkuPonude(DataGridView dgvStavkePonude, DataGridView dgvVozilo, TextBox txtPonudaIDStavka, TextBox txtNapomena, TextBox txtVoziloID, Form unosStavkePonude)
        {
            if (string.IsNullOrWhiteSpace(txtNapomena.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            stavkaPonude = new StavkaPonude();

            stavkaPonude.PonudaID = Convert.ToInt32(txtPonudaIDStavka.Text);

            stavkaPonude.Napomena = txtNapomena.Text;
            if (stavkaPonude.Napomena == "")
            {
                MessageBox.Show("Unesite napomenu!");
                return;
            }

            try
            {
                vozilo = (Vozilo)dgvVozilo.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }

            if (txtVoziloID.Text == "")
            {
                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }
            else
            {
                stavkaPonude.Vozilo = vozilo;
                stavkaPonude.Vozilo.VoziloID = Convert.ToInt32(txtVoziloID.Text);
            }

            if (Broker.dajSesiju().postojiPonudaUBazi(stavkaPonude.PonudaID))
            {
                Broker.dajSesiju().sacuvajStavkuPonude(stavkaPonude);
                dgvStavkePonude.DataSource = Broker.dajSesiju().ucitajStavkePonudeZaOdredjenuPonudu(stavkaPonude.PonudaID);
                MessageBox.Show("Sistem je uspešno sačuvao stavku ponude!\n");
                unosStavkePonude.Close();
            }
            else
            {
                listaStavkiPonude.Add(stavkaPonude);
                dgvStavkePonude.DataSource = listaStavkiPonude;
                MessageBox.Show("Stavka ponude je dodata!\n");
                unosStavkePonude.Close();
            }
        }

        public void UcitajSveKataloge(ComboBox cmbKatalog, Form unosPonude)
        {

            try
            {
                foreach (Katalog k in Broker.dajSesiju().ucitajSveKataloge())
                {
                    cmbKatalog.Items.Add(k);
                }
                cmbKatalog.Text = "Izaberite odgovarajući katalog!";
                cmbKatalog.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita kataloge!\n" + ex.Message);
                unosPonude.Close();
                return;
            }
        }

        public void UcitajSveKupce(ComboBox cmbKupac, Form unosPonude)
        {
            try
            {
                foreach (Kupac k in Broker.dajSesiju().ucitajSveKupce())
                {
                    cmbKupac.Items.Add(k);
                }
                cmbKupac.Text = "Izaberite odgovarajućeg kupca!";
                cmbKupac.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita kupce!\n" + ex.Message);
                unosPonude.Close();
                return;
            }
        }




        public void PostaviIDRacunOtpremnice(TextBox txtRacunOtpremnicaID, TextBox txtRacunOtpremnicaIDStavka, Form unosStavkeRacunaOtpremnice)
        {
            try
            {
                txtRacunOtpremnicaIDStavka.Text = txtRacunOtpremnicaID.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da postavi RačunOtpremnicaID!\n" + ex.Message);
                unosStavkeRacunaOtpremnice.Close();
                return;
            }
        }

        public void UcitajOdabranuStavkuRacunOtpremnice(DataGridView dgvStavkeRacunaOtpremnice, TextBox txtStavkaRacunOtpremniceID, TextBox txtKolicina, TextBox txtVoziloID, DataGridView dgvVozilo, DataGridView dgvOprema, Form izmenaStavkeRacunOtpremnice)
        {

            try
            {
                stavkaRacunaOtpremnice = (StavkaRacunaOtpremnice)dgvStavkeRacunaOtpremnice.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite stavku račun-otpremnice!");
                return;

            }

            txtStavkaRacunOtpremniceID.Text = stavkaRacunaOtpremnice.StavkaRacunaOtpremniceID.ToString();
            txtVoziloID.Text = stavkaRacunaOtpremnice.Vozilo.VoziloID.ToString();
            txtKolicina.Text = stavkaRacunaOtpremnice.Kolicina.ToString();
            txtKolicina.Select();
            dgvOprema.DataSource = new BindingList<Oprema>(Broker.dajSesiju().ucitajListuOpremeZaOdredjenoVozilo(stavkaRacunaOtpremnice.Vozilo.VoziloID));

        }

        public void IzmeniStavkuRacunOtpremnice(TextBox txtRacunOtpremnicaIDStavka, TextBox txtStavkaRacunOtpremniceID, TextBox txtKolicina, TextBox txtVoziloID, DataGridView dgvVozilo, DataGridView dgvStavkeRacunaOtpremnice, Form izmenaStavkeRacunOtpremnice)
        {
            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            stavkaRacunaOtpremnice = new StavkaRacunaOtpremnice();

            stavkaRacunaOtpremnice.RacunOtpremnicaID = Convert.ToInt32(txtRacunOtpremnicaIDStavka.Text);
            stavkaRacunaOtpremnice.StavkaRacunaOtpremniceID = Convert.ToInt32(txtStavkaRacunOtpremniceID.Text);

            try
            {
                stavkaRacunaOtpremnice.Kolicina = Convert.ToInt32(txtKolicina.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neispravno uneta količina! " + ex.Message);
                return;
            }

            if (stavkaRacunaOtpremnice.Kolicina < 1)
            {
                MessageBox.Show("Količina mora biti pozitivna!");
                return;
            }

            try
            {
                vozilo = (Vozilo)dgvVozilo.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }

            if (txtVoziloID.Text == "")
            {
                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }
            else
            {
                stavkaRacunaOtpremnice.Vozilo = vozilo;
                stavkaRacunaOtpremnice.Vozilo.VoziloID = Convert.ToInt32(txtVoziloID.Text);
            }


            Broker.dajSesiju().izmeniStavkuRacunOtpremnice(stavkaRacunaOtpremnice);
            MessageBox.Show("Stavka račun-otpremnice je izmenjena!\n");
            dgvStavkeRacunaOtpremnice.DataSource = Broker.dajSesiju().ucitajStavkeRacunOtpremniceZaOdredjenuRacunOtpremnicu(stavkaRacunaOtpremnice.RacunOtpremnicaID);
            izmenaStavkeRacunOtpremnice.Close();

        }

        public void IzmeniRacunOtpremnicu(TextBox txtRacunOtpremnicaID, TextBox txtBrojRacunaOtpremnice, TextBox txtDatumIzdavanja, TextBox txtDatumPrometa, ComboBox cmbNacinPlacanja, ComboBox cmbPredracun, TextBox txtKupac, TextBox txtProdavacID, TextBox txtImePrezimeProdavca, DataGridView dgvRacunOtpremnice, Form izmenaRacunOtpremnice)
        {
            if (string.IsNullOrWhiteSpace(txtBrojRacunaOtpremnice.Text) || string.IsNullOrWhiteSpace(txtDatumIzdavanja.Text) || string.IsNullOrWhiteSpace(txtDatumPrometa.Text) || string.IsNullOrWhiteSpace(txtProdavacID.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }
            RacunOtpremnica racunOtpremnicaStara = (RacunOtpremnica)dgvRacunOtpremnice.CurrentRow.DataBoundItem;
            string staroImePrezimeProdavca = racunOtpremnicaStara.ImePrezimeProdavac;

            RacunOtpremnica racunOtpremnica = new RacunOtpremnica();

            racunOtpremnica.RacunOtpremnicaID = Convert.ToInt32(txtRacunOtpremnicaID.Text);

            string uneto = txtBrojRacunaOtpremnice.Text;

            bool proveraBrojRacunOtpremnice(string unet)
            {
                unet = uneto;
                foreach (char c in unet)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            if (proveraBrojRacunOtpremnice(txtBrojRacunaOtpremnice.ToString()) == true)
            {
                racunOtpremnica.BrojRacunaOtpremnice = Convert.ToInt32(txtBrojRacunaOtpremnice.Text);
            }
            else
            {
                MessageBox.Show("Unesite ispravno broj račun - otpremnice!");
                return;
            }


            racunOtpremnica.Predracun = (Predracun)cmbPredracun.SelectedItem;

            if (racunOtpremnica.Predracun == null)
            {
                MessageBox.Show("Izaberite predračun!\n");
                return;
            }

            else
            {
                racunOtpremnica.Kupac = new Kupac();
                racunOtpremnica.Kupac.KupacJMBG = racunOtpremnica.Predracun.Kupac.KupacJMBG;
            }

            try
            {
                racunOtpremnica.DatumIzdavanja = DateTime.ParseExact(txtDatumIzdavanja.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum izdavanja u formatu dd.MM.yyyy!");
                return;
            }

            try
            {
                racunOtpremnica.DatumPrometa = DateTime.ParseExact(txtDatumPrometa.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum prometa u formatu dd.MM.yyyy!");
                return;
            }

            racunOtpremnica.NacinPlacanja = (string)cmbNacinPlacanja.SelectedItem;
            if (cmbNacinPlacanja.Text == null)
            {
                MessageBox.Show("Izaberite način plaćanja!\n");
                return;
            }


            if (txtProdavacID.Text == "")
            {
                MessageBox.Show("Unesite ID Prodavca!");
                return;
            }
            else if (txtImePrezimeProdavca.Text == "")
            {
                MessageBox.Show("Potvrdite unos ID-a prodavca klikom na dugme Izaberi prodavca!");
                return;
            }
            else
            {
                racunOtpremnica.Prodavac = new Prodavac();
                racunOtpremnica.Prodavac.ProdavacID = Convert.ToInt32(txtProdavacID.Text);
                racunOtpremnica.Prodavac.ImePrezimeProdavca = txtImePrezimeProdavca.Text;
            }

            racunOtpremnica.ListaStavki = new BindingList<StavkaRacunaOtpremnice>(Broker.dajSesiju().ucitajStavkeRacunOtpremniceZaOdredjenuRacunOtpremnicu(racunOtpremnica.RacunOtpremnicaID));
            if (racunOtpremnica.ListaStavki.Count < 1)
            {
                MessageBox.Show("Račun-otpremnica mora imati makar 1 stavku!\n");
                return;
            }

            string imePrezimeProdavcaNaOsnovuID = Broker.dajSesiju().vratiImePrezimeProdavcaNaOsnovuID(racunOtpremnica.Prodavac.ProdavacID);
            if (!(imePrezimeProdavcaNaOsnovuID.Equals(txtImePrezimeProdavca.Text)))
            {
                string rez = Broker.dajSesiju().izmeniRacunOtpremnicuImePrezimeProdavca(racunOtpremnica);
                MessageBox.Show(rez);
                txtImePrezimeProdavca.Text = staroImePrezimeProdavca;
                return;
            }
            else
            {

                string rez=Broker.dajSesiju().izmeniRacunOtpremnicu(racunOtpremnica);
                MessageBox.Show(rez);
                izmenaRacunOtpremnice.Close();
                dgvRacunOtpremnice.DataSource = new BindingList<RacunOtpremnica>(Broker.dajSesiju().ucitajRacunOtpremnice());
                return;
            }

        }

        public void UcitajOdabranuRacunOtpremnicu(DataGridView dgvRacunOtpremnice, DataGridView dgvStavkeRacunaOtpremnice, TextBox txtRacunOtpremnicaID, TextBox txtBrojRacunaOtpremnice, TextBox txtDatumIzdavanja, TextBox txtDatumPrometa, ComboBox cmbNacinPlacanja, TextBox txtImePrezimeProdavca, ComboBox cmbPredracun, TextBox txtProdavacID, TextBox txtKupac, Form izmenaRacunOtpremnice)
        {

            try
            {
                racunOtpremnica = (RacunOtpremnica)dgvRacunOtpremnice.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite račun-otpremnicu!");
                return;
            }

            txtRacunOtpremnicaID.Text = racunOtpremnica.RacunOtpremnicaID.ToString();
            txtBrojRacunaOtpremnice.Text = racunOtpremnica.BrojRacunaOtpremnice.ToString();
            txtDatumIzdavanja.Text = racunOtpremnica.DatumIzdavanja.ToString("dd.MM.yyyy");
            txtDatumPrometa.Text = racunOtpremnica.DatumPrometa.ToString("dd.MM.yyyy");
            txtImePrezimeProdavca.Text = racunOtpremnica.ImePrezimeProdavac;
            cmbPredracun.SelectedIndex = racunOtpremnica.Predracun.PredracunID - 1;
            if (racunOtpremnica.NacinPlacanja == "Bezgotovinsko placanje")
            {
                cmbNacinPlacanja.SelectedIndex = 0;
            }
            else if (racunOtpremnica.NacinPlacanja == "Gotovinsko placanje")
            {
                cmbNacinPlacanja.SelectedIndex = 1;
            }
            else if (racunOtpremnica.NacinPlacanja == "Platna kartica")
            {
                cmbNacinPlacanja.SelectedIndex = 2;
            }
            txtProdavacID.Text = racunOtpremnica.Prodavac.ProdavacID.ToString();
            txtKupac.Text = racunOtpremnica.Kupac.ImePrezimeKupca;
            dgvStavkeRacunaOtpremnice.DataSource = new BindingList<StavkaRacunaOtpremnice>(Broker.dajSesiju().ucitajStavkeRacunOtpremniceZaOdredjenuRacunOtpremnicu(racunOtpremnica.RacunOtpremnicaID));
        }

        public void ObrisiStavkuRacunOtpremnice(DataGridView dgvStavkeRacunaOtpremnice, Button btnObrisi, Form izmenaRacunOtpremnice)
        {
            try
            {
                stavkaRacunaOtpremnice = (StavkaRacunaOtpremnice)dgvStavkeRacunaOtpremnice.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite stavku račun-otpremnice!\n");
                return;
            }

            Broker.dajSesiju().obrisiStavkuRacunOtpremnice(stavkaRacunaOtpremnice);
            MessageBox.Show("Sistem je uspešno obrisao stavku račun-otpremnice!");
            dgvStavkeRacunaOtpremnice.DataSource = Broker.dajSesiju().ucitajStavkeRacunOtpremniceZaOdredjenuRacunOtpremnicu(stavkaRacunaOtpremnice.RacunOtpremnicaID);
        }

        public void UcitajRacunOtpremniceZaKriterijum(DataGridView dgvRacunOtpremnice, string kriterijum, Form prikazRacunOtpremnice)
        {

            try
            {
                dgvRacunOtpremnice.DataSource = new BindingList<RacunOtpremnica>(Broker.dajSesiju().ucitajRacunOtpremniceZaKriterijum(kriterijum));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita račun-otpremnice za dati kriterijum!\n" + ex.Message);
                prikazRacunOtpremnice.Close();
                return;
            }


        }

        public void ObrisiRacunOtpremnicu(DataGridView dgvRacunOtpremnice, Form prikazRacunOtpremnice)
        {
            try
            {
                racunOtpremnica = (RacunOtpremnica)dgvRacunOtpremnice.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite račun-otpremnicu!");
                return;
            }

            try
            {
                List<RacunOtpremnica> racunOtpremnice = ((BindingList<RacunOtpremnica>)dgvRacunOtpremnice.DataSource).ToList<RacunOtpremnica>();


                if (racunOtpremnica.ListaStavki.Count != 0)
                    Broker.dajSesiju().ObrisiStavkeRacunOtpremnice(racunOtpremnica);

                Broker.dajSesiju().ObrisiRacunOtpremnicu(racunOtpremnica);

                racunOtpremnice.Remove(racunOtpremnica);
                UcitajRacunOtpremniceUDataGrid(dgvRacunOtpremnice, prikazRacunOtpremnice);
                MessageBox.Show("Sistem je uspešno obrisao račun-otpremnicu i stavke račun-otpremnice!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da obriše račun-otpremnicu!\n" + ex.Message);
                prikazRacunOtpremnice.Close();
                return;
            }
        }

        public void IzmeniProdavca(TextBox txtProdavacID, TextBox txtImePrezimeProdavca, DataGridView dgvProdavci, Form izmenaProdavca)
        {

            if (string.IsNullOrWhiteSpace(txtImePrezimeProdavca.Text))
            {
                MessageBox.Show("Unesite ime i prezime prodavca!");
                return;
            }

            Prodavac prodavac = new Prodavac();

            prodavac.ProdavacID = Convert.ToInt32(txtProdavacID.Text);

            string uneto = txtImePrezimeProdavca.Text;

            bool proveraImenaPrezimenaProdavca(string unet)
            {
                foreach (char c in uneto)
                {
                    if (char.IsDigit(c))
                        return false;
                }
                return true;
            }

            if (proveraImenaPrezimenaProdavca(uneto) == false || !(uneto.Contains(" ")))
            {

                MessageBox.Show("Unesite ispravno ime i prezime prodavca!");
                return;
            }
            else
            {
                prodavac.ImePrezimeProdavca = txtImePrezimeProdavca.Text;
            }

            try
            {
                Broker.dajSesiju().izmeniProdavca(prodavac);
                MessageBox.Show("Sistem je izmenio prodavca!");
                izmenaProdavca.Close();
                dgvProdavci.DataSource = new BindingList<Prodavac>(Broker.dajSesiju().ucitajSveProdavce());
                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sistem ne može da izmeni prodavca!\n" + ex.Message);
                izmenaProdavca.Close();
                return;
            }
        }

        public bool PostojiProdavacUBazi(TextBox txtProdavacID, Form unosRacunOtpremnice)
        {
            bool rez = Broker.dajSesiju().postojiProdavacUBazi(Convert.ToInt32(txtProdavacID.Text));
            return rez;
        }

        public void ObrisiProdavca(DataGridView dgvProdavci, Form prikazProdavca)
        {

            try
            {
                prodavac = (Prodavac)dgvProdavci.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite prodavca!");
                return;
            }

            List<Prodavac> prodavci = ((BindingList<Prodavac>)dgvProdavci.DataSource).ToList<Prodavac>();

            string rez = Broker.dajSesiju().obrisiProdavca(prodavac);
            MessageBox.Show(rez);

            prodavci.Remove(prodavac);
            UcitajProdavceUDataGrid(dgvProdavci, prikazProdavca);

        }



        public void UcitajProdavceUDataGrid(DataGridView dgvProdavci, Form prikazProdavca)
        {
            try
            {
                dgvProdavci.DataSource = new BindingList<Prodavac>(Broker.dajSesiju().ucitajSveProdavce());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita prodavce!\n" + ex.Message);
                prikazProdavca.Close();
                return;
            }
        }

        public void UcitajOdabranogProdavca(DataGridView dgvProdavci, TextBox txtProdavacID, TextBox txtImePrezimeProdavca, Form izmenaProdavca)
        {
            try
            {
                prodavac = (Prodavac)dgvProdavci.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite prodavca!");
                return;

            }

            txtProdavacID.Text = prodavac.ProdavacID.ToString();
            txtImePrezimeProdavca.Text = prodavac.ImePrezimeProdavca;

        }

        public void UcitajProdavceNaOsnovuImenaPrezimena(DataGridView dgvProdavci, string kriterijum, Form prikazProdavca)
        {
            try
            {
                dgvProdavci.DataSource = new BindingList<Prodavac>(Broker.dajSesiju().ucitajProdavceNaOsnovuImenaPrezimena(kriterijum));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita prodavce za dati kriterijum!\n" + ex.Message);
                prikazProdavca.Close();
                return;
            }
        }



        public void SacuvajProdavca(TextBox txtProdavacID, TextBox txtImePrezimeProdavca, Form unosProdavca)
        {
            if (string.IsNullOrWhiteSpace(txtImePrezimeProdavca.Text))
            {
                MessageBox.Show("Unesite ime i prezime prodavca!");
                return;
            }

            Prodavac prodavac = new Prodavac();

            prodavac.ProdavacID = Convert.ToInt32(txtProdavacID.Text);

            string uneto = txtImePrezimeProdavca.Text;

            bool proveraImenaPrezimenaProdavca(string unet)
            {
                foreach (char c in uneto)
                {
                    if (char.IsDigit(c))
                        return false;
                }
                return true;
            }

            if (proveraImenaPrezimenaProdavca(uneto) == false || !(uneto.Contains(" ")))
            {

                MessageBox.Show("Unesite ispravno ime i prezime prodavca!");
                return;
            }
            else
            {
                prodavac.ImePrezimeProdavca = txtImePrezimeProdavca.Text;
            }

            try
            {
                Broker.dajSesiju().sacuvajProdavca(prodavac);
                MessageBox.Show("Sistem je sačuvao prodavca!");
                unosProdavca.Close();
                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sistem ne može da sačuva prodavca!\n" + ex.Message);
                unosProdavca.Close();
                return;
            }

        }



        public void UcitajIDProdavca(TextBox txtProdavacID, Form unosProdavca)
        {
            try
            {
                txtProdavacID.Text = Broker.dajSesiju().vratiIDProdavca().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita ProdavacID!\n" + ex.Message);
                unosProdavca.Close();
                return;
            }
        }



        public void PostaviIDClanaUgovora(TextBox txtClanUgovoraID, Form unosClanaUgovora)
        {
            try
            {
                txtClanUgovoraID.Text = Broker.dajSesiju().vratiIDClanaUgovora().ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da ucita ČlanUgovoraID!\n");
                return;
            }
        }



        public void UcitajOdabraniClanUgovora(DataGridView dgvClanoviUgovora, TextBox txtClanUgovoraID, TextBox txtNazivClana, TextBox txtOpisClana, Form izmenaClanaUgovora)
        {

            try
            {
                clanUgovora = (ClanUgovora)dgvClanoviUgovora.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite član ugovora!");
                return;

            }

            txtNazivClana.Text = clanUgovora.NazivClanaUgovora;
            txtNazivClana.Select();
            txtOpisClana.Text = clanUgovora.OpisClanaUgovora;
            txtClanUgovoraID.Text = clanUgovora.ClanUgovoraID.ToString();


        }

        public void ObrisiClanUgovora(DataGridView dgvClanoviUgovora, Button btnObrisi, Form izmenaUgovora)
        {
            try
            {
                clanUgovora = (ClanUgovora)dgvClanoviUgovora.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite član ugovora!\n");
                return;
            }

            Broker.dajSesiju().obrisiClanUgovora(clanUgovora);
            MessageBox.Show("Sistem je uspešno obrisao član ugovora!");
            dgvClanoviUgovora.DataSource = Broker.dajSesiju().ucitajClanoveUgovoraZaOdredjeniUgovor(clanUgovora.UgovorID);
        }

        public void IzmeniUgovor(TextBox txtUgovorID, TextBox txtBrojUgovora, TextBox txtDatumPotpisivanja, ComboBox cmbNarudzbenica, TextBox txtKupac, ComboBox cmbProdavac, DataGridView dgvUgovori, Form izmenaUgovora)
        {

            if (string.IsNullOrWhiteSpace(txtBrojUgovora.Text) || string.IsNullOrWhiteSpace(txtDatumPotpisivanja.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            Ugovor ugovor = new Ugovor();

            ugovor.UgovorID = Convert.ToInt32(txtUgovorID.Text);

            string uneto = txtBrojUgovora.Text;

            bool proveraBrojaUgovora(string unet)
            {
                unet = uneto;
                foreach (char c in unet)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            if (proveraBrojaUgovora(txtBrojUgovora.ToString()) == true)
            {
                try
                {
                    ugovor.BrojUgovora = Convert.ToInt32(txtBrojUgovora.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nije ispravan broj ugovora!");
                    return;

                }
            }
            else
            {
                MessageBox.Show("Unesite ispravno broj ugovora!");
                return;
            }

            ugovor.Narudzbenica = (Narudzbenica)cmbNarudzbenica.SelectedItem;

            if (ugovor.Narudzbenica == null)
            {
                MessageBox.Show("Izaberite narudžbenicu!\n");
                return;
            }
            else
            {
                ugovor.Kupac = new Kupac();
                ugovor.Kupac.KupacJMBG = ugovor.Narudzbenica.Kupac.KupacJMBG;
            }

            try
            {
                ugovor.DatumPotpisivanja = DateTime.ParseExact(txtDatumPotpisivanja.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum potpisivanja u formatu dd.MM.yyyy!");
                return;
            }

            ugovor.Prodavac = (Prodavac)cmbProdavac.SelectedItem;

            if (ugovor.Prodavac == null)
            {
                MessageBox.Show("Izaberite prodavca!\n");
                return;
            }


            ugovor.ListaClanovaUgovora = new BindingList<ClanUgovora>(Broker.dajSesiju().ucitajClanoveUgovoraZaOdredjeniUgovor(ugovor.UgovorID));
            if (ugovor.ListaClanovaUgovora.Count < 1)
            {
                MessageBox.Show("Ugovor mora imati makar 1 član!\n");
                return;
            }

            try
            {
                Broker.dajSesiju().izmeniUgovor(ugovor);
                MessageBox.Show("Sistem je izmenio ugovor!");
                izmenaUgovora.Close();
                dgvUgovori.DataSource = new BindingList<Ugovor>(Broker.dajSesiju().ucitajUgovoreUDataGrid());
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da izmeni ugovor!\n" + ex.Message);
                izmenaUgovora.Close();
                return;
            }
        }

        public void IzmeniClanUgovora(TextBox txtUgovorIDStavka, TextBox txtClanUgovoraID, TextBox txtNazivClana, TextBox txtOpisClana, DataGridView dgvClanoviUgovora, Form izmenaClanaUgovora)
        {
            if (string.IsNullOrWhiteSpace(txtNazivClana.Text) || string.IsNullOrWhiteSpace(txtOpisClana.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            clanUgovora = new ClanUgovora();

            if (!(txtNazivClana.Text.Contains("Clan")))
            {
                MessageBox.Show("Unesite ispravno naziv člana ugovora!\n");
                return;
            }
            else
            {
                clanUgovora.NazivClanaUgovora = txtNazivClana.Text;
            }

            clanUgovora.OpisClanaUgovora = txtOpisClana.Text;
            if (clanUgovora.OpisClanaUgovora == "")
            {
                MessageBox.Show("Unesite opis člana ugovora!\n");
                return;
            }

          
            clanUgovora.UgovorID = Convert.ToInt32(txtUgovorIDStavka.Text);
            clanUgovora.ClanUgovoraID = Convert.ToInt32(txtClanUgovoraID.Text);


            string rez=Broker.dajSesiju().izmeniClanUgovora(clanUgovora);
            MessageBox.Show(rez);
            dgvClanoviUgovora.DataSource = Broker.dajSesiju().ucitajClanoveUgovoraZaOdredjeniUgovor(clanUgovora.UgovorID);
            izmenaClanaUgovora.Close();
        }

        public void PostaviIDUgovora(TextBox txtUgovorID, TextBox txtUgovorIDStavka, Form unosClanaUgovora)
        {
            try
            {
                txtUgovorIDStavka.Text = txtUgovorID.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da postavi UgovorID!\n" + ex.Message);
                unosClanaUgovora.Close();
                return;
            }
        }



        public void UcitajOdabraniUgovor(DataGridView dgvUgovori, DataGridView dgvClanoviUgovora, TextBox txtUgovorID, TextBox txtBrojUgovora, TextBox txtDatumPotpisivanja, ComboBox cmbNarudzbenica, TextBox txtKupac, ComboBox cmbProdavac, Form izmenaUgovora)
        {
            try
            {
                ugovor = (Ugovor)dgvUgovori.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite ugovor!");
                return;
            }

            txtUgovorID.Text = ugovor.UgovorID.ToString();
            txtBrojUgovora.Text = ugovor.BrojUgovora.ToString();
            txtDatumPotpisivanja.Text = ugovor.DatumPotpisivanja.ToString("dd.MM.yyyy");
            txtKupac.Text = ugovor.Kupac.ImePrezimeKupca;
            cmbNarudzbenica.SelectedIndex = ugovor.Narudzbenica.NarudzbenicaID - 1;
            cmbProdavac.SelectedIndex = ugovor.Prodavac.ProdavacID - 1;

            dgvClanoviUgovora.DataSource = new BindingList<ClanUgovora>(Broker.dajSesiju().ucitajClanoveUgovoraZaOdredjeniUgovor(ugovor.UgovorID));

        }



        public void UcitajSveUgovoreZaOdabranuParticiju(DataGridView dgvUgovori, DataGridView dgvParticije, Form prikazParticija)
        {

            try
            {

                part = (Particije)dgvParticije.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite particije!");
                return;
            }

            dgvUgovori.Visible = true;
            try
            {
                dgvUgovori.DataSource = new BindingList<UgovorParticije>(Broker.dajSesiju().ucitajUgovoreZaParticiju(part));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita ugovore iz particije!\n" + ex.Message);
                prikazParticija.Close();
                return;
            }
        }




        public void UcitajParticije(DataGridView dgvParticije, Form prikazParticija)
        {
            try
            {
                dgvParticije.DataSource = new BindingList<Particije>(Broker.dajSesiju().ucitajParticije());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita podatke o particijama!\n" + ex.Message);
                prikazParticija.Close();
                return;
            }
        }



        public void UcitajUgovoreZaKriterijum(DataGridView dgvUgovori, string kriterijum, Form prikazUgovora)
        {
            string uneto = kriterijum;

            bool proveriKriterijum(string unet) // da li su svi uneti karakteri brojevi
            {
                unet = uneto;
                foreach (char c in unet)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            // pretraga prema broju ugovora
            if (proveriKriterijum(kriterijum) == true)
            {

                int kriterijumBrojUgovora = Convert.ToInt32(kriterijum);
                try
                {
                    dgvUgovori.DataSource = new BindingList<Ugovor>(Broker.dajSesiju().ucitajUgovoreZaBrojUgovora(kriterijumBrojUgovora));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da učita ugovore za dati kriterijum!\n" + ex.Message);
                    prikazUgovora.Close();
                    return;
                }
            }
            // pretraga po kupcu/prodavcu
            else
            {
                try
                {
                    dgvUgovori.DataSource = new BindingList<Ugovor>(Broker.dajSesiju().ucitajUgovoreZaKriterijum(kriterijum));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da učita ugovore za dati kriterijum!\n" + ex.Message);
                    prikazUgovora.Close();
                    return;
                }
            }
        }

        public void ObrisiUgovor(DataGridView dgvUgovori, Form prikazUgovora)
        {

            try
            {
                ugovor = (Ugovor)dgvUgovori.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite ugovor!");
                return;
            }

            try
            {
                // moze i bez ovoga i *
                List<Ugovor> ugovori = ((BindingList<Ugovor>)dgvUgovori.DataSource).ToList<Ugovor>();

                // Obrisace se i bez ovoga zbog Cascade ogranicenja u bazi
                if (ugovor.ListaClanovaUgovora.Count != 0)
                    Broker.dajSesiju().ObrisiClanoveUgovora(ugovor);

                Broker.dajSesiju().ObrisiUgovor(ugovor);

                // *
                ugovori.Remove(ugovor);
                UcitajUgovoreUDataGrid(dgvUgovori, prikazUgovora);
                MessageBox.Show("Sistem je uspešno obrisao ugovor i članove ugovora!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da obriše ugovor!\n" + ex.Message);
                prikazUgovora.Close();
                return;
            }
        }

        public void UcitajNarudzbenice(ComboBox cmbNarudzbenica, Form unosUgovora)
        {
            try
            {
                foreach (Narudzbenica n in Broker.dajSesiju().ucitajNarudzbenice())
                {
                    cmbNarudzbenica.Items.Add(n);
                }
                cmbNarudzbenica.Text = "Izaberite odgovarajuću narudžbenicu!";
                cmbNarudzbenica.SelectedItem = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita narudžbenice!\n" + ex.Message);
                unosUgovora.Close();
                return;
            }
        }

        public void SacuvajUgovor(TextBox txtUgovorID, TextBox txtBrojUgovora, ComboBox cmbNarudzbenica, TextBox txtDatumPotpisivanja, ComboBox cmbProdavac, TextBox txtKupac, Form unosUgovora)
        {

            if (string.IsNullOrWhiteSpace(txtBrojUgovora.Text) || string.IsNullOrWhiteSpace(txtDatumPotpisivanja.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }
            //!!
            ugovor = new Ugovor();

            ugovor.UgovorID = Convert.ToInt32(txtUgovorID.Text);

            string uneto = txtBrojUgovora.Text;

            bool proveraBrojaUgovora(string unet)
            {
                unet = uneto;
                foreach (char c in unet)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            if (proveraBrojaUgovora(txtBrojUgovora.ToString()) == true)
            {
                try
                {
                    ugovor.BrojUgovora = Convert.ToInt32(txtBrojUgovora.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nije ispravan broj ugovora!");
                    return;

                }
            }
            else
            {
                MessageBox.Show("Unesite ispravno broj ugovora!");
                return;
            }

            ugovor.Narudzbenica = (Narudzbenica)cmbNarudzbenica.SelectedItem;

            if (ugovor.Narudzbenica == null)
            {
                MessageBox.Show("Izaberite narudžbenicu!\n");
                return;
            }
            else
            {
                ugovor.Kupac = new Kupac();
                ugovor.Kupac.KupacJMBG = ugovor.Narudzbenica.Kupac.KupacJMBG;
            }

            try
            {
                ugovor.DatumPotpisivanja = DateTime.ParseExact(txtDatumPotpisivanja.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum potpisivanja u formatu dd.MM.yyyy!");
                return;
            }

            ugovor.Prodavac = (Prodavac)cmbProdavac.SelectedItem;

            if (ugovor.Prodavac == null)
            {
                MessageBox.Show("Izaberite prodavca!\n");
                return;
            }

            ugovor.ListaClanovaUgovora = new BindingList<ClanUgovora>(listaClanova);
            if (ugovor.ListaClanovaUgovora.Count < 1)
            {
                MessageBox.Show("Ugovor mora imati makar 1 član!\n");
                return;
            }

            try
            {
                Broker.dajSesiju().sacuvajUgovor(ugovor);
                MessageBox.Show("Sistem je sačuvao ugovor!");
                unosUgovora.Close();
                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sistem ne može da sačuva ugovor!\n" + ex.Message);
                unosUgovora.Close();
                return;
            }

        }

        public void ObrisiClanUgovoraIzGrida(DataGridView dgvClanoviUgovora, Button btnObrisi, Form unosUgovora)
        {
            try
            {
                clanUgovora = (ClanUgovora)dgvClanoviUgovora.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite član ugovora!");
                return;
            }

            listaClanova.Remove(clanUgovora);
        }

        public void DodajClanUgovora(TextBox txtUgovorID, TextBox txtNazivClana, TextBox txtOpisClana, DataGridView dgvClanoviUgovora, Form unosClanaUgovora)
        {
            if (string.IsNullOrWhiteSpace(txtNazivClana.Text) || string.IsNullOrWhiteSpace(txtOpisClana.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            clanUgovora = new ClanUgovora();

            clanUgovora.UgovorID = Convert.ToInt32(txtUgovorID.Text);

            if (!(txtNazivClana.Text.Contains("Clan")))
            {
                MessageBox.Show("Unesite ispravno naziv člana ugovora!\n");
                return;
            }
            else
            {
                clanUgovora.NazivClanaUgovora = txtNazivClana.Text;
            }

            clanUgovora.OpisClanaUgovora = txtOpisClana.Text;
            if (clanUgovora.OpisClanaUgovora == "")
            {
                MessageBox.Show("Unesite opis člana ugovora!\n");
                return;
            }

            if (Broker.dajSesiju().postojiUgovorUBazi(clanUgovora.UgovorID))
            {
                Broker.dajSesiju().sacuvajClanUgovora(clanUgovora);
                dgvClanoviUgovora.DataSource = Broker.dajSesiju().ucitajClanoveUgovoraZaOdredjeniUgovor(clanUgovora.UgovorID);
                MessageBox.Show("Sistem je uspešno sačuvao član ugovora!\n");
                unosClanaUgovora.Close();
            }
            else
            {
                listaClanova.Add(clanUgovora);
                dgvClanoviUgovora.DataSource = listaClanova;
                MessageBox.Show("Član ugovora je dodat!\n");
                unosClanaUgovora.Close();
            }



        }

        public void PostaviKupcaZaIzabranuNarudzbenicu(ComboBox cmbNarudzbenica, TextBox txtKupac, Form unosUgovora)
        {
            try
            {
                narudzbenica = cmbNarudzbenica.SelectedItem as Narudzbenica;
                kupac = Broker.dajSesiju().ucitajKupcaZaOdredjenuNarudzbenicu(narudzbenica);
                txtKupac.Text = kupac.ImePrezimeKupca.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Sistem ne može da učita kupca za datu narudžbenicu!\n" + ex.Message);
                unosUgovora.Close();
                return;
            }
        }


        public void UcitajIDUgovoraInicijalizujListu(TextBox txtUgovorID, Form unosUgovora)
        {
            try
            {
                txtUgovorID.Text = Broker.dajSesiju().vratiIDUgovora().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita UgovorID!\n" + ex.Message);
                unosUgovora.Close();
                return;
            }

            ugovor = new Ugovor();
            listaClanova = new BindingList<ClanUgovora>();
        }



        public void UcitajPredracuneZaKriterijum(DataGridView dgvPredracuni, string kriterijum, Form prikazPredracuna)
        {
            string uneto = kriterijum;
            if(uneto.Contains('/'))
            {
                BrojPredracuna bp = new BrojPredracuna();
                bp.Godina = Convert.ToInt32(kriterijum.Split('/')[0]);
                bp.RedniBroj = Convert.ToInt32(kriterijum.Split('/')[1]);

                try
                {
                    dgvPredracuni.DataSource = new BindingList<Predracun>(Broker.dajSesiju().ucitajPredracuneZaBrojPredracuna(bp));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da učita predračune za dati kriterijum!\n" + ex.Message);
                    prikazPredracuna.Close();
                    return;
                }
            }
            else
            {

                try
                {
                    dgvPredracuni.DataSource = new BindingList<Predracun>(Broker.dajSesiju().ucitajPredracuneZaKriterijum(kriterijum));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da učita predračune za dati kriterijum!\n" + ex.Message);
                    prikazPredracuna.Close();
                    return;
                }
            }

        }



        public void UcitajUgovoreUDataGrid(DataGridView dgvUgovori, Form prikazUgovora)
        {
            try
            {
                dgvUgovori.DataSource = new BindingList<Ugovor>(Broker.dajSesiju().ucitajUgovoreUDataGrid());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita ugovore!\n" + ex.Message);
                prikazUgovora.Close();
                return;
            }
        }

        public void UcitajRacunOtpremniceUDataGrid(DataGridView dgvRacunOtpremnice, Form prikazRacunOtpremnice)
        {
            try
            {
                dgvRacunOtpremnice.DataSource = new BindingList<RacunOtpremnica>(Broker.dajSesiju().ucitajRacunOtpremnice());
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita račun-otpremnice!\n" + ex.Message);
                prikazRacunOtpremnice.Close();
                return;
            }
        }



        public void UcitajPredracune(ComboBox cmbPredracun, Form unosRacunOtpremnice)
        {
            try
            {
                foreach (Predracun p in Broker.dajSesiju().ucitajPredracune())
                {
                    cmbPredracun.Items.Add(p);
                }
                cmbPredracun.Text = "Izaberite odgovarajući predračun!";
                cmbPredracun.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita predračune!\n" + ex.Message);
                unosRacunOtpremnice.Close();
                return;
            }
        }

        public void SacuvajRacunOtpremnicu(TextBox txtProdavacID, TextBox txtRacunOtpremnicaID, TextBox txtBrojRacunaOtpremnice, TextBox txtDatumIzdavanja, TextBox txtDatumPrometa, ComboBox cmbNacinPlacanja, ComboBox cmbPredracun, TextBox txtKupac, Form unosRacunOtpremnice)
        {

            if (string.IsNullOrWhiteSpace(txtBrojRacunaOtpremnice.Text) || string.IsNullOrWhiteSpace(txtDatumIzdavanja.Text) || string.IsNullOrWhiteSpace(txtDatumPrometa.Text) || string.IsNullOrWhiteSpace(txtProdavacID.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            racunOtpremnica = new RacunOtpremnica();

            racunOtpremnica.RacunOtpremnicaID = Convert.ToInt32(txtRacunOtpremnicaID.Text);

            string uneto = txtBrojRacunaOtpremnice.Text;

            bool proveraBrojRacunOtpremnice(string unet)
            {
                unet = uneto;
                foreach (char c in unet)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            if (proveraBrojRacunOtpremnice(txtBrojRacunaOtpremnice.ToString()) == true)
            {
                racunOtpremnica.BrojRacunaOtpremnice = Convert.ToInt32(txtBrojRacunaOtpremnice.Text);
            }
            else
            {
                MessageBox.Show("Unesite ispravno broj račun - otpremnice!");
                return;
            }



            racunOtpremnica.Predracun = (Predracun)cmbPredracun.SelectedItem;

            if (racunOtpremnica.Predracun == null)
            {
                MessageBox.Show("Izaberite predračun!\n");
                return;
            }

            else
            {
                racunOtpremnica.Kupac = new Kupac();
                racunOtpremnica.Kupac.KupacJMBG = racunOtpremnica.Predracun.Kupac.KupacJMBG;
            }

            try
            {
                racunOtpremnica.DatumIzdavanja = DateTime.ParseExact(txtDatumIzdavanja.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum izdavanja u formatu dd.MM.yyyy!");
                return;
            }

            try
            {
                racunOtpremnica.DatumPrometa = DateTime.ParseExact(txtDatumPrometa.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum prometa u formatu dd.MM.yyyy!");
                return;
            }

            racunOtpremnica.NacinPlacanja = (string)cmbNacinPlacanja.SelectedItem;
            if (cmbNacinPlacanja.SelectedItem == null)
            {
                MessageBox.Show("Izaberite način plaćanja!\n");
                return;
            }

            racunOtpremnica.Prodavac = new Prodavac();
            racunOtpremnica.Prodavac.ProdavacID = Convert.ToInt32(txtProdavacID.Text);
            if (txtProdavacID.Text == "")
            {
                MessageBox.Show("Unesite ID Prodavca!");
                return;
            }

            racunOtpremnica.ListaStavki = new BindingList<StavkaRacunaOtpremnice>(listaStavkiRacunaOtpremnice);

            if (racunOtpremnica.ListaStavki.Count < 1)
            {
                MessageBox.Show("Račun - otpremnica mora imati makar 1 stavku!\n");
                return;
            }

            
            string rez=Broker.dajSesiju().sacuvajRacunOtpremnicu(racunOtpremnica);
            if(rez== "Sistem je uspešno sačuvao račun-otpremnicu!")
            {
                MessageBox.Show(rez + "\nIme i prezime prodavca: " + Broker.dajSesiju().vratiImePrezimeProdavcaIzRacunOtpremnice(racunOtpremnica));
                unosRacunOtpremnice.Close();
                return;
            }
            else
            {
                MessageBox.Show(rez);
                txtProdavacID.Clear();
                txtProdavacID.Select();
                return;
            }
            
        }


        public void vratiImePrezimeProdavcaNaOsnovuID(TextBox txtProdavacID, Label lblImePrezimeProdavca, Form unosRacunOtpremnice)
        {
            try
            {
                int prodavacID = Convert.ToInt32(txtProdavacID.Text);
                string imePrezimeProdavca = Broker.dajSesiju().vratiImePrezimeProdavcaNaOsnovuID(prodavacID);
                lblImePrezimeProdavca.Text = imePrezimeProdavca;

            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da učita ime i prezime prodavca");
                return;
            }
        }

        public void vratiImePrezimeProdavcaNaOsnovuIDTextBox(TextBox txtProdavacID, TextBox txtImePrezimeProdavca, Form unosRacunOtpremnice)
        {
            try
            {
                int prodavacID = Convert.ToInt32(txtProdavacID.Text);
                string imePrezimeProdavca = Broker.dajSesiju().vratiImePrezimeProdavcaNaOsnovuID(prodavacID);
                txtImePrezimeProdavca.Text = imePrezimeProdavca;

            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da učita ime i prezime prodavca");
                return;
            }
        }

        public void VratiIDProdavca(ComboBox cmbProdavac, TextBox txtProdavacID, Form unosRacunOtpremnice)
        {
            try
            {
                Prodavac prodavac = cmbProdavac.SelectedItem as Prodavac;
                txtProdavacID.Text = prodavac.ProdavacID.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da učita ProdavacID");
                return;
            }
        }

        public void ObrisiStavkuRacunOtpremniceIzGrida(DataGridView dgvStavkeRacunaOtpremnice, Button btnObrisi, Form unosRacunOtpremnice)
        {
            try
            {
                stavkaRacunaOtpremnice = (StavkaRacunaOtpremnice)dgvStavkeRacunaOtpremnice.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite stavku račun - otpremnice!");
                return;
            }

            listaStavkiRacunaOtpremnice.Remove(stavkaRacunaOtpremnice);


        }

        public void DodajStavkuRacunOtpremnice(DataGridView dgvStavkeRacunaOtpremnice, DataGridView dgvVozilo, TextBox txtRacunOtpremnicaIDStavka, TextBox txtKolicina, TextBox txtVoziloID, Form unosStavkeRacunaOtpremnice)
        {
            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            stavkaRacunaOtpremnice = new StavkaRacunaOtpremnice();

            stavkaRacunaOtpremnice.RacunOtpremnicaID = Convert.ToInt32(txtRacunOtpremnicaIDStavka.Text);

            try
            {
                stavkaRacunaOtpremnice.Kolicina = Convert.ToInt32(txtKolicina.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neispravno uneta količina! " + ex.Message);
                return;
            }

            if (stavkaRacunaOtpremnice.Kolicina < 1)
            {
                MessageBox.Show("Količina mora biti pozitivna!");
                return;
            }

            try
            {
                vozilo = (Vozilo)dgvVozilo.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }

            if (txtVoziloID.Text == "")
            {
                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }
            else
            {
                stavkaRacunaOtpremnice.Vozilo = vozilo;
                stavkaRacunaOtpremnice.Vozilo.VoziloID = Convert.ToInt32(txtVoziloID.Text);
            }

            if (Broker.dajSesiju().postojiRacunOtpremnicaUBazi(stavkaRacunaOtpremnice.RacunOtpremnicaID))
            {
                Broker.dajSesiju().sacuvajStavkuRacunOtpremnice(stavkaRacunaOtpremnice);
                dgvStavkeRacunaOtpremnice.DataSource = Broker.dajSesiju().ucitajStavkeRacunOtpremniceZaOdredjenuRacunOtpremnicu(stavkaRacunaOtpremnice.RacunOtpremnicaID);
                MessageBox.Show("Sistem je uspešno sačuvao stavku račun-otpremnice!\n");
                unosStavkeRacunaOtpremnice.Close();
            }
            else
            {
                listaStavkiRacunaOtpremnice.Add(stavkaRacunaOtpremnice);
                dgvStavkeRacunaOtpremnice.DataSource = listaStavkiRacunaOtpremnice;
                MessageBox.Show("Stavka račun-otpremnice je dodata!\n");
                unosStavkeRacunaOtpremnice.Close();
            }

        }

        public void PostaviKupcaZaIzabraniPredracun(ComboBox cmbPredracun, TextBox txtKupac, Form unosRacunOtpremnice)
        {
            try
            {
                predracun = cmbPredracun.SelectedItem as Predracun;
                kupac = Broker.dajSesiju().ucitajKupcaZaOdredjeniPredracun(predracun);
                txtKupac.Text = kupac.ImePrezimeKupca.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Sistem ne može da učita kupca za dati predračun!\n" + ex.Message);
                unosRacunOtpremnice.Close();
                return;
            }
        }

        public void UcitajIDRacunaOtpremniceInicijalizujListu(TextBox txtRacunOtpremnicaID, Form unosRacunOtpremnice)
        {

            try
            {
                txtRacunOtpremnicaID.Text = Broker.dajSesiju().vratiIDRacunOtpremnice().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita RačunOtpremnicaID!\n" + ex.Message);
                unosRacunOtpremnice.Close();
                return;
            }
            racunOtpremnica = new RacunOtpremnica();
            listaStavkiRacunaOtpremnice = new BindingList<StavkaRacunaOtpremnice>();
        }

        public void UcitajPredracuneUDataGrid(DataGridView dgvPredracuni, Form prikazPredracuna)
        {
           
            try
            {
                dgvPredracuni.DataSource = new BindingList<Predracun>(Broker.dajSesiju().ucitajPredracune());
                dgvPredracuni.Columns[3].Width = 130;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita predračune!\n" + ex.Message);
                prikazPredracuna.Close();
                return;
            }
        }


        

        public void PopuniCMBNacinPlacanja(ComboBox cmbNacinPlacanja, Form unosPredracuna)
        {
            BindingList<string> listaNacinaPlacanja = new BindingList<string>();
            try
            {
           
                listaNacinaPlacanja.Add("Bezgotovinsko placanje");
                listaNacinaPlacanja.Add("Gotovinsko placanje");
                listaNacinaPlacanja.Add("Platna kartica");

                foreach (string np in listaNacinaPlacanja)
                {
                    cmbNacinPlacanja.Items.Add(np);
                }
                cmbNacinPlacanja.Text = "Izaberite način plaćanja!";
                cmbNacinPlacanja.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita načine plaćanja!\n" + ex.Message);
                unosPredracuna.Close();
                return;
            }
        }

        public void UcitajIDStavkePredracuna(TextBox txtStavkaPredracunaID, Form unosStavkePredracuna)
        {
            try
            {
                txtStavkaPredracunaID.Text = Broker.dajSesiju().vratiIDStavkePredracuna().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita StavkuPredračunaID!\n" + ex.Message);
                unosStavkePredracuna.Close();
                return;
            }
        }

        public void UcitajSvaVozila(DataGridView dgvVozilo, Form unosStavkePredracuna)
        {
            try
            {
                dgvVozilo.DataSource = new BindingList<Vozilo>(Broker.dajSesiju().ucitajSvaVozila());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita vozila!\n" + ex.Message);
                unosStavkePredracuna.Close();
                return;
            }
        }

        public void SacuvajPredracun(TextBox txtPredracunID, TextBox txtBrojPredracuna, TextBox txtDatumIzdavanja, TextBox txtDatumPrometa, ComboBox cmbNacinPlacanja, ComboBox cmbUgovor, ComboBox cmbProdavac, TextBox txtKupac, Form unosPredracuna)
        {

            if (string.IsNullOrWhiteSpace(txtBrojPredracuna.Text) || string.IsNullOrWhiteSpace(txtDatumIzdavanja.Text) || string.IsNullOrWhiteSpace(txtDatumPrometa.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            predracun = new Predracun();

            predracun.PredracunID = Convert.ToInt32(txtPredracunID.Text);

            try
            {
                BrojPredracuna bp = new BrojPredracuna();
                bp.Godina = Convert.ToInt32(txtBrojPredracuna.Text.Split('/')[0]);
                bp.RedniBroj = Convert.ToInt32(txtBrojPredracuna.Text.Split('/')[1]);
                predracun.BrojPredracuna = bp;
            }
            catch (Exception)
            {
                MessageBox.Show("Neispravno unet broj predračuna!\nIspravan format: (godina/redni broj)!\n");
                return;
            }

            
            predracun.Ugovor = (Ugovor)cmbUgovor.SelectedItem;
            if (predracun.Ugovor == null)
            {
                MessageBox.Show("Izaberite ugovor!\n");
                return;
            }
            else
            {
                predracun.Kupac = new Kupac();
                predracun.Kupac.KupacJMBG = predracun.Ugovor.Kupac.KupacJMBG;
            }

            try
            {
                predracun.DatumIzdavanja = DateTime.ParseExact(txtDatumIzdavanja.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum izdavanja u formatu dd.MM.yyyy!");
                return;
            }

            try
            {
                predracun.DatumPrometa = DateTime.ParseExact(txtDatumPrometa.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Unesite datum prometa u formatu dd.MM.yyyy!");
                return;
            }

            predracun.NacinPlacanja = (string)cmbNacinPlacanja.SelectedItem;
            if (predracun.NacinPlacanja == null)
            {
                MessageBox.Show("Izaberite način plaćanja!\n");
                return;
            }

            predracun.Prodavac = (Prodavac)cmbProdavac.SelectedItem;
            if(predracun.Prodavac==null)
            {
                MessageBox.Show("Izaberite prodavca!");
                return;
            }
            
            predracun.ListaStavki = new BindingList<StavkaPredracuna>(listaStavki);

            if (predracun.ListaStavki.Count < 1)
            {
                MessageBox.Show("Predračun mora imati makar 1 stavku!\n");
                return;
            }

            try
            {
                Broker.dajSesiju().sacuvajPredracun(predracun);
                MessageBox.Show("Sistem je uspešno sačuvao predračun!\nUkupan iznos predračuna: "+Broker.dajSesiju().ucitajUkupanIznosZaOdredjeniPredracun(predracun.PredracunID)+ " RSD");
                unosPredracuna.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da sačuva predračun!\n" + ex.Message);
                unosPredracuna.Close();
                return;
            }
        }

        public void ObrisiStavkuPredracunaIzGrida(DataGridView dgvStavkePredracuna, Button btnObrisi, Form unosPredracuna)
        {
            try
            {
                stavkaPredracuna = (StavkaPredracuna)dgvStavkePredracuna.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite stavku predračuna!");
                return;
            }

            listaStavki.Remove(stavkaPredracuna);

           
        }

        public void DodajStavkuPredracuna(DataGridView dgvStavkePredracuna, DataGridView dgvVozilo, TextBox txtPredracunID, TextBox txtKolicina, TextBox txtVoziloID, TextBox txtUkupanIznos, Form unosStavkePredracuna)
        {

            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            stavkaPredracuna = new StavkaPredracuna();

            stavkaPredracuna.PredracunID = Convert.ToInt32(txtPredracunID.Text);

            try
            {
                stavkaPredracuna.Kolicina = Convert.ToInt32(txtKolicina.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neispravno uneta količina! " + ex.Message);
                return;
            }

            if (stavkaPredracuna.Kolicina < 1)
            {
                MessageBox.Show("Kolicina mora biti pozitivna!");
                return;
            }

            try
            {
                vozilo = (Vozilo)dgvVozilo.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }

            if (txtVoziloID.Text == "")
            {
                MessageBox.Show("Izaberite željeno vozilo!");
                return;
            }
            else
            {
                stavkaPredracuna.Vozilo = vozilo;
                stavkaPredracuna.Vozilo.VoziloID = Convert.ToInt32(txtVoziloID.Text);
            }

            if (Broker.dajSesiju().postojiPredracunUBazi(stavkaPredracuna.PredracunID))
            {
                string rez=Broker.dajSesiju().sacuvajStavkuPredracuna(stavkaPredracuna);
                MessageBox.Show(rez);
                dgvStavkePredracuna.DataSource = Broker.dajSesiju().ucitajStavkePredracunaZaOdredjeniPredracun(stavkaPredracuna.PredracunID);
                txtUkupanIznos.Text = Broker.dajSesiju().ucitajUkupanIznosZaOdredjeniPredracun(stavkaPredracuna.PredracunID).ToString();
                unosStavkePredracuna.Close();
            }
            else
            {
                
                listaStavki.Add(stavkaPredracuna);
                dgvStavkePredracuna.DataSource = listaStavki;
                MessageBox.Show("Stavka predračuna je dodata!\n");
                unosStavkePredracuna.Close();
            }

        }

        public void IzaberiVozilo(DataGridView dgvVozilo, TextBox txtVoziloID, DataGridView dgvOprema, Form unosStavkePredracuna)
        {
            vozilo = new Vozilo();
            try
            {
                vozilo = (Vozilo)dgvVozilo.CurrentRow.DataBoundItem;
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite vozilo!");
                return;
            }

            txtVoziloID.Text = vozilo.VoziloID.ToString();
            dgvOprema.DataSource = new BindingList<Oprema>(Broker.dajSesiju().ucitajListuOpremeZaOdredjenoVozilo(vozilo.VoziloID));

        }

        public void UcitajIDPredracunaInicijalizujListu(TextBox txtPredracunID, Form unosPredracuna)
        {
            try
            {
                txtPredracunID.Text = Broker.dajSesiju().vratiIDPredracuna().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita PredračunID!\n" + ex.Message);
                unosPredracuna.Close();
                return;
            }
            predracun = new Predracun();
            listaStavki = new BindingList<StavkaPredracuna>();
        }

        public void PostaviKupcaZaIzabraniUgovor(ComboBox cmbUgovor, TextBox txtKupac, Form unosPredracuna)
        {
            try
            {
                ugovor = cmbUgovor.SelectedItem as Ugovor;
                kupac = Broker.dajSesiju().ucitajKupcaZaOdredjeniUgovor(ugovor);
                txtKupac.Text = kupac.ImePrezimeKupca.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Sistem ne može da učita kupca za dati ugovor!\n" + ex.Message);
                unosPredracuna.Close();
                return;
            }
        }

        public void UcitajSveProdavce(ComboBox cmbProdavac, Form unosPredracuna)
        {
            try
            {
                foreach (Prodavac p in Broker.dajSesiju().ucitajSveProdavce())
                {
                    cmbProdavac.Items.Add(p);
                }
                cmbProdavac.Text = "Izaberite odgovarajućeg prodavca!";
                cmbProdavac.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita prodavce!\n" + ex.Message);
                unosPredracuna.Close();
                return;
            }
        }

        public void UcitajUgovoreZaComboBox(ComboBox cmbUgovor, Form unosPredracuna)
        {
            try
            {
                foreach (Ugovor u in Broker.dajSesiju().ucitajUgovoreZaComboBox())
                {
                    cmbUgovor.Items.Add(u);
                }
                cmbUgovor.Text = "Izaberite odgovarajući ugovor!";
                cmbUgovor.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita ugovore!\n" + ex.Message);
                unosPredracuna.Close();
                return;
            }
        }


    }
}
