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

namespace NotizenApp
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {

            //Form wird zentriert
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            //Ecken werden rund
            Region = System.Drawing.Region.FromHrgn(UUID.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //Anwendung wird Minimiert
        private void MinimalizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = (DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
        }
        //Methode die hyperlink öffnet
        private void OpenDiagram_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("CMD.exe", "/C start msedge https://cdn.discordapp.com/attachments/1023686316937990185/1035982070901637160/klassendiagramm.png");
            }
            catch { MessageBox.Show("Sie haben kein Edge auf ihren Gerät daher funktioniert es nicht."); }
        }
        //Methode die hyperlink öffnet
        private void openGitHub_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("CMD.exe", "/C start msedge https://github.com/SemirSljiivic");
            }
            catch { MessageBox.Show("Sie haben kein Edge auf ihren Gerät daher funktioniert es nicht."); }
        }
    }
}


