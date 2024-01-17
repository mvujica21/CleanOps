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

namespace CleanOps {
    public partial class frmListaZaposlenika : Form {
        public frmListaZaposlenika() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajZaposlenike();
        }

        private Zaposlenik Odabrani()
        {
            return (Zaposlenik)dgvZaposlenici.CurrentRow.DataBoundItem;
        }
        private void UcitajZaposlenike()
        {
            var zaposlenici = ZaposlenikRepository.GetAll();
            dgvZaposlenici.DataSource = zaposlenici;
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            
            frmDodajZaposlenika FrmDodajZaposlenika = new frmDodajZaposlenika();
            FrmDodajZaposlenika.ShowDialog();
            Hide();
            Close();

        }

        private void btnUkloniZaposlenika_Click(object sender, EventArgs e)
        {
            ZaposlenikRepository.UkloniZaposlenika(Odabrani().Id);
            Hide();
            frmListaZaposlenika FrmListaZaposlenika = new frmListaZaposlenika();
            FrmListaZaposlenika.ShowDialog();
            MessageBox.Show("Uspješno ste uklonili zaposlenika");
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                var zaposlenici = ZaposlenikRepository.GetAll();
                dgvZaposlenici.DataSource = zaposlenici;
            }
            else
            {
                var zaposlenici = ZaposlenikRepository.PretraziZaposlenike(txtSearch.Text);
                dgvZaposlenici.DataSource = zaposlenici;

            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            frmAžurirajZaposlenika FrmAžurirajZaposlenika = new frmAžurirajZaposlenika(Odabrani());
            FrmAžurirajZaposlenika.ShowDialog();
            Hide();
            Close();
        }
    }
}
