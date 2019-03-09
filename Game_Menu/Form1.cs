using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Game_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void startbtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Gido\Desktop\Bodka\Bodka_Framework\Bodka_Framework\Bodka_Framework.exe");
        }

    }
    
        
}
