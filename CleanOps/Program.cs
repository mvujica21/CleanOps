using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanOps {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB.SetConfiguration("IPS23_mvujica21", "mvujica21", "xDV[rY-6");
            Application.Run(new frmListaZaposlenika());
        }
    }
}
