using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NotizenApp
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //Form wird zentriert
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            //Ecken werden rund
            Region = System.Drawing.Region.FromHrgn(UUID.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            circularProgressBar1.Value = 0;
        }

        //Methode die alle 100ms ausgeführt wird, Ladefunktion
        private void timer1_Tick(object sender, EventArgs e)
        {
                circularProgressBar1.Value += 1;
                circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";

            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                new Navbar().Location = new Point((Screen.PrimaryScreen.Bounds.Width - new Navbar().Width) / 2, (Screen.PrimaryScreen.Bounds.Height - new Navbar().Height) / 2);
                Navbar se_form = new Navbar();
                se_form.Show();
                this.Hide();
            }
        }
    }
}
//by Mr. 0182
