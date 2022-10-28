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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Info_Load(object sender, EventArgs e)
        {
            //Ecken werden rund dargestellt
            Region = System.Drawing.Region.FromHrgn(UUID.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        //Anwendung wird beendet
        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        //Methode die hyperlink öffnet
        private void HyperLinkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("CMD.exe", "/C start msedge https://github.com/SemirSljiivic");
            }
            catch { MessageBox.Show("Sie haben kein Edge auf ihren Gerät daher funktioniert es nicht."); }
        }

        //Methode die hyperlink öffnet
        private void ClassDiagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("CMD.exe", "/C start msedge https://github.com/SemirSljiivic");
            }
            catch { MessageBox.Show("Sie haben kein Edge auf ihren Gerät daher funktioniert es nicht."); }

            }
        //Anwendung wird Minimiert
        private void MinimalizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Derzeite Uhrzeit wird angezeigt
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime.Text = (" " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
        }

        private void currentTime_Click(object sender, EventArgs e)
        {

        }
        // Navigation folgt: derzeites Form wird geschlossen neues aufgerufen
        private void HomeNav_Click(object sender, EventArgs e)
        {

            EditEntry.home = true;
            this.Visible = false;
            new EditEntry().ShowDialog();
        }

        private void AddNav_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            new AddEntry().ShowDialog();
        }

        private void EditNav_Click(object sender, EventArgs e)
        {
            EditEntry.edit = true;
            this.Visible = false;
            new EditEntry().ShowDialog();
        }

        private void DeleteNav_Click(object sender, EventArgs e)
        {
            EditEntry.edit = false;
            this.Visible = false;
            new EditEntry().ShowDialog();
        }

    }
}
