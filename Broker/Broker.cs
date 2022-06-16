using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using System.Data;
using System.Data.SqlClient;

namespace Server
{
    public class Broker
    {
        SqlCommand komanda;
        SqlConnection konekcija;
        SqlTransaction transakcija;

        void konektujSe()
        {
            konekcija = new SqlConnection(@"Data Source=DESKTOP-C03SIAQ\SQLEXPRESS;Initial Catalog=MaloprodajaVozilaBaza;Integrated Security=True");
            komanda = konekcija.CreateCommand();
        }

        Broker()
        {
            konektujSe();
        }

        static Broker instanca;
        public static Broker dajSesiju()
        {
            if (instanca == null) instanca = new Broker();
            return instanca;
        }

        public List<Ugovor> ucitajUgovoreZaComboBox()
        {
            List<Ugovor> lista = new List<Ugovor>();
            
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Ugovor";
                SqlDataReader citac = komanda.ExecuteReader();
                
                while (citac.Read())
                {
                    Ugovor u = new Ugovor();
                    u.UgovorID = citac.GetInt32(0);
                    u.BrojUgovora = citac.GetInt32(1);
                    u.DatumPotpisivanja = Convert.ToDateTime(citac.GetValue(2));
                    u.Narudzbenica = new Narudzbenica();
                    u.Narudzbenica.NarudzbenicaID = citac.GetInt32(3);
                    u.Kupac = new Kupac();
                    u.Kupac.KupacJMBG = citac.GetString(4);
                    u.Prodavac = new Prodavac();
                    u.Prodavac.ProdavacID = citac.GetInt32(5);

                    lista.Add(u);
                }
                
                citac.Close();
                
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Prodavac> ucitajSveProdavce()
        {
            List<Prodavac> lista = new List<Prodavac>();
            
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Prodavac";
                SqlDataReader citac = komanda.ExecuteReader();
                
                while (citac.Read())
                {
                    Prodavac p = new Prodavac();
                    p.ProdavacID = citac.GetInt32(0);
                    p.ImePrezimeProdavca = citac.GetString(1);

                    lista.Add(p);
                }
                
                citac.Close();
                
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Kupac> ucitajSveKupce()
        {
            List<Kupac> lista = new List<Kupac>();
            
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Kupac";
                SqlDataReader citac = komanda.ExecuteReader();
                
                while (citac.Read())
                {
                    Kupac k = new Kupac();
                    k.KupacJMBG = citac.GetString(0);
                    k.ImePrezimeKupca = citac.GetString(1);
                    k.Adresa = new Adresa();
                    k.Adresa.MestoID = citac.GetInt32(2);
                    k.Adresa.AdresaID = citac.GetInt32(3);

                    lista.Add(k);
                }
                
                citac.Close();
                
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiIDPredracuna()
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select max(PredracunID) from Predracun";
                
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }

            }
            catch (Exception)
            {
                throw;
            }
            
            finally
            {
                konekcija.Close();
            }
        }

        public Kupac ucitajKupcaZaOdredjeniUgovor(Ugovor u)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Kupac k inner join Ugovor u on u.KupacJMBG=k.KupacJMBG where u.UgovorID="+u.UgovorID+"";
                SqlDataReader citac = komanda.ExecuteReader();
                
                if (citac.Read())
                {
                    Kupac k = new Kupac();
                    k.KupacJMBG = citac.GetString(0);
                    k.ImePrezimeKupca = citac.GetString(1);

                    return k;
                }
                
                citac.Close();
                
                return null;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public Kupac ucitajKupcaZaOdredjenuNarudzbenicu(Narudzbenica n)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Kupac k inner join Narudzbenica n on n.KupacJMBG=k.KupacJMBG where n.NarudzbenicaID=" + n.NarudzbenicaID + "";
                SqlDataReader citac = komanda.ExecuteReader();
                
                if (citac.Read())
                {
                    Kupac k = new Kupac();
                    k.KupacJMBG = citac.GetString(0);
                    k.ImePrezimeKupca = citac.GetString(1);

                    return k;
                }
                
                citac.Close();
                
                return null;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }


