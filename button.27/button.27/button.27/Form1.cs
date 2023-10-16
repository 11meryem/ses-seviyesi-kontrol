using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int deger = trackBar1.Value;
            lblSeviyedeger.Text = deger.ToString();

            if (deger >= 0 && deger < 25)
            {
                lblSesSeviyesi.Text = "SES SEVİYESİ DÜŞÜK.";
            }
            else if (deger >= 25 && deger < 70)
            {
                lblSesSeviyesi.Text = "SES SEVİYESİ NORMAL.";
            }
            else if (deger >= 70 && deger < 90)
            {
                lblSesSeviyesi.Text = "SES SEVİYESİ YÜKSEK.";
            }
            else
            {
                lblSesSeviyesi.Text = "SES SEVİYESİ ÇOK YÜKSEK.";
                
            }

        }
    }
}
