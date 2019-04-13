using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace AutomataTheory
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var Model = new Model();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(Model));
        }
    }
}
