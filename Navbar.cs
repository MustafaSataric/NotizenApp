using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotizenApp
{
    public partial class Navbar : Form
    {
        int TgMove, MalX, MalY;
        public Navbar()
        {
            InitializeComponent();
        }
        private void Navbar_Load(object sender, EventArgs e)
        {
            //Form wird zentriert
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            //Ecken werden rund
            Region = System.Drawing.Region.FromHrgn(UUID.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        //Methode die Form als Kindform in Vaterform "Navbar" einfügt
        public void Loadform(object Form)
        {
            if (this.childPanel.Controls.Count > 0)
                this.childPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.childPanel.Controls.Add(f);
            this.childPanel.Tag = f;
            f.Show();
        }
        //Anwendung wird beendet
        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Anwendung wird minimiert
        private void MinimalizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Navigationsbefehle
        private void HomeNav_Click(object sender, EventArgs e)
        {
            active.Visible = true;
            active.Top = HomeNav.Top;
            EditEntry.home = true;
            Loadform(new EditEntry());
            Loadform(new EditEntry());
        }

        private void AddNav_Click(object sender, EventArgs e)
        {
            active.Visible = true;
            active.Top = AddNav.Top;
            Loadform(new AddEntry());
            Loadform(new AddEntry());
        }

        private void EditNav_Click(object sender, EventArgs e)
        {
            active.Visible = true;
            active.Top = EditNav.Top;
            EditEntry.home = false;
            Loadform(new EditEntry());
            Loadform(new EditEntry());
        }

        private void DeleteNav_Click(object sender, EventArgs e)
        {
            active.Visible = true;
            active.Top = DeleteNav.Top;
            EditEntry.home = false;
            Loadform(new EditEntry());
            Loadform(new EditEntry());
        }

        private void InfoNav_Click(object sender, EventArgs e)
        {
            active.Visible = true;
            active.Top = InfoNav.Top;
            Loadform(new Info());
            Loadform(new Info());
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = (DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
        }
        //Methoden um Form verschiebbar zu machen
        //Wenn man auf das Panel klickt wird eine Flagge gesetzt
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            TgMove = 1;
            MalX = e.X;
            MalY = e.Y;
        }
        //Wenn man nicht auf das Panel klickt wird eine Flagge auf falsch gesetzt
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            TgMove = 0;
        }
        //Form wird verschiben falls Panel angeklickt ist und verschoben wird
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TgMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MalX, MousePosition.Y - MalY);
            }
        }
    }
}
