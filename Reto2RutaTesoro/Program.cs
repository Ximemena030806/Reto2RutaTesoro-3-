using System;
using System.Windows.Forms;

namespace Reto2RutaTesoro
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmRutaTesoro());
        }
    }
}
