using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DrugiProjekat
{
    public partial class Form1 : Form
    {
        List<clsDesktop> desktopLista = new List<clsDesktop>();

        public Form1()
        {
            InitializeComponent();
            UcitajPodatkeIzFajla();
        }

        private void UcitajPodatkeIzFajla()
        {
            try
            {
                if (File.Exists("DesktopRačunari.json"))
                {
                    // Ako fajl postoji, učitaj podatke
                    string jsonText = File.ReadAllText("DesktopRačunari.json");
                    desktopLista = JsonConvert.DeserializeObject<List<clsDesktop>>(jsonText);

                    // Postavi desktopLista kao izvor podataka za ListBox
                    listBox1.DataSource = null;
                    listBox1.DataSource = desktopLista;
                    listBox1.DisplayMember = "Proizvodjac";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom učitavanja podataka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Sačuvaj podatke u JSON fajl
            SacuvajPodatkeUFajl();
        }

        private void SacuvajPodatkeUFajl()
        {
            try
            {
                // Serijalizuj listu u JSON format
                string jsonText = JsonConvert.SerializeObject(desktopLista, Formatting.Indented);

                // Sačuvaj JSON fajl na disku
                File.WriteAllText("DesktopRačunari.json", jsonText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom čuvanja podataka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOtvoriJSON_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jsonText = File.ReadAllText(openFileDialog.FileName);
                    desktopLista = JsonConvert.DeserializeObject<List<clsDesktop>>(jsonText);

                    // Osveži ListBox sa učitanim podacima
                    OsveziListBox();

                    MessageBox.Show("Podaci uspešno učitani iz JSON fajla.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom učitavanja JSON fajla: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSacuvajUListBox_Click(object sender, EventArgs e)
        {
            try
            {
                // Provera praznih polja
                if (string.IsNullOrWhiteSpace(txtProizvodjac.Text) ||
                    string.IsNullOrWhiteSpace(txtNaziv.Text) ||
                    string.IsNullOrWhiteSpace(txtCena.Text) ||
                    string.IsNullOrWhiteSpace(txtProcesor.Text) ||
                    string.IsNullOrWhiteSpace(txtVrstaRAM.Text) ||
                    string.IsNullOrWhiteSpace(txtVelicinaRAM.Text) ||
                    string.IsNullOrWhiteSpace(txtMaticnaPloca.Text) ||
                    string.IsNullOrWhiteSpace(txtGrafickaKarta.Text) ||
                    string.IsNullOrWhiteSpace(txtVrstaKucista.Text) ||
                    string.IsNullOrWhiteSpace(txtTipSkladista.Text) ||
                    string.IsNullOrWhiteSpace(txtKapacitetSkladista.Text))
                {
                    MessageBox.Show("Morate popuniti sva polja pre nego što dodate u ListBox.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Uzmi vrednosti iz tekstualnih polja
                string proizvodjac = txtProizvodjac.Text;
                string nazivUredjaja = txtNaziv.Text;
                decimal cena = decimal.Parse(txtCena.Text);

                string nazivProcesora = txtProcesor.Text;
                string vrstaMemorijeRAM = txtVrstaRAM.Text;
                int velicinaMemorijeRAM = int.Parse(txtVelicinaRAM.Text);
                string maticnaPloca = txtMaticnaPloca.Text;
                string grafickaKarta = txtGrafickaKarta.Text;
                string vrstaKucista = txtVrstaKucista.Text;

                // Dodaj ove dve linije za tipSkladista i kapacitetSkladista
                string tipSkladista = txtTipSkladista.Text;
                int kapacitetSkladista = int.Parse(txtKapacitetSkladista.Text);

                // Proveri da li je neki element izabran u ListBox-u
                if (listBox1.SelectedIndex != -1)
                {
                    // Ako jeste, izmeni postojeći element umesto dodavanja novog
                    clsDesktop izabraniDesktop = (clsDesktop)listBox1.SelectedItem;
                    izabraniDesktop.Proizvodjac = proizvodjac;
                    izabraniDesktop.NazivUredjaja = nazivUredjaja;
                    izabraniDesktop.Cena = cena;
                    izabraniDesktop.NazivProcesora = nazivProcesora;
                    izabraniDesktop.VrstaMemorijeRAM = vrstaMemorijeRAM;
                    izabraniDesktop.VelicinaMemorijeRAM = velicinaMemorijeRAM;
                    izabraniDesktop.TipSkladista = tipSkladista;
                    izabraniDesktop.KapacitetSkladista = kapacitetSkladista;
                    izabraniDesktop.MaticnaPloca = maticnaPloca;
                    izabraniDesktop.GrafickaKarta = grafickaKarta;
                    izabraniDesktop.VrstaKucista = vrstaKucista;

                    // Osveži prikaz u ListBox-u
                    OsveziListBox();

                    // Prikazujemo poruku o uspešnoj izmeni
                    MessageBox.Show("Podaci su uspešno izmenjeni u ListBox-u.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Ako nije izabran nijedan element, dodaj novi
                    clsDesktop desktop = new clsDesktop(
                        proizvodjac,
                        nazivUredjaja,
                        cena,
                        nazivProcesora,
                        vrstaMemorijeRAM,
                        velicinaMemorijeRAM,
                        maticnaPloca,
                        grafickaKarta,
                        vrstaKucista,
                        tipSkladista,
                        kapacitetSkladista
                    );

                    desktopLista.Add(desktop);

                    // Osveži prikaz u ListBox-u
                    OsveziListBox();

                    OsveziTextBoxove();

                    // Prikazujemo poruku o uspešnom dodavanju
                    MessageBox.Show("Podaci su uspešno dodati u ListBox.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OsveziTextBoxove()
        {
            txtProizvodjac.Text = "";
            txtNaziv.Text = "";
            txtCena.Text = "";
            txtProcesor.Text = "";
            txtVrstaRAM.Text = "";
            txtVelicinaRAM.Text = "";
            txtTipSkladista.Text = "";
            txtKapacitetSkladista.Text = "";
            txtMaticnaPloca.Text = "";
            txtGrafickaKarta.Text = "";
            txtVrstaKucista.Text = "";
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            OsveziTextBoxove();
            listBox1.SelectedIndex = -1;
        }

        private void btnSacuvajKaoJSON_Click(object sender, EventArgs e)
        {
            try
            {
                // Provera da li je ListBox prazan
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("ListBox je prazan. Dodajte podatke pre nego što ih sačuvate kao JSON.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Serijalizuj listu u JSON format
                string jsonText = JsonConvert.SerializeObject(desktopLista, Formatting.Indented);

                // Sačuvaj JSON fajl na disku
                File.WriteAllText("DesktopRačunari.json", jsonText);

                // Prikaži poruku o uspešnoj serijalizaciji
                MessageBox.Show("Lista Desktop računara uspešno sačuvana u JSON fajl.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Ako dođe do greške pri serijalizaciji
                MessageBox.Show($"Došlo je do greške: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrikaziSpecifikacije(clsDesktop desktop)
        {
            txtProizvodjac.Text = desktop.Proizvodjac;
            txtNaziv.Text = desktop.NazivUredjaja;
            txtCena.Text = desktop.Cena.ToString();
            txtProcesor.Text = desktop.NazivProcesora;
            txtVrstaRAM.Text = desktop.VrstaMemorijeRAM;
            txtVelicinaRAM.Text = desktop.VelicinaMemorijeRAM.ToString();
            txtMaticnaPloca.Text = desktop.MaticnaPloca;
            txtGrafickaKarta.Text = desktop.GrafickaKarta;
            txtVrstaKucista.Text = desktop.VrstaKucista;
            txtTipSkladista.Text = desktop.TipSkladista;
            txtKapacitetSkladista.Text = desktop.KapacitetSkladista.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Proveri da li je selektovan objekat u ListBox-u
            if (listBox1.SelectedIndex != -1)
            {
                // Prikazi specifikacije izabranog objekta na textbox-ovima
                clsDesktop izabraniDesktop = (clsDesktop)listBox1.SelectedItem;
                PrikaziSpecifikacije(izabraniDesktop);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.SelectedIndex = -1;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // Proveri da li je selektovan objekat u ListBox-u
            if (listBox1.SelectedIndex != -1)
            {
                // Ukloni objekat iz liste i osveži ListBox
                desktopLista.RemoveAt(listBox1.SelectedIndex);
                OsveziListBox();
                SacuvajPodatkeUFajl();
                MessageBox.Show("Podatak uspešno obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nije odabran podatak za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OsveziListBox()
        {
            // Postavi desktopLista kao izvor podataka za ListBox
            listBox1.DataSource = null;
            listBox1.DataSource = desktopLista;
            listBox1.DisplayMember = "Proizvodjac";
            listBox1.SelectedIndex = -1;
        }

        private void btnTestiraj_Click(object sender, EventArgs e)
        {
            try
            {
                // Kreiranje instance clsDesktop
                clsDesktop desktop = new clsDesktop(
                    proizvodjac: "CoolerMaster",
                    nazivUredjaja: "Desktop Računar",
                    cena: 1500.00m,
                    nazivProcesora: "Ryzen",
                    vrstaMemorijeRAM: "DDR4",
                    velicinaMemorijeRAM: 16,
                    tipSkladista: "HDD",
                    kapacitetSkladista: 500,
                    maticnaPloca: "ATX",
                    grafickaKarta: "GeForce RTX 4080",
                    vrstaKucista: "Mid Tower"
                );

                // Prikazi podatke u MessageBox-u
                string desktopPoruka = $"Proizvođač: {desktop.Proizvodjac}\n" +
                                        $"Naziv uređaja: {desktop.NazivUredjaja}\n" +
                                        $"Cena: {desktop.Cena:C}\n" +
                                        $"Procesor: {desktop.NazivProcesora}\n" +
                                        $"Vrsta RAM memorije: {desktop.VrstaMemorijeRAM}\n" +
                                        $"Veličina RAM memorije: {desktop.VelicinaMemorijeRAM} GB\n" +
                                        $"Tip skladišta: {desktop.TipSkladista}\n" +
                                        $"Kapacitet skladišta: {desktop.KapacitetSkladista} GB\n" +
                                        $"Matična ploča: {desktop.MaticnaPloca}\n" +
                                        $"Grafička karta: {desktop.GrafickaKarta}\n" +
                                        $"Vrsta kućišta: {desktop.VrstaKucista}";

                MessageBox.Show(desktopPoruka, "Podaci o Desktop Računaru", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void btnTestiraj2_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekat clsLaptop
                clsLaptop laptop = new clsLaptop(
                    proizvodjac: "Dell",
                    nazivUredjaja: "Inspiron 15",
                    cena: 899.99m,
                    nazivProcesora: "Intel Core i5",
                    vrstaMemorijeRAM: "DDR4",
                    velicinaMemorijeRAM: 16,
                    tipSkladista: "HDD",
                    kapacitetSkladista: 500,
                    maticnaPloca: "Micro-ATX",
                    grafickaKarta: "Nvidia GeForce",
                    tezina: 2.5,
                    kapacitetBaterije: 65,
                    velicinaMonitora: 15.6
                );

                // Prikazi podatke u MessageBox-u
                string poruka = $"Proizvođač: {laptop.Proizvodjac}\n" +
                                $"Naziv: {laptop.NazivUredjaja}\n" +
                                $"Cena: {laptop.Cena:C}\n" +
                                $"Procesor: {laptop.NazivProcesora}\n" +
                                $"RAM: {laptop.VrstaMemorijeRAM} {laptop.VelicinaMemorijeRAM}GB\n" +
                                $"Tip skladišta: {laptop.TipSkladista}\n" +
                                $"Kapacitet skladišta: {laptop.KapacitetSkladista} GB\n" +
                                $"Matična ploča: {laptop.MaticnaPloca}\n" +
                                $"Grafička karta: {laptop.GrafickaKarta}\n" +
                                $"Težina: {laptop.Tezina} kg\n" +
                                $"Kapacitet baterije: {laptop.FormattedKapacitetBaterije}\n" +
                                $"Veličina monitora: {laptop.VelicinaMonitora} inch";

                MessageBox.Show(poruka, "Podaci o Laptopu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void btnTestiraj3_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekat clsTelefon
                clsTelefon telefon = new clsTelefon(
                    proizvodjac: "Samsung",
                    nazivUredjaja: "Galaxy",
                    cena: 1299.99m,
                    operativniSistem: "Android",
                    podrzavaSIMKarticu: true,
                    vrstaSIMKartice: "eSIM",
                    velicinaRAMMemorije: 8,
                    velicinaSkladisneMemorije: 256,
                    model: "S21",
                    kapacitetBaterije: 4000,
                    tehnologijaMreze: "5G",
                    wiFiStandard: "Wi-Fi 6"
                );

                // Prikazi podatke u MessageBox-u
                string porukaTelefon = $"Proizvođač: {telefon.Proizvodjac}\n" +
                                       $"Model: {telefon.Model}\n" +
                                       $"Cena: {telefon.Cena:C}\n" +
                                       $"Operativni sistem: {telefon.OperativniSistem}\n" +
                                       $"Podržava SIM karticu: {telefon.PodrzavaSIMKarticu}\n" +
                                       $"Vrsta SIM kartice: {telefon.VrstaSIMKartice}\n" +
                                       $"Veličina RAM memorije: {telefon.VelicinaRAMMemorije} GB\n" +
                                      $"Veličina skladišne memorije: {telefon.VelicinaSkladisneMemorije} GB\n" +
                                       $"Kapacitet baterije: {telefon.KapacitetBaterije} mAh\n" +
                                       $"Tehnologija mreže: {telefon.TehnologijaMreze}\n" +
                                       $"Wi-Fi standard: {telefon.WiFiStandard}";

                MessageBox.Show(porukaTelefon, "Podaci o Telefonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void btnTestiraj4_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekat clsTablet
                clsTablet tablet = new clsTablet(
                    proizvodjac: "Apple",
                    nazivUredjaja: "iPad Pro",
                    cena: 1099.99m,
                    operativniSistem: "iPadOS",
                    podrzavaSIMKarticu: true,
                    vrstaSIMKartice: "eSIM",
                    velicinaRAMMemorije: 8,
                    velicinaSkladisneMemorije: 256,
                    velicinaEkrana: 12.9
                );

                // Prikazi podatke u MessageBox-u
                string porukaTablet = $"Proizvođač: {tablet.Proizvodjac}\n" +
                                      $"Naziv: {tablet.NazivUredjaja}\n" +
                                      $"Cena: {tablet.Cena:C}\n" +
                                      $"Operativni sistem: {tablet.OperativniSistem}\n" +
                                      $"Podržava SIM karticu: {tablet.PodrzavaSIMKarticu}\n" +
                                      $"Vrsta SIM kartice: {tablet.VrstaSIMKartice}\n" +
                                      $"Veličina RAM memorije: {tablet.VelicinaRAMMemorije} GB\n" +
                                      $"Veličina skladišne memorije: {tablet.VelicinaSkladisneMemorije} GB\n" +
                                      $"Veličina ekrana: {tablet.VelicinaEkrana} inch";

                MessageBox.Show(porukaTablet, "Podaci o Tablet-u", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void btnTestiraj5_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekat clsGamingKonzola
                clsGamingKonzola gamingKonzola = new clsGamingKonzola(
                    proizvodjac: "Sony",
                    nazivUredjaja: "PlayStation 5",
                    cena: 499.99m,
                    tipMedija: "Blu-ray",
                    brojIgrica: 20
                );

                // Prikazi podatke u MessageBox-u
                string porukaGamingKonzola = $"Proizvođač: {gamingKonzola.Proizvodjac}\n" +
                                             $"Naziv: {gamingKonzola.NazivUredjaja}\n" +
                                             $"Cena: {gamingKonzola.Cena:C}\n" +
                                             $"Tip medija: {gamingKonzola.TipMedija}\n" +
                                             $"Broj igrica: {gamingKonzola.BrojIgrica}";

                MessageBox.Show(porukaGamingKonzola, "Podaci o Gaming Konzoli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void btnTestiraj6_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekat clsPrenosivaKonzola
                clsPrenosivaKonzola prenosivaKonzola = new clsPrenosivaKonzola(
                    proizvodjac: "Nintendo",
                    nazivUredjaja: "Switch",
                    cena: 299.99m,
                    tipMedija: "Game Card",
                    podrzavaBluetooth: true
                );

                // Prikazi podatke u MessageBox-u
                string porukaPrenosivaKonzola = $"Proizvođač: {prenosivaKonzola.Proizvodjac}\n" +
                                                 $"Naziv: {prenosivaKonzola.NazivUredjaja}\n" +
                                                 $"Cena: {prenosivaKonzola.Cena:C}\n" +
                                                 $"Tip medija: {prenosivaKonzola.TipMedija}\n" +
                                                 $"Podržava Bluetooth: {prenosivaKonzola.PodrzavaBluetooth}";

                MessageBox.Show(porukaPrenosivaKonzola, "Podaci o Prenosivoj Konzoli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void btnTestiraj7_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekat clsRaspberryPi
                clsRaspberryPi raspberryPi = new clsRaspberryPi(
                    proizvodjac: "Raspberry",
                    nazivUredjaja: "Raspberry Pi 4",
                    cena: 35.99m,
                    nazivProcesora: "Intel Core i3",
                    vrstaMemorijeRAM: "DDR4",
                    velicinaMemorijeRAM: 4,
                    maticnaPloca: "Micro-ATX",
                    grafickaKarta: "Arc integrated graphics",
                    gpioBrojevi: 40
                );

                // Prikazi podatke u MessageBox-u
                string porukaRaspberryPi = $"Proizvođač: {raspberryPi.Proizvodjac}\n" +
                                            $"Naziv: {raspberryPi.NazivUredjaja}\n" +
                                            $"Cena: {raspberryPi.Cena:C}\n" +
                                            $"Procesor: {raspberryPi.NazivProcesora}\n" +
                                            $"Vrsta RAM Memorije: {raspberryPi.VrstaMemorijeRAM}\n" +
                                            $"Kapacitet RAM Memorije: {raspberryPi.VelicinaMemorijeRAM} GB\n" +
                                            $"Matična ploča: {raspberryPi.MaticnaPloca}\n" +
                                            $"Grafička karta: {raspberryPi.GrafickaKarta}\n" +
                                            $"GPIO brojevi: {raspberryPi.GPIOBrojevi}";

                MessageBox.Show(porukaRaspberryPi, "Podaci o Raspberry Pi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void btnTestiraj8_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekat clsArduino
                clsArduino arduino = new clsArduino(
                    proizvodjac: "Arduino",
                    nazivUredjaja: "Arduino Uno",
                    cena: 25.99m,
                    nazivProcesora: "Core ATmega328P",
                    vrstaMemorijeRAM: "DDR4",
                    velicinaMemorijeRAM: 2,
                    maticnaPloca: "Micro-ATX",
                    grafickaKarta: "Arc integrated graphics",
                    brojAnalogUlaza: 6,
                    brojDigitalnihUlaza: 14
                );

                // Prikazi podatke u MessageBox-u
                string porukaArduino = $"Proizvođač: {arduino.Proizvodjac}\n" +
                                       $"Naziv: {arduino.NazivUredjaja}\n" +
                                       $"Cena: {arduino.Cena:C}\n" +
                                       $"Procesor: {arduino.NazivProcesora}\n" +
                                       $"Vrsta RAM Memorije: {arduino.VrstaMemorijeRAM}\n" +
                                       $"Kapacitet RAM Memorije: {arduino.VelicinaMemorijeRAM} KB\n" +
                                       $"Matična ploča: {arduino.MaticnaPloca}\n" +
                                       $"Grafička karta: {arduino.GrafickaKarta}\n" +
                                       $"Broj analognih ulaza: {arduino.BrojAnalogUlaza}\n" +
                                       $"Broj digitalnih ulaza: {arduino.BrojDigitalnihUlaza}";

                MessageBox.Show(porukaArduino, "Podaci o Arduino", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void btnTestiraj9_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekat clsNvidiaJetsonNano
                clsNvidiaJetsonNano jetsonNano = new clsNvidiaJetsonNano(
                    proizvodjac: "NVIDIA",
                    nazivUredjaja: "Jetson Nano",
                    cena: 99.99m,
                    nazivProcesora: "Quad-core ARM Cortex-A57 MPCore",
                    vrstaMemorijeRAM: "DDR4",
                    velicinaMemorijeRAM: 4,
                    maticnaPloca: "Micro-ATX",
                    grafickaKarta: "Arc integrated graphics",
                    cudaJezgara: 128
                );

                // Prikazi podatke u MessageBox-u
                string porukaJetsonNano = $"Proizvođač: {jetsonNano.Proizvodjac}\n" +
                                           $"Naziv: {jetsonNano.NazivUredjaja}\n" +
                                           $"Cena: {jetsonNano.Cena:C}\n" +
                                           $"Procesor: {jetsonNano.NazivProcesora}\n" +
                                           $"Vrsta RAM memorije: {jetsonNano.VrstaMemorijeRAM}\n" +
                                           $"Kapacitet RAM Memorije: {jetsonNano.VelicinaMemorijeRAM} GB\n" +
                                           $"Matična ploča: {jetsonNano.MaticnaPloca}\n" +
                                           $"Grafička karta: {jetsonNano.GrafickaKarta}\n" +
                                           $"CUDA jezgara: {jetsonNano.CUDAJezgara}";

                MessageBox.Show(porukaJetsonNano, "Podaci o NVIDIA Jetson Nano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void btnTestiraj10_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekat clsInkJetPrinter
                clsInkJetPrinter inkJetPrinter = new clsInkJetPrinter(
                    proizvodjac: "Epson",
                    nazivUredjaja: "EcoTank ET-2720",
                    cena: 249.99m,
                    tehnologija: "InkJet",
                    uBoji: true,
                    brojBoja: 4
                );

                // Prikazi podatke u MessageBox-u
                string porukaInkJetPrinter = $"Proizvođač: {inkJetPrinter.Proizvodjac}\n" +
                                              $"Naziv: {inkJetPrinter.NazivUredjaja}\n" +
                                              $"Cena: {inkJetPrinter.Cena:C}\n" +
                                              $"Tehnologija: {inkJetPrinter.Tehnologija}\n" +
                                              $"U boji: {inkJetPrinter.UBoji}\n" +
                                              $"Broj boja: {inkJetPrinter.BrojBoja}";

                MessageBox.Show(porukaInkJetPrinter, "Podaci o InkJet Printeru", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void btnTestiraj11_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekat clsLaserPrinter
                clsLaserPrinter laserPrinter = new clsLaserPrinter(
                    proizvodjac: "HP",
                    nazivUredjaja: "LaserJet Pro M404dn",
                    cena: 199.99m,
                    tehnologija: "Laser",
                    uBoji: false,
                    nfcFunkcionalnost: true
                );

                // Prikazi podatke u MessageBox-u
                string porukaLaserPrinter = $"Proizvođač: {laserPrinter.Proizvodjac}\n" +
                                             $"Naziv: {laserPrinter.NazivUredjaja}\n" +
                                             $"Cena: {laserPrinter.Cena:C}\n" +
                                             $"Tehnologija: {laserPrinter.Tehnologija}\n" +
                                             $"U boji: {laserPrinter.UBoji}\n" +
                                             $"NFC funkcionalnost: {laserPrinter.NFCFunkcionalnost}";

                MessageBox.Show(porukaLaserPrinter, "Podaci o Laser Printeru", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom kreiranja desktop računara: {ex.Message}");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
