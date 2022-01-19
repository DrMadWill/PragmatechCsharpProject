using ParfumUI.CatogoryView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParfumUI
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
            SalePriceLists salePriceLists = new SalePriceLists();
            RefresData.salePriceLists = salePriceLists;
            Application.Run(salePriceLists);
        }
    }
}
