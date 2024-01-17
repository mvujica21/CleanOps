using CleanOps.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanOps.Repositories {
    public class ZaposlenikRepository
    {
        public static Zaposlenik GetZaposlenik(int id)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE id = {id}";
            return FetchZaposlenik(sql);
        }

        public static List<Zaposlenik> GetAll()
        {
            string sql = $"SELECT * FROM Zaposlenik";
            return getZaposlenici(sql);
        }

        private static List<Zaposlenik> getZaposlenici(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            var zaposlenici = new List<Zaposlenik>();
            Zaposlenik zaposlenik = null;

            while (reader.Read())
            {
                zaposlenik = CreateObject(reader);
                zaposlenici.Add(zaposlenik);
            }
            reader.Close();
            DB.CloseConnection();

            return zaposlenici;
        }

        public static void UkloniZaposlenika(int id)
        {
            string sql = $"DELETE FROM Zaposlenik WHERE id='{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void AddZaposlenik(Zaposlenik zaposlenik)
        {
            string sql = $"INSERT INTO Zaposlenik (korisnickoIme, ime, prezime, lozinka, mjestoRodenja, adresa, datumRodenja, email, brojTelefona, ziroRacun) VALUES ('{zaposlenik.KorisnickoIme}', '{zaposlenik.Ime}', '{zaposlenik.Prezime}', '{zaposlenik.Lozinka}', '{zaposlenik.MjestoRodenja}', '{zaposlenik.Adresa}', '{zaposlenik.DatumRodenja}', '{zaposlenik.Mail}', '{zaposlenik.BrojTelefona}', '{zaposlenik.ZiroRacun}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


        private static Zaposlenik FetchZaposlenik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;

            if(reader.HasRows)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return zaposlenik;
        }

        public static List<Zaposlenik> PretraziZaposlenike(string search)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE Ime='{search}'";
            return PretraziZaposlenika(sql);
        }

        private static List<Zaposlenik> PretraziZaposlenika(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            var zaposlenici = new List<Zaposlenik>();
            Zaposlenik zaposlenik = null;

            while (reader.Read())
            {
                zaposlenik = CreateObject(reader);
                
                    zaposlenici.Add(zaposlenik);
            }
            reader.Close();
            DB.CloseConnection();

            return zaposlenici;
        }

        public static void AzurirajZaposlenik(int id,string Ime, string KorisnickoIme, string Prezime, string Lozinka, string MjestoRodenja, string Adresa, string Mail, int BrojTelefona, string ZiroRacun, DateTime DatumRodenja)
        {
            string sql = $"UPDATE Zaposlenik SET korisnickoIme='{KorisnickoIme}', ime='{Ime}', prezime='{Prezime}', lozinka='{Lozinka}', mjestoRodenja='{MjestoRodenja}', adresa='{Adresa}', datumRodenja='{DatumRodenja}', email='{Mail}', brojTelefona='{BrojTelefona}', ziroRacun='{ZiroRacun}'  WHERE Id='{id}' ";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        
        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            string korisnickoIme = reader["korisnickoIme"].ToString();
            string ime = reader["ime"].ToString();
            string prezime = reader["prezime"].ToString();
            string lozinka = reader["lozinka"].ToString();
            string mjestoRodenja = reader["mjestoRodenja"].ToString();
            string adresa = reader["adresa"].ToString();
            string email = reader["email"].ToString();
            DateTime datumRodenja = DateTime.Parse(reader["datumRodenja"].ToString());
            int brojTelefona = int.Parse(reader["brojTelefona"].ToString());
            string ziroRacun = reader["ziroRacun"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id = id,
                Adresa = adresa,
                KorisnickoIme = korisnickoIme,
                BrojTelefona = brojTelefona,
                ZiroRacun = ziroRacun,
                Ime = ime,
                Prezime = prezime,
                Lozinka = lozinka,
                MjestoRodenja= mjestoRodenja,
                Mail = email,
                DatumRodenja = datumRodenja
            };

            return zaposlenik;

        }
    }
}
