using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//  Copied from: https://stackoverflow.com/questions/20841501/blockinput-method-doesnt-work-on-windows-7

namespace blockinput
{
    static class InputBlocker
    {
        [DllImport("user32.dll")]
        static extern bool BlockInput(bool fBlockIt);
        private static Timer timer = new Timer();
        static InputBlocker()
        {
            timer.Tick += new EventHandler(tick);
        }
        public static void Block(int mill)
        {
            BlockInput(true);
            timer.Interval = mill;
            timer.Start();
        }
        private static void tick(object sender, EventArgs e)
        {
            BlockInput(false);
            timer.Stop();
        }
    }
}
