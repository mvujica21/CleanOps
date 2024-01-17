using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanOps.Models {
    public class Zaposlenik {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string MjestoRodenja { get; set; }
        public DateTime DatumRodenja { get; set; }
        public string Adresa { get; set; }
        public string Mail { get; set; }
        public int BrojTelefona { get; set; }
        public string ZiroRacun { get; set; }
    }
}
