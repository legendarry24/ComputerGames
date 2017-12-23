using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGames
{
    enum TableName {Developer, Game, Genre, Publisher, Stylistics}

    static class Data
    {
        public static string[] StrValue { get; set; } = new string[12];
        public static TableName TableName;
        public static bool CorrectPassword { get; set; }
    }
    
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
            Application.Run(new MainForm());          
        }
    }
}
