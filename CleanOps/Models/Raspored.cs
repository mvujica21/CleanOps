using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CleanOps.Models {
    public class Raspored {
        public int Id { get; set; }
        public TimeSpan VrijemePocetka { get; set; }
        public TimeSpan VrijemeKraja { get; set; }
        public string MjestoRada { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
    }
}
