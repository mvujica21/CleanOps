using CleanOps.Models;
using CleanOps.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanOps
{
    public partial class frmAžurirajZaposlenika : Form
    {
        int id;
        public frmAžurirajZaposlenika(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            id = zaposlenik.Id;
            txtIme.Text = zaposlenik.Ime.ToString();
            txtKorisnickoIme.Text = zaposlenik.KorisnickoIme.ToString();
            txtAdresa.Text= zaposlenik.Adresa.ToString();
            txtBrojTelefona.Text = zaposlenik.BrojTelefona.ToString();
            txtLozinka.Text=zaposlenik.Lozinka.ToString();
            txtMail.Text= zaposlenik.Mail.ToString();
            txtMjestoRodenja.Text = zaposlenik.MjestoRodenja.ToString();
            txtPrezime.Text=zaposlenik.Prezime.ToString();
            txtZiroRacun.Text = zaposlenik.ZiroRacun.ToString();
            dtDatumRodenja.Text = zaposlenik.DatumRodenja.ToString();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            
            ZaposlenikRepository.AzurirajZaposlenik(id, txtIme.Text, txtKorisnickoIme.Text, txtPrezime.Text, txtLozinka.Text, txtMjestoRodenja.Text, txtAdresa.Text, txtMail.Text, int.Parse(txtBrojTelefona.Text),txtZiroRacun.Text, DateTime.Parse(dtDatumRodenja.Text));
            MessageBox.Show("Uspješno ste azurirali zaposlenika");
            Hide();
            Close();
            frmListaZaposlenika FrmListaZaposlenika = new frmListaZaposlenika();
            FrmListaZaposlenika.ShowDialog();
        }
    }
}
