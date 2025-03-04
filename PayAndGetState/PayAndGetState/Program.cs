using System;
using System.Windows.Forms;
using PayAndGetState.Payture;
using System.Configuration;

namespace PayAndGetState
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var paytureApiClient = new PaytureApiClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
            Application.Run(new MainForm(paytureApiClient));
        }
    }
}
