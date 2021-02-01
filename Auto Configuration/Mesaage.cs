using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Configuration.winform
{
    public partial class Mesaage : Form
    {
        public Mesaage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\alim\Documents\Configuration file\data_Mapping.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/select ," + @"C:\Users\alim\Documents\Configuration file\data_Mapping.xml");
           
        }
    }
}