        public List<Vozilo> ucitajSvaVozila()
        {
            List<Vozilo> lista = new List<Vozilo>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Vozilo";
                SqlDataReader citac = komanda.ExecuteReader();
                
                while (citac.Read())
                {
                    Vozilo v = new Vozilo();
                    v.VoziloID = citac.GetInt32(0);
                    v.NazivVozila = citac.GetString(1);
                    v.NazivModela = citac.GetString(2);
                    v.BrojVrata = citac.GetInt32(3);
                    v.SnagaMotora = citac.GetInt32(4);
                    v.VrstaMenjaca = citac.GetString(5);
                    v.TipVozila = citac.GetString(6);

                    lista.Add(v);
                }
                
                citac.Close();
                
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Oprema> ucitajListuOpremeZaOdredjenoVozilo(int voziloID)
        {
            List<Oprema> lista = new List<Oprema>();
            
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from DeoVozila dv inner join Oprema o on dv.OpremaID=o.OpremaID where VoziloID=" + voziloID + "";
                SqlDataReader citac = komanda.ExecuteReader();
                
                while (citac.Read())
                {
                    Oprema o = new Oprema();
                    o.NazivOpreme = citac.GetString(5);
                    o.Opis = citac.GetString(6);

                    lista.Add(o);
                }
                
                citac.Close();
                
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }


        public int vratiIDStavkePredracuna()
        {
            try
            {
                komanda.CommandText = "Select max(StavkaPredracunaID) from StavkaPredracuna";
                
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public double ucitajCenuZaOdredjenoVozilo(int voziloID)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select cv.Iznos from CenaVozila cv inner join Vozilo v on cv.VoziloID=v.VoziloID where v.VoziloID=" + voziloID + "";
                SqlDataReader citac = komanda.ExecuteReader();

                if (citac.Read())
                {
                    double cena = new double();
                    cena = Convert.ToDouble(citac.GetValue(0));

                    return cena;
                }
                
                citac.Close();
                
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }
        

        public void sacuvajPredracun(Predracun predracun)
        {
            try
            {
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);

                komanda.CommandText = "Insert into Predracun (PredracunID, BrojPredracuna, DatumIzdavanja, DatumPrometa, NacinPlacanja, UgovorID, ProdavacID, KupacJMBG) values (" + predracun.PredracunID + ",'" + predracun.BrojPredracuna + "','" + predracun.DatumIzdavanja.ToString("yyyy-MM-dd") + "','" + predracun.DatumPrometa.ToString("yyyy-MM-dd") + "','" + predracun.NacinPlacanja + "'," + predracun.Ugovor.UgovorID + "," + predracun.Prodavac.ProdavacID + ",'"+predracun.Kupac.KupacJMBG+"')";
                komanda.ExecuteNonQuery();

                foreach (StavkaPredracuna sp in predracun.ListaStavki)
                {
                    sp.StavkaPredracunaID = vratiIDStavkePredracuna();

                    komanda.CommandText = "Insert into StavkaPredracuna values(" + predracun.PredracunID + "," + sp.StavkaPredracunaID + "," + sp.Kolicina + "," + sp.Vozilo.VoziloID + ")";
                    komanda.ExecuteNonQuery();
                }
                
                transakcija.Commit();

            }
            catch (Exception)
            {
                transakcija.Rollback();

            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }
        
        public List<Predracun> ucitajPredracune()
        {
            List<Predracun> lista = new List<Predracun>();
            
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Predracun p inner join Prodavac pr on p.ProdavacID=pr.ProdavacID inner join Kupac k on p.KupacJMBG=k.KupacJMBG";
                SqlDataReader citac = komanda.ExecuteReader();
                
                while (citac.Read())
                {
                    Predracun p = new Predracun();
                    p.PredracunID = citac.GetInt32(0);
                    p.BrojPredracuna = (BrojPredracuna)citac["BrojPredracuna"];
                    p.DatumIzdavanja = (DateTime)citac["DatumIzdavanja"];
                    p.DatumPrometa = (DateTime)citac["DatumPrometa"];
                    p.NacinPlacanja = citac.GetString(4);
                    p.Ugovor = new Ugovor();
                    p.Ugovor.UgovorID = citac.GetInt32(5);
                    p.Prodavac = new Prodavac();
                    p.Prodavac.ProdavacID = citac.GetInt32(6);
                    p.Prodavac.ImePrezimeProdavca = citac.GetString(10);
                    p.Kupac = new Kupac();
                    p.Kupac.KupacJMBG = citac.GetString(7);
                    p.Kupac.ImePrezimeKupca = citac.GetString(12);
                    p.UkupanIznos = Convert.ToDouble(citac.GetValue(8));
                    
                    lista.Add(p);
                }
                
                citac.Close();
                
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Predracun> ucitajPredracuneZaKriterijum(string kriterijum)
        {
            List<Predracun> lista = new List<Predracun>();
            
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Predracun p inner join Prodavac pr on p.ProdavacID=pr.ProdavacID inner join Kupac k on p.KupacJMBG=k.KupacJMBG where k.ImePrezimeKupca like '%" + kriterijum + "%' or p.NacinPlacanja like '%" + kriterijum + "%' or pr.ImePrezimeProdavca like '%" + kriterijum + "%'";
                SqlDataReader citac = komanda.ExecuteReader();
                
                while (citac.Read())
                {
                    Predracun p = new Predracun();
                    p.PredracunID = citac.GetInt32(0);
                    p.BrojPredracuna = (BrojPredracuna)citac["BrojPredracuna"];
                    p.DatumIzdavanja = (DateTime)citac["DatumIzdavanja"];
                    p.DatumPrometa = (DateTime)citac["DatumPrometa"];
                    p.NacinPlacanja = citac.GetString(4);
                    p.Ugovor = new Ugovor();
                    p.Ugovor.UgovorID = citac.GetInt32(5);
                    p.Prodavac = new Prodavac();
                    p.Prodavac.ProdavacID = citac.GetInt32(6);
                    p.Prodavac.ImePrezimeProdavca = citac.GetString(10);
                    p.Kupac = new Kupac();
                    p.Kupac.KupacJMBG = citac.GetString(7);
                    p.Kupac.ImePrezimeKupca = citac.GetString(12);
                    p.UkupanIznos = Convert.ToDouble(citac.GetValue(8));

                    lista.Add(p);
                }
                
                citac.Close();
                
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Predracun> ucitajPredracuneZaBrojPredracuna(BrojPredracuna bp)
        {
            List<Predracun> lista = new List<Predracun>();
            
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Predracun p inner join Prodavac pr on p.ProdavacID=pr.ProdavacID inner join Kupac k on p.KupacJMBG=k.KupacJMBG where p.BrojPredracuna.Godina="+bp.Godina+" and BrojPredracuna.RedniBroj="+bp.RedniBroj+"";
                SqlDataReader citac = komanda.ExecuteReader();
                
                while (citac.Read())
                {
                    Predracun p = new Predracun();
                    p.PredracunID = citac.GetInt32(0);
                    p.BrojPredracuna = (BrojPredracuna)citac["BrojPredracuna"];
                    p.DatumIzdavanja = (DateTime)citac["DatumIzdavanja"];
                    p.DatumPrometa = (DateTime)citac["DatumPrometa"];
                    p.NacinPlacanja = citac.GetString(4);
                    p.Ugovor = new Ugovor();
                    p.Ugovor.UgovorID = citac.GetInt32(5);
                    p.Prodavac = new Prodavac();
                    p.Prodavac.ProdavacID = citac.GetInt32(6);
                    p.Prodavac.ImePrezimeProdavca = citac.GetString(10);
                    p.Kupac = new Kupac();
                    p.Kupac.KupacJMBG = citac.GetString(7);
                    p.Kupac.ImePrezimeKupca = citac.GetString(12);
                    p.UkupanIznos = Convert.ToDouble(citac.GetValue(8));

                    lista.Add(p);
                }
                
                citac.Close();
                
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }


        public int vratiIDRacunOtpremnice()
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select max(RacunOtpremnicaID) from RacunOtpremnica";
                
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                konekcija.Close();

            }
        }

        public Kupac ucitajKupcaZaOdredjeniPredracun(Predracun p)
        {

            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Kupac k inner join Predracun p on p.KupacJMBG=k.KupacJMBG where p.PredracunID=" + p.PredracunID + "";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {
                    Kupac k = new Kupac();
                    k.KupacJMBG = citac.GetString(0);
                    k.ImePrezimeKupca = citac.GetString(1);


                    return k;
                }
                citac.Close();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }


        public int vratiIDStavkeRacunOtpremnice()
        {
            try
            {

                komanda.CommandText = "Select max(StavkaRacunaOtpremniceID) from StavkaRacunaOtpremnice";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }



        }


        public string sacuvajRacunOtpremnicu(RacunOtpremnica racunOtpremnica)
        {
            try
            {
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);

                komanda.CommandText = "Insert into RacunOtpremnica (RacunOtpremnicaID, BrojRacunaOtpremnice, DatumIzdavanja, DatumPrometa, NacinPlacanja, PredracunID, ProdavacID, KupacJMBG) values (" + racunOtpremnica.RacunOtpremnicaID + "," + racunOtpremnica.BrojRacunaOtpremnice + ",'" + racunOtpremnica.DatumIzdavanja.ToString("yyyy-MM-dd") + "','" + racunOtpremnica.DatumPrometa.ToString("yyyy-MM-dd") + "','" + racunOtpremnica.NacinPlacanja + "'," + racunOtpremnica.Predracun.PredracunID + "," + racunOtpremnica.Prodavac.ProdavacID + ",'" + racunOtpremnica.Kupac.KupacJMBG + "')";
                komanda.ExecuteNonQuery();

                foreach (StavkaRacunaOtpremnice sro in racunOtpremnica.ListaStavki)
                {
                    sro.StavkaRacunaOtpremniceID = vratiIDStavkeRacunOtpremnice();

                    komanda.CommandText = "Insert into StavkaRacunaOtpremnice values(" + racunOtpremnica.RacunOtpremnicaID + "," + sro.StavkaRacunaOtpremniceID + "," + sro.Kolicina + "," + sro.Vozilo.VoziloID + ")";
                    komanda.ExecuteNonQuery();
                }
                transakcija.Commit();
                return "Sistem je uspešno sačuvao račun-otpremnicu!";

            }
            catch (Exception ex)
            {

                transakcija.Rollback();
                return "Sistem ne može da sačuva račun otpremnicu!\nGreška:\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string vratiImePrezimeProdavcaNaOsnovuID(int prodavacID)
        {
            
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Prodavac where ProdavacID='"+prodavacID+"'";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {
                    
                    return citac.GetString(1);
                }
                citac.Close();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

       

        public List<RacunOtpremnica> ucitajRacunOtpremnice()
        {
            List<RacunOtpremnica> lista = new List<RacunOtpremnica>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from RacunOtpremnica ro inner join Kupac k on ro.KupacJMBG=k.KupacJMBG";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    RacunOtpremnica ro = new RacunOtpremnica();
                    ro.RacunOtpremnicaID = citac.GetInt32(0);
                    ro.BrojRacunaOtpremnice = citac.GetInt32(1);
                    ro.DatumIzdavanja = (DateTime)citac["DatumIzdavanja"];
                    ro.DatumPrometa = (DateTime)citac["DatumPrometa"];
                    ro.NacinPlacanja = citac.GetString(4);
                    ro.Prodavac = new Prodavac();
                    ro.Prodavac.ImePrezimeProdavca = citac.GetString(5);
                    ro.Prodavac.ProdavacID = citac.GetInt32(7);
                    ro.Predracun = new Predracun();
                    ro.Predracun.PredracunID = citac.GetInt32(6);
                    ro.Kupac = new Kupac();
                    ro.Kupac.KupacJMBG = citac.GetString(8);
                    ro.Kupac.ImePrezimeKupca = citac.GetString(10);

                    lista.Add(ro);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Ugovor> ucitajUgovoreUDataGrid()
        {
            List<Ugovor> lista = new List<Ugovor>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Ugovor u inner join Kupac k on u.KupacJMBG=k.KupacJMBG inner join Prodavac p on u.ProdavacID=p.ProdavacID";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Ugovor u = new Ugovor();
                    u.UgovorID = citac.GetInt32(0);
                    u.BrojUgovora = citac.GetInt32(1);
                    u.DatumPotpisivanja = Convert.ToDateTime(citac.GetValue(2));
                    u.Narudzbenica = new Narudzbenica();
                    u.Narudzbenica.NarudzbenicaID = citac.GetInt32(3);
                    u.Kupac = new Kupac();
                    u.Kupac.KupacJMBG = citac.GetString(4);
                    u.Prodavac = new Prodavac();
                    u.Prodavac.ProdavacID = citac.GetInt32(5);
                    u.Kupac.ImePrezimeKupca = citac.GetString(7);
                    u.Prodavac.ImePrezimeProdavca = citac.GetString(11);
                  
                    lista.Add(u);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiIDUgovora()
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select max(UgovorID) from Ugovor";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                konekcija.Close();

            }
        }

        public List<Narudzbenica> ucitajNarudzbenice()
        {
            List<Narudzbenica> lista = new List<Narudzbenica>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Narudzbenica";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Narudzbenica n = new Narudzbenica();
                    n.NarudzbenicaID = citac.GetInt32(0);
                    n.BrojNarudzbenice = citac.GetInt32(1);
                    n.NacinIsporuke = citac.GetString(2);
                    n.NacinPlacanja = citac.GetString(3);
                    n.Ponuda = new Ponuda();
                    n.Ponuda.PonudaID = citac.GetInt32(4);
                    n.Kupac = new Kupac();
                    n.Kupac.KupacJMBG = citac.GetString(5);


                    lista.Add(n);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiIDClanaUgovora()
        {
            try
            {
              
                komanda.CommandText = "Select max(ClanUgovoraID) from ClanUgovora";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }


        }




        public void sacuvajUgovor(Ugovor ugovor)
        {
            try
            {
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);

                komanda.CommandText = "Insert into Ugovor values (" + ugovor.UgovorID + "," + ugovor.BrojUgovora + ",'" + ugovor.DatumPotpisivanja.ToString("yyyy-MM-dd") + "'," + ugovor.Narudzbenica.NarudzbenicaID+",'"+ugovor.Kupac.KupacJMBG+"',"+ugovor.Prodavac.ProdavacID+")";
                komanda.ExecuteNonQuery();

                foreach (ClanUgovora cu in ugovor.ListaClanovaUgovora)
                {
                    cu.ClanUgovoraID = vratiIDClanaUgovora();

                    komanda.CommandText = "Insert into ClanUgovora values(" + ugovor.UgovorID + "," + cu.ClanUgovoraID + ",'" + cu.NazivClanaUgovora + "','" + cu.OpisClanaUgovora + "')";
                    komanda.ExecuteNonQuery();
                }
                transakcija.Commit();

            }
            catch (Exception)
            {

                transakcija.Rollback();

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        
        public List<Ugovor> ucitajUgovoreZaKriterijum(string kriterijum)
        {
            List<Ugovor> lista = new List<Ugovor>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Ugovor u inner join Prodavac pr on u.ProdavacID=pr.ProdavacID inner join Kupac k on u.KupacJMBG=k.KupacJMBG where k.ImePrezimeKupca like '%" + kriterijum + "%' or pr.ImePrezimeProdavca like '%" + kriterijum + "%'";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Ugovor u = new Ugovor();
                    u.UgovorID = citac.GetInt32(0);
                    u.BrojUgovora = citac.GetInt32(1);
                    u.DatumPotpisivanja = (DateTime)citac["DatumPotpisivanja"];
                    u.Narudzbenica = new Narudzbenica();
                    u.Narudzbenica.NarudzbenicaID = citac.GetInt32(3);
                    u.Kupac = new Kupac();
                    u.Kupac.KupacJMBG = citac.GetString(4);
                    u.Kupac.ImePrezimeKupca = citac.GetString(9);
                    u.Prodavac = new Prodavac();
                    u.Prodavac.ProdavacID = citac.GetInt32(5);
                    u.Prodavac.ImePrezimeProdavca = citac.GetString(7);


                    lista.Add(u);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Ugovor> ucitajUgovoreZaBrojUgovora(int kriterijumBrojUgovora)
        {
            List<Ugovor> lista = new List<Ugovor>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Ugovor u inner join Prodavac pr on u.ProdavacID=pr.ProdavacID inner join Kupac k on u.KupacJMBG=k.KupacJMBG where u.BrojUgovora="+kriterijumBrojUgovora+"";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Ugovor u = new Ugovor();
                    u.UgovorID = citac.GetInt32(0);
                    u.BrojUgovora = citac.GetInt32(1);
                    u.DatumPotpisivanja = (DateTime)citac["DatumPotpisivanja"];
                    u.Narudzbenica = new Narudzbenica();
                    u.Narudzbenica.NarudzbenicaID = citac.GetInt32(3);
                    u.Kupac = new Kupac();
                    u.Kupac.KupacJMBG = citac.GetString(4);
                    u.Kupac.ImePrezimeKupca = citac.GetString(9);
                    u.Prodavac = new Prodavac();
                    u.Prodavac.ProdavacID = citac.GetInt32(5);
                    u.Prodavac.ImePrezimeProdavca = citac.GetString(7);


                    lista.Add(u);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void ObrisiUgovor(Ugovor ugovor)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from Ugovor where UgovorID = " + ugovor.UgovorID + "";
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public void ObrisiClanoveUgovora(Ugovor ugovor)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from ClanUgovora where UgovorID = '" + ugovor.UgovorID + "'";
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public List<Particije> ucitajParticije()
        {
            List<Particije> lista = new List<Particije>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select distinct p.partition_number as PartitionNumber, " +
                    "f.name as PartitionFilegroup, " +
                    "p.rows as NumberOfRows " +
                    "from sys.partitions p " +
                    "join sys.destination_data_spaces dds on p.partition_number = dds.destination_id " +
                    "join sys.filegroups f on dds.data_space_id = f.data_space_id " +
                    "where OBJECT_NAME(OBJECT_ID) = 'UgovorParticije' order by PartitionNumber";

                SqlDataReader r = komanda.ExecuteReader();

                while (r.Read())
                {
                    Particije p = new Particije();
                    p.Broj = (int)r["PartitionNumber"];
                    p.NazivParticije = r["PartitionFilegroup"].ToString();
                    if (p.NazivParticije == "January" || p.NazivParticije == "February" || p.NazivParticije == "March" || p.NazivParticije == "April" || p.NazivParticije == "May" || p.NazivParticije == "June" || p.NazivParticije == "July"
                        || p.NazivParticije == "August" || p.NazivParticije == "September" || p.NazivParticije == "October" || p.NazivParticije == "November" || p.NazivParticije == "December")
                        lista.Add(p);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

       
        public List<UgovorParticije> ucitajUgovoreZaParticiju(Particije part)
        {
            List<UgovorParticije> listaUgovora = new List<UgovorParticije>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from UgovorParticije where $PARTITION.PartitioningByMonth(DatumPotpisivanja) = " + part.Broj;

                SqlDataReader r = komanda.ExecuteReader();

                while (r.Read())
                {
                    UgovorParticije up = new UgovorParticije();
                    up.DatumPotpisivanja = (DateTime)r["DatumPotpisivanja"];
                    up.BrojUgovora = r.GetInt32(1);
                    up.NarudzbenicaID = r.GetInt32(2);
                    up.KupacJMBG = r.GetString(3);
                    up.ProdavacID = r.GetInt32(4);
                    listaUgovora.Add(up);
                }
                return listaUgovora;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public List<ClanUgovora> ucitajClanoveUgovoraZaOdredjeniUgovor(int ugovorID)
        {
            List<ClanUgovora> lista = new List<ClanUgovora>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from ClanUgovora where UgovorID="+ugovorID+"";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    ClanUgovora cu = new ClanUgovora();
                    cu.UgovorID = citac.GetInt32(0);
                    cu.ClanUgovoraID = citac.GetInt32(1);
                    cu.NazivClanaUgovora = citac.GetString(2);
                    cu.OpisClanaUgovora = citac.GetString(3);
                    

                    lista.Add(cu);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

       public string izmeniClanUgovora(ClanUgovora cu)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Update ClanUgovora set NazivClanaUgovora='"+cu.NazivClanaUgovora+"', OpisClanaUgovora='"+cu.OpisClanaUgovora+"' where UgovorID="+cu.UgovorID+" and ClanUgovoraID="+cu.ClanUgovoraID+"";
                komanda.ExecuteNonQuery();
                return "Sistem je izmenio član ugovora!";

            }
            catch (Exception ex)
            {
                return "Sistem ne može da izmeni član ugovora!" + ex.Message;
               
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void izmeniUgovor(Ugovor u)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Update Ugovor set BrojUgovora=" + u.BrojUgovora + ", DatumPotpisivanja='" + u.DatumPotpisivanja.ToString("yyyy-MM-dd") + "', NarudzbenicaID="+u.Narudzbenica.NarudzbenicaID+", KupacJMBG='"+u.Kupac.KupacJMBG+"', ProdavacID="+u.Prodavac.ProdavacID+" where UgovorID=" + u.UgovorID + "";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void obrisiClanUgovora(ClanUgovora cu)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Delete from ClanUgovora where UgovorID="+cu.UgovorID+" and ClanUgovoraID="+cu.ClanUgovoraID+"";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public bool postojiUgovorUBazi(int ugovorID)
        {

            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Ugovor where UgovorID='" + ugovorID + "'";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {

                    return true;
                }
                citac.Close();
                return false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void sacuvajClanUgovora(ClanUgovora cu)
        {
            try
            {
                konekcija.Open();
                cu.ClanUgovoraID = vratiIDClanaUgovora();
                komanda.CommandText = "Insert into ClanUgovora values(" + cu.UgovorID + "," + cu.ClanUgovoraID + ",'" + cu.NazivClanaUgovora + "','" + cu.OpisClanaUgovora + "')";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiIDProdavca()
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select max(ProdavacID) from Prodavac";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                konekcija.Close();

            }


        }

        public void sacuvajProdavca(Prodavac p)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Insert into Prodavac values("+p.ProdavacID+",'"+p.ImePrezimeProdavca+"') ";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void izmeniProdavca(Prodavac p)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update Prodavac set ImePrezimeProdavca='" + p.ImePrezimeProdavca + "' where ProdavacID=" + p.ProdavacID + "";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string obrisiProdavca(Prodavac p)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from Prodavac where ProdavacID="+p.ProdavacID+"";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno obrisao prodavca!\n";

            }
            catch (Exception ex)
            {
                return "Sistem ne može da obriše prodavca!\n"+ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Prodavac> ucitajProdavceNaOsnovuImenaPrezimena(string kriterijum)
        {
            List<Prodavac> lista = new List<Prodavac>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Prodavac where ImePrezimeProdavca like '%" + kriterijum + "%'";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Prodavac p = new Prodavac();
                    p.ProdavacID = citac.GetInt32(0);
                    p.ImePrezimeProdavca = citac.GetString(1);

                    lista.Add(p);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public bool postojiProdavacUBazi(int prodavacID)
        {

            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Prodavac where ProdavacID='" + prodavacID + "'";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {

                    return true;
                }
                citac.Close();
                return false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<RacunOtpremnica> ucitajRacunOtpremniceZaKriterijum(string kriterijum)
        {
            List<RacunOtpremnica> lista = new List<RacunOtpremnica>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from RacunOtpremnica ro inner join Kupac k on ro.KupacJMBG=k.KupacJMBG where k.ImePrezimeKupca like '%" + kriterijum + "%' or ro.NacinPlacanja like '%" + kriterijum + "%' or ImePrezimeProdavca like '%" + kriterijum + "%'";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    RacunOtpremnica ro = new RacunOtpremnica();
                    ro.RacunOtpremnicaID = citac.GetInt32(0);
                    ro.BrojRacunaOtpremnice = citac.GetInt32(1);
                    ro.DatumIzdavanja = (DateTime)citac["DatumIzdavanja"];
                    ro.DatumPrometa = (DateTime)citac["DatumPrometa"];
                    ro.NacinPlacanja = citac.GetString(4);
                    ro.Prodavac = new Prodavac();
                    ro.Prodavac.ImePrezimeProdavca = citac.GetString(5);
                    ro.Prodavac.ProdavacID = citac.GetInt32(7);
                    ro.Predracun = new Predracun();
                    ro.Predracun.PredracunID = citac.GetInt32(6);
                    ro.Kupac = new Kupac();
                    ro.Kupac.KupacJMBG = citac.GetString(8);
                    ro.Kupac.ImePrezimeKupca = citac.GetString(10);

                    lista.Add(ro);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void ObrisiStavkeRacunOtpremnice(RacunOtpremnica racunOtpremnica)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from StavkaRacunaOtpremnice where RacunOtpremnicaID = '" + racunOtpremnica.RacunOtpremnicaID + "'";
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public void ObrisiRacunOtpremnicu(RacunOtpremnica racunOtpremnica)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from RacunOtpremnica where RacunOtpremnicaID = " + racunOtpremnica.RacunOtpremnicaID + "";
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public List<StavkaRacunaOtpremnice> ucitajStavkeRacunOtpremniceZaOdredjenuRacunOtpremnicu(int racunOtpremnicaID)
        {
            List<StavkaRacunaOtpremnice> lista = new List<StavkaRacunaOtpremnice>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from StavkaRacunaOtpremnice sro inner join Vozilo v on sro.VoziloID=v.VoziloID where sro.RacunOtpremnicaID=" + racunOtpremnicaID + "";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    StavkaRacunaOtpremnice sro = new StavkaRacunaOtpremnice();
                    sro.RacunOtpremnicaID = citac.GetInt32(0);
                    sro.StavkaRacunaOtpremniceID = citac.GetInt32(1);
                    sro.Kolicina= citac.GetInt32(2);
                    sro.Vozilo = new Vozilo();
                    sro.Vozilo.VoziloID = citac.GetInt32(3);
                    sro.Vozilo.NazivVozila = citac.GetString(5);
                    sro.Vozilo.NazivModela = citac.GetString(6);


                    lista.Add(sro);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void obrisiStavkuRacunOtpremnice(StavkaRacunaOtpremnice sro)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Delete from StavkaRacunaOtpremnice where RacunOtpremnicaID=" + sro.RacunOtpremnicaID + " and StavkaRacunaOtpremniceID=" + sro.StavkaRacunaOtpremniceID + "";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void izmeniStavkuRacunOtpremnice(StavkaRacunaOtpremnice sro)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Update StavkaRacunaOtpremnice set Kolicina="+sro.Kolicina+", VoziloID="+sro.Vozilo.VoziloID+" where RacunOtpremnicaID=" + sro.RacunOtpremnicaID + " and StavkaRacunaOtpremniceID=" + sro.StavkaRacunaOtpremniceID + "";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string izmeniRacunOtpremnicu(RacunOtpremnica ro)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update RacunOtpremnica set BrojRacunaOtpremnice=" + ro.BrojRacunaOtpremnice + ", DatumIzdavanja='" + ro.DatumIzdavanja.ToString("yyyy-MM-dd") + "', DatumPrometa='" + ro.DatumPrometa.ToString("yyyy-MM-dd") + "', NacinPlacanja='" + ro.NacinPlacanja + "',  PredracunID=" + ro.Predracun.PredracunID + ", ProdavacID=" + ro.Prodavac.ProdavacID + ", KupacJMBG='" + ro.Kupac.KupacJMBG + "' where RacunOtpremnicaID=" + ro.RacunOtpremnicaID + "";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno izmenio račun-otpremnicu!";
            }
            catch (Exception ex)
            {
                return "Sistem ne može da izmeni račun-otpremnicu!\nGreška:\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string izmeniRacunOtpremnicuImePrezimeProdavca(RacunOtpremnica ro)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update RacunOtpremnica set ImePrezimeProdavca='"+ro.Prodavac.ImePrezimeProdavca+"' where RacunOtpremnicaID=" + ro.RacunOtpremnicaID + "";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno izmenio račun-otpremnicu!";
            }
            catch (Exception ex)
            {
                return "Sistem ne može da izmeni račun-otpremnicu!\nNije dozvoljeno direktno menjanje imena i prezimena prodavca!\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public bool postojiRacunOtpremnicaUBazi(int racunOtpremnicaID)
        {

            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from RacunOtpremnica where RacunOtpremnicaID=" + racunOtpremnicaID + "";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {

                    return true;
                }
                citac.Close();
                return false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void sacuvajStavkuRacunOtpremnice(StavkaRacunaOtpremnice sro)
        {
            try
            {
                konekcija.Open();
                sro.StavkaRacunaOtpremniceID= vratiIDStavkeRacunOtpremnice();
                komanda.CommandText = "Insert into StavkaRacunaOtpremnice values(" + sro.RacunOtpremnicaID + "," + sro.StavkaRacunaOtpremniceID + "," + sro.Kolicina + "," + sro.Vozilo.VoziloID + ")";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiIDPonude()
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select max(PonudaID) from Ponuda_pogled";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                konekcija.Close();

            }


        }

        public List<Katalog> ucitajSveKataloge()
        {
            List<Katalog> lista = new List<Katalog>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Katalog";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Katalog k = new Katalog();
                    k.KatalogID = citac.GetInt32(0);
                    k.DatumOd = (DateTime)citac.GetValue(1);
                    k.DatumDo = (DateTime)citac.GetValue(2);

                    lista.Add(k);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public bool postojiPonudaUBazi(int ponudaID)
        {

            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Ponuda where PonudaID='" + ponudaID + "'";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {

                    return true;
                }
                citac.Close();
                return false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiIDStavkePonude()
        {
            try
            {

                komanda.CommandText = "Select max(StavkaPonudeID) from StavkaPonude";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }



        }


        public void sacuvajStavkuPonude(StavkaPonude sp)
        {
            try
            {
                konekcija.Open();
                sp.StavkaPonudeID = vratiIDStavkePonude();
                komanda.CommandText = "Insert into StavkaPonude values(" + sp.PonudaID + "," + sp.StavkaPonudeID + ",'" + sp.Napomena + "'," + sp.Vozilo.VoziloID + ")"; ;
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<StavkaPonude> ucitajStavkePonudeZaOdredjenuPonudu(int ponudaID)
        {
            List<StavkaPonude> lista = new List<StavkaPonude>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from StavkaPonude sp inner join Vozilo v on sp.VoziloID=v.VoziloID where sp.PonudaID=" + ponudaID + "";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    StavkaPonude sp = new StavkaPonude();
                    sp.PonudaID = citac.GetInt32(0);
                    sp.StavkaPonudeID = citac.GetInt32(1);
                    sp.Napomena = citac.GetString(2);
                    sp.Vozilo = new Vozilo();
                    sp.Vozilo.VoziloID = citac.GetInt32(3);
                    sp.Vozilo.NazivVozila = citac.GetString(5);
                    sp.Vozilo.NazivModela = citac.GetString(6);


                    lista.Add(sp);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void sacuvajPonudu(Ponuda ponuda)
        {
            try
            {
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);

                komanda.CommandText = "Insert into Ponuda_pogled values (" + ponuda.PonudaID + ",'" + ponuda.DatumOd.ToString("yyyy-MM-dd") + "','" + ponuda.DatumDo.ToString("yyyy-MM-dd") + "',"+ponuda.BrojPonude+",'" + ponuda.RokIsporuke + "'," + ponuda.Katalog.KatalogID + "," + ponuda.Prodavac.ProdavacID + ",'" + ponuda.Kupac.KupacJMBG + "')";
                komanda.ExecuteNonQuery();

                foreach (StavkaPonude sp in ponuda.ListaStavki)
                {
                    sp.StavkaPonudeID = vratiIDStavkePonude();

                    komanda.CommandText = "Insert into StavkaPonude values(" + ponuda.PonudaID + "," + sp.StavkaPonudeID + ",'" + sp.Napomena + "'," + sp.Vozilo.VoziloID + ")";
                    komanda.ExecuteNonQuery();
                }
                transakcija.Commit();

            }
            catch (Exception)
            {

                transakcija.Rollback();

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Ponuda> ucitajPonudeUDataGrid()
        {
            List<Ponuda> lista = new List<Ponuda>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Ponuda_pogled p inner join Kupac k on p.KupacJMBG=k.KupacJMBG inner join Prodavac pr on p.ProdavacID=pr.ProdavacID";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Ponuda p = new Ponuda();
                    p.PonudaID = citac.GetInt32(0);
                    p.DatumOd = Convert.ToDateTime(citac.GetValue(1));
                    p.DatumDo = Convert.ToDateTime(citac.GetValue(2));
                    p.BrojPonude = citac.GetInt32(3);
                    p.RokIsporuke = citac.GetString(4);
                    p.Katalog = new Katalog();
                    p.Katalog.KatalogID = citac.GetInt32(5);
                    p.Prodavac = new Prodavac();
                    p.Prodavac.ProdavacID = citac.GetInt32(6);
                    p.Prodavac.ImePrezimeProdavca = citac.GetString(13);
                    p.Kupac = new Kupac();
                    p.Kupac.KupacJMBG = citac.GetString(7);
                    p.Kupac.ImePrezimeKupca = citac.GetString(9);

                   

                    lista.Add(p);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }


        public List<Ponuda> ucitajPonudeZaKriterijum(string kriterijum)
        {
            List<Ponuda> lista = new List<Ponuda>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Ponuda_pogled p inner join Kupac k on p.KupacJMBG=k.KupacJMBG inner join Prodavac pr on p.ProdavacID=pr.ProdavacID where k.ImePrezimeKupca like '%" + kriterijum + "%' or pr.ImePrezimeProdavca like '%" + kriterijum + "%'";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Ponuda p = new Ponuda();
                    p.PonudaID = citac.GetInt32(0);
                    p.DatumOd = Convert.ToDateTime(citac.GetValue(1));
                    p.DatumDo = Convert.ToDateTime(citac.GetValue(2));
                    p.BrojPonude = citac.GetInt32(3);
                    p.RokIsporuke = citac.GetString(4);
                    p.Katalog = new Katalog();
                    p.Katalog.KatalogID = citac.GetInt32(5);
                    p.Prodavac = new Prodavac();
                    p.Prodavac.ProdavacID = citac.GetInt32(6);
                    p.Prodavac.ImePrezimeProdavca = citac.GetString(13);
                    p.Kupac = new Kupac();
                    p.Kupac.KupacJMBG = citac.GetString(7);
                    p.Kupac.ImePrezimeKupca = citac.GetString(9);



                    lista.Add(p);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Ponuda> ucitajPonudeZaBrojPonude(int kriterijum)
        {
            List<Ponuda> lista = new List<Ponuda>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Ponuda_pogled p inner join Kupac k on p.KupacJMBG=k.KupacJMBG inner join Prodavac pr on p.ProdavacID=pr.ProdavacID where p.BrojPonude="+kriterijum+"";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Ponuda p = new Ponuda();
                    p.PonudaID = citac.GetInt32(0);
                    p.DatumOd = Convert.ToDateTime(citac.GetValue(1));
                    p.DatumDo = Convert.ToDateTime(citac.GetValue(2));
                    p.BrojPonude = citac.GetInt32(3);
                    p.RokIsporuke = citac.GetString(4);
                    p.Katalog = new Katalog();
                    p.Katalog.KatalogID = citac.GetInt32(5);
                    p.Prodavac = new Prodavac();
                    p.Prodavac.ProdavacID = citac.GetInt32(6);
                    p.Prodavac.ImePrezimeProdavca = citac.GetString(13);
                    p.Kupac = new Kupac();
                    p.Kupac.KupacJMBG = citac.GetString(7);
                    p.Kupac.ImePrezimeKupca = citac.GetString(9);



                    lista.Add(p);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void ObrisiStavkePonude(Ponuda ponuda)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from StavkaPonude where PonudaID = '" + ponuda.PonudaID + "'";
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public void ObrisiPonudu(Ponuda ponuda)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from Ponuda_pogled where PonudaID = " + ponuda.PonudaID + "";
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public void obrisiStavkuPonude(StavkaPonude sp)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Delete from StavkaPonude where PonudaID=" + sp.PonudaID + " and StavkaPonudeID=" + sp.StavkaPonudeID + "";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void izmeniStavkuPonude(StavkaPonude sp)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Update StavkaPonude set Napomena='" + sp.Napomena + "', VoziloID=" + sp.Vozilo.VoziloID + " where PonudaID=" + sp.PonudaID + " and StavkaPonudeID=" + sp.StavkaPonudeID + "";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void izmeniPonudu(Ponuda p)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update Ponuda_pogled set DatumOd='" + p.DatumOd.ToString("yyyy-MM-dd") + "', DatumDo='" + p.DatumDo.ToString("yyyy-MM-dd") + "' where PonudaID=" + p.PonudaID + "";
                komanda.ExecuteNonQuery();

            }
            catch (Exception)
            {
                

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void izmeniPonudu2(Ponuda p)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update Ponuda_pogled set BrojPonude=" + p.BrojPonude + ", RokIsporuke='" + p.RokIsporuke + "',  KatalogID=" + p.Katalog.KatalogID + ", ProdavacID=" + p.Prodavac.ProdavacID + ", KupacJMBG='" + p.Kupac.KupacJMBG + "' where PonudaID=" + p.PonudaID + "";
                komanda.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiIDVozila()
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select max(VoziloID) from Vozilo";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                konekcija.Close();

            }


        }

        public List<Oprema> ucitajSvuOpremu()
        {
            List<Oprema> lista = new List<Oprema>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Oprema";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Oprema o = new Oprema();
                    o.OpremaID = citac.GetInt32(0);
                    o.NazivOpreme = citac.GetString(1);
                    o.Opis = citac.GetString(2);

                    lista.Add(o);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public bool postojiVoziloUBazi(int voziloID)
        {

            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Vozilo where VoziloID='" + voziloID + "'";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {

                    return true;
                }
                citac.Close();
                return false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiIDDelaVozila()
        {
            try
            {

                komanda.CommandText = "Select max(DeoVozilaID) from DeoVozila";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }



        }

        public void sacuvajDeoVozila(DeoVozila dv)
        {
            try
            {
                konekcija.Open();
                dv.DeoVozilaID = vratiIDDelaVozila();
                komanda.CommandText = "Insert into DeoVozila values(" + dv.VoziloID + "," + dv.DeoVozilaID + ",'" + dv.Napomena + "'," + dv.Oprema.OpremaID + ")";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<DeoVozila> ucitajDeloveVozilaZaOdredjenoVozilo(int voziloID)
        {
            List<DeoVozila> lista = new List<DeoVozila>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from DeoVozila dv inner join Oprema o on dv.OpremaID=o.OpremaID where dv.VoziloID=" + voziloID + "";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    DeoVozila dv = new DeoVozila();
                    dv.VoziloID = citac.GetInt32(0);
                    dv.DeoVozilaID = citac.GetInt32(1);
                    dv.Napomena = citac.GetString(2);
                    dv.Oprema = new Oprema();
                    dv.Oprema.OpremaID = citac.GetInt32(3);
                    dv.Oprema.NazivOpreme = citac.GetString(5);
                    dv.Oprema.Opis = citac.GetString(6);


                    lista.Add(dv);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string sacuvajVozilo(Vozilo vozilo)
        {
            try
            {
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);

                komanda.CommandText = "Insert into Vozilo values (" + vozilo.VoziloID + ",'" + vozilo.NazivVozila + "','" + vozilo.NazivModela + "'," + vozilo.BrojVrata + "," + vozilo.SnagaMotora + ",'" + vozilo.VrstaMenjaca + "', '"+vozilo.TipVozila+"')";
                komanda.ExecuteNonQuery();

                foreach (DeoVozila dv in vozilo.ListaDelovaVozila)
                {
                    dv.DeoVozilaID = vratiIDDelaVozila();

                    komanda.CommandText = "Insert into DeoVozila values(" + vozilo.VoziloID + "," + dv.DeoVozilaID + ",'" + dv.Napomena + "'," + dv.Oprema.OpremaID + ")";
                    komanda.ExecuteNonQuery();
                }
              
                transakcija.Commit();
                return "Sistem je uspešno sačuvao vozilo!";

            }
            catch (Exception ex)
            {
                transakcija.Rollback();
                return "Sistem ne može da sačuva vozilo!\nGreška: \n" + ex.Message;
              

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiIDOpreme()
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select max(OpremaID) from Oprema";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                konekcija.Close();

            }


        }

        public string sacuvajOpremu(Oprema o)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Insert into Oprema values(" + o.OpremaID + ",'" + o.NazivOpreme + "', '" + o.Opis + "') ";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno sačuvao opremu!\n";


            }
            catch (Exception ex)
            {
                return "Sistem ne može da sačuva opremu!\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Oprema> ucitajOpremuZaKriterijum(string kriterijum)
        {
            List<Oprema> lista = new List<Oprema>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Oprema where NazivOpreme like '%" + kriterijum + "%' or OpisOpreme like '%"+kriterijum+"%'";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Oprema o = new Oprema();
                    o.OpremaID = citac.GetInt32(0);
                    o.NazivOpreme = citac.GetString(1);
                    o.Opis = citac.GetString(2);

                    lista.Add(o);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string obrisiOpremu(Oprema o)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from Oprema where OpremaID=" + o.OpremaID + "";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno obrisao opremu!\n";

            }
            catch (Exception ex)
            {
                return "Sistem ne može da obriše opremu!\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string izmeniOpremu(Oprema o)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update Oprema set OpremaID=" + o.OpremaID + ", NazivOpreme='" + o.NazivOpreme + "', OpisOpreme='"+o.Opis+"' where OpremaID=" + o.OpremaID + "";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno izmenio opremu!";
            }
            catch (Exception ex)
            {
                return "Sistem ne može da izmeni opremu!\n" + ex.Message;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public bool postojiPredracunUBazi(int predracunID)
        {

            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Predracun where PredracunID='" + predracunID + "'";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {
                    return true;
                }
                citac.Close();
                return false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string sacuvajStavkuPredracuna(StavkaPredracuna sp)
        {
            try
            {
                konekcija.Open();
                sp.StavkaPredracunaID = vratiIDStavkePredracuna();
                komanda.CommandText = "Insert into StavkaPredracuna values(" + sp.PredracunID + "," + sp.StavkaPredracunaID + "," + sp.Kolicina + "," + sp.Vozilo.VoziloID + ")";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno sačuvao stavku predračuna!";
            }
            catch (Exception ex)
            {
                return "Sistem ne može da sačuva stavku predračuna!\n" + ex.Message;
            }
            
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<StavkaPredracuna> ucitajStavkePredracunaZaOdredjeniPredracun(int predracunID)
        {
            List<StavkaPredracuna> lista = new List<StavkaPredracuna>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from StavkaPredracuna sp inner join Vozilo v on sp.VoziloID=v.VoziloID where sp.PredracunID=" + predracunID + "";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    StavkaPredracuna sp = new StavkaPredracuna();
                    sp.PredracunID = citac.GetInt32(0);
                    sp.StavkaPredracunaID = citac.GetInt32(1);
                    sp.Kolicina = citac.GetInt32(2);
                    sp.Vozilo = new Vozilo();
                    sp.Vozilo.VoziloID = citac.GetInt32(3);
                    sp.Vozilo.NazivVozila = citac.GetString(5);
                    sp.Vozilo.NazivModela = citac.GetString(6);


                    lista.Add(sp);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public double ucitajUkupanIznosZaOdredjeniPredracun(int predracunID)
        {
            double cena = new double();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select p.UkupanIznos from Predracun p where p.PredracunID="+predracunID+"";
                SqlDataReader citac = komanda.ExecuteReader();

                if (citac.Read())
                {
                    
                    cena = Convert.ToDouble(citac.GetValue(0));

                    return cena;
                }
                citac.Close();
                return 0;
            }
            catch (Exception)
            {
                //cena = 0;
                //return cena;
                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void izmeniPredracun(Predracun p)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update Predracun set BrojPredracuna='"+p.BrojPredracuna+"', DatumIzdavanja='" + p.DatumIzdavanja.ToString("yyyy-MM-dd") + "', DatumPrometa='" + p.DatumPrometa.ToString("yyyy-MM-dd") + "', NacinPlacanja='" + p.NacinPlacanja + "', UgovorID=" + p.Ugovor.UgovorID + ", ProdavacID=" + p.Prodavac.ProdavacID + ", KupacJMBG='" + p.Kupac.KupacJMBG + "' where PredracunID=" + p.PredracunID + "";
                komanda.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string izmeniPredracunUkupanIznos(Predracun p, double ukupanIznos)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update Predracun set UkupanIznos="+ukupanIznos+" where PredracunID=" + p.PredracunID + "";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno izmenio predračun!";

            }
            catch (Exception ex)
            {
                return "Sistem ne može da izmeni predračun!\nGreška:\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void izmeniStavkuPredracuna(StavkaPredracuna sp)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Update StavkaPredracuna set Kolicina=" + sp.Kolicina + ", VoziloID=" + sp.Vozilo.VoziloID + " where PredracunID=" + sp.PredracunID + " and StavkaPredracunaID=" + sp.StavkaPredracunaID + "";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void obrisiStavkuPredracuna(StavkaPredracuna sp)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Delete from StavkaPredracuna where PredracunID=" + sp.PredracunID + " and StavkaPredracunaID=" + sp.StavkaPredracunaID + "";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void ObrisiStavkePredracuna(Predracun predracun)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from StavkaPredracuna where PredracunID = '" + predracun.PredracunID + "'";
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public void ObrisiPredracun(Predracun predracun)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from Predracun where PredracunID = " + predracun.PredracunID + "";
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public List<Vozilo> ucitajVozilaZaKriterijum(string kriterijum)
        {
            List<Vozilo> lista = new List<Vozilo>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Vozilo where NazivVozila like '%" + kriterijum + "%' or NazivModela like '%" + kriterijum + "%'";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Vozilo v = new Vozilo();
                    v.VoziloID = citac.GetInt32(0);
                    v.NazivVozila = citac.GetString(1);
                    v.NazivModela = citac.GetString(2);
                    v.BrojVrata = citac.GetInt32(3);
                    v.SnagaMotora = citac.GetInt32(4);
                    v.VrstaMenjaca = citac.GetString(5);
                    v.TipVozila = citac.GetString(6);

                    lista.Add(v);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void ObrisiDeloveVozila(Vozilo vozilo)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from DeoVozila where VoziloID = '" + vozilo.VoziloID+ "'";
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public void ObrisiVozilo(Vozilo vozilo)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from Vozilo where VoziloID = " + vozilo.VoziloID + "";
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                konekcija.Close();
            }
        }

        public void obrisiDeoVozila(DeoVozila dv)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Delete from DeoVozila where VoziloID=" + dv.VoziloID + " and DeoVozilaID=" + dv.DeoVozilaID + "";
                komanda.ExecuteNonQuery();


            }
            catch (Exception)
            {


            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string izmeniDeoVozila(DeoVozila dv)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Update DeoVozila set Napomena='" + dv.Napomena + "', OpremaID=" + dv.Oprema.OpremaID + " where VoziloID=" + dv.VoziloID + " and DeoVozilaID=" + dv.DeoVozilaID + "";
                komanda.ExecuteNonQuery();
                return "Deo vozila je izmenjen!";

            }
            catch (Exception ex)
            {
                return "Sistem ne može da izmeni deo vozila!" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string izmeniVozilo(Vozilo v)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update Vozilo set NazivVozila='" + v.NazivVozila + "', NazivModela='" + v.NazivModela + "', BrojVrata="+v.BrojVrata+", SnagaMotora="+v.SnagaMotora+", VrstaMenjaca='"+v.VrstaMenjaca+"', TipVozila='"+v.TipVozila+"' where VoziloID=" + v.VoziloID + "";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno izmenio vozilo!";
            }
            catch (Exception ex)
            {
                return "Sistem ne može da izmeni vozilo!\nDozvoljene vrednosti za atribut TipVozila su - Komercijalno vozilo i Putnicko vozilo\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public bool postojiIDVozila(int voziloID)
        {

            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Vozilo where VoziloID='" + voziloID + "'";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {

                    return true;
                }
                citac.Close();
                return false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiIDCeneVozila()
        {
            try
            {

                komanda.CommandText = "Select max(CenaVozilaID) from CenaVozila";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

            }
            catch (Exception)
            {

                throw;
            }



        }

        public string sacuvajCenuVozila(CenaVozila cv)
        {
            try
            {
                konekcija.Open();
                cv.CenaVozilaID = vratiIDCeneVozila();
                komanda.CommandText = "Insert into CenaVozila (VoziloID, CenaVozilaID, Iznos, Valuta) values(" + cv.VoziloID + "," + cv.CenaVozilaID + "," + cv.Iznos + ",'" + cv.Valuta + "')";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno sačuvao cenu vozila!";

            }
            catch (Exception ex)
            {
                return "Sistem ne može da sačuva cenu vozila!\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string vratiNazivVozilaZaOdredjenuCenu(int voziloID)
        {

            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from CenaVozila where VoziloID='" + voziloID + "'";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {

                    return citac.GetString(4);
                }
                citac.Close();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<CenaVozila> ucitajSveCene()
        {
            List<CenaVozila> lista = new List<CenaVozila>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from CenaVozila";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    CenaVozila cv = new CenaVozila();
                    cv.VoziloID = citac.GetInt32(0);
                    cv.CenaVozilaID = citac.GetInt32(1);
                    cv.Iznos = Convert.ToDouble(citac.GetValue(2));
                    cv.Valuta = citac.GetString(3);
                    cv.NazivVozila = citac.GetString(4);

                    lista.Add(cv);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<CenaVozila> ucitajCeneZaKriterijum(string kriterijum)
        {
            List<CenaVozila> lista = new List<CenaVozila>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from CenaVozila where NazivVozila like '%" + kriterijum + "%' or Valuta like '%" + kriterijum + "%'";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    CenaVozila cv = new CenaVozila();
                    cv.VoziloID = citac.GetInt32(0);
                    cv.CenaVozilaID = citac.GetInt32(1);
                    cv.Iznos = Convert.ToDouble(citac.GetValue(2));
                    cv.Valuta = citac.GetString(3);
                    cv.NazivVozila = citac.GetString(4);

                    lista.Add(cv);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string obrisiCenu(CenaVozila cv)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from CenaVozila where CenaVozilaID=" + cv.CenaVozilaID + "";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno obrisao cenu vozila!\n";

            }
            catch (Exception ex)
            {
                return "Sistem ne može da obriše cenu vozila!\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string izmeniCenu(CenaVozila cv)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Update CenaVozila set VoziloID=" + cv.VoziloID + ", NazivVozila='" + cv.NazivVozila + "' where VoziloID=" + cv.VoziloID + " and CenaVozilaID=" + cv.CenaVozilaID + "";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno izmenio cenu vozila!";

            }
            catch (Exception ex)
            {
                return "Sistem ne može da izmeni cenu vozila!\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string izmeniCenu2(CenaVozila cv)
        {
            try
            {
                konekcija.Open();

                komanda.CommandText = "Update CenaVozila set Iznos=" + cv.Iznos + ", Valuta='" + cv.Valuta + "' where VoziloID=" + cv.VoziloID + " and CenaVozilaID=" + cv.CenaVozilaID + "";
                komanda.ExecuteNonQuery();
                return "Sistem je uspešno izmenio cenu vozila!";

            }
            catch (Exception ex)
            {
                return "Sistem ne može da izmeni cenu vozila!\n" + ex.Message;

            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public string vratiImePrezimeProdavcaIzRacunOtpremnice(RacunOtpremnica ro)
        {

            try
            {
                konekcija.Open();
                komanda.CommandText = "Select ro.ImePrezimeProdavca from RacunOtpremnica ro where ro.RacunOtpremnicaID='" + ro.RacunOtpremnicaID + "'";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {

                    return citac.GetString(0);
                }
                citac.Close();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }
    }
}
