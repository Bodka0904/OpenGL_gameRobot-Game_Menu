using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Game_Menu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process.Start(@"C:\Users\Gido\Desktop\Bodka\Game_Menu\MemoryMap\bin\Release\MemoryMap.exe");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


           
        }

        
    }
}
