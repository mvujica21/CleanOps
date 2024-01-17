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
    public partial class frmDodajZaposlenika : Form
    {
        public frmDodajZaposlenika()
        {
            InitializeComponent();
        }
        
        
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            zaposlenik.Ime = txtIme.Text;
            zaposlenik.Prezime= txtPrezime.Text;
            zaposlenik.KorisnickoIme = txtKorisnickoIme.Text;
            zaposlenik.Lozinka=txtLozinka.Text;
            zaposlenik.MjestoRodenja = txtMjestoRodenja.Text;
            zaposlenik.DatumRodenja = DateTime.Parse(dtDatumRodenja.Text);
            zaposlenik.BrojTelefona = int.Parse(txtBrojTelefona.Text);
            zaposlenik.Adresa = txtAdresa.Text;
            zaposlenik.ZiroRacun = txtZiroRacun.Text;
            zaposlenik.Mail = txtMail.Text;
            ZaposlenikRepository.AddZaposlenik(zaposlenik);
            MessageBox.Show("Uspješno ste dodali zaposlenika.");
            Hide();
            Close();
            frmListaZaposlenika FrmListaZaposlenika = new frmListaZaposlenika();
            FrmListaZaposlenika.ShowDialog();
          
        }
    }
}
