using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_sald
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new SignIn());
=======
            Application.Run(new test());
            ///Application.Run(new menu_cafe());
>>>>>>> 58b046fce21306365d638ebb8b06b0aced7dc565
        }
    }
}