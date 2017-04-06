using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace eDNA_watcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eDNAReader reader = new eDNAReader();
            RealResult res = reader.getReal("WRLDC.PHASOR.WRDC0783");
            if (res !=null)
            {
                if(true) //status check here
                {
                    scadaValTextBox.Text = res.dval.ToString("0.##"); ;
                }
            }
        }
    }
}
