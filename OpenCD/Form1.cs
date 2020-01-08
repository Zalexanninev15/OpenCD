using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace OpenCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString
           (string mciCommand,
           StringBuilder returnValue,
           int returnLength,
           IntPtr callback);

        private void button1_Click(object sender, EventArgs e)
        {
            int result = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Process.Start("https://zalexanninev15.github.io/OpenCD/");
        }
    }
}