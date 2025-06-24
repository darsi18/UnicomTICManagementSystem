using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem
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
            Repositories.DatabaseManager.Initialize();
            var loginForm = new Views.LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                string role = loginForm.SelectedRole; 
                Application.Run(new Views.MainForm(role));
            }
        }
    }
}

