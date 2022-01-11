using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruleta
{
    public partial class Uvod : Form
    {
        public Uvod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ruleta = new Ruletaprg();
            ruleta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
