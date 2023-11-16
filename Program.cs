using appFelxMax.appForms.MainForms;
using appFelxMax.appForms.MenuForms.BillForms;
using appFelxMax.appForms.MenuForms.Program_initialization;
using System;
using System.Windows.Forms;

namespace appFelxMax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPruchasesBill()) ;
        }
    }
}
