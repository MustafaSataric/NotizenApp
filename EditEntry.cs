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
    public partial class EditEntry : Form
    {
        List<Notes> notes = Notes.GetNotes();
        public static bool edit;
        public static bool home;
        public EditEntry()
        {
            InitializeComponent();
        }
        //Methode die einen zwanzigzeiligen String zurückgibt
        string FirstTwenty(string input)
        {
            while(input.Length < 20)
            {
                input+= " ";
            }
            return input.Length > 20 ? input.Substring(0, 20) : input;
        }
        //Methode die alle Einträge lädt
        private void LoadEntrys()
        {
            allNotes.Items.Clear();
            notes = Notes.GetNotes();
            for (int i = 0; i < notes.Count; i++)
            {
                allNotes.Items.Add(FirstTwenty(notes[i].Topic) + " " + FirstTwenty(notes[i].Note) + " " + notes[i].Time /*+ " " + notes[i].UuID*/);
            }
            try { allNotes.SelectedIndex = 0; }catch { }
        }
        private void Abrufen_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(UUID.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            if (home)
            {
                active.Top = 191;
                ChangeNote.Visible = false;
                DeleteNote.Visible = false;
                Note.Size = new Size(581, 405);
            }
            else if (edit)
            {
                active.Top = 341;
            }
            else
            {
                active.Top = 416;
            }
            //Form wird Zentriert
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            LoadEntrys();
        }
        //Der gewählte Index wird manipuliert
        private void allNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            title.Text = notes[allNotes.SelectedIndex].Topic;
            Note.Text = notes[allNotes.SelectedIndex].Note;
        }

        //Es wird geprüft ob alle eingaben korrekt sind falls nicht wird erneute eingabe aufgefordert
        //Falls doch wird die Notiz bearbeitet
        private void changeNote_Click(object sender, EventArgs e)
        {
            if (notes.Count == 0)
            {
                MessageBox.Show("Kein Eintrag vorhanden");
            }
            else if (title.Text.Length == 0)
            {
                MessageBox.Show("Bitte Titel eingeben");
            }
            else if (Note.Text.Length == 0)
            {
                MessageBox.Show("Bitte Notiz eingeben");
            }
            else  if (Note.Text.Length != 0 && title.Text.Length != 0 )
            {
                Notes.Change(title.Text, Note.Text, allNotes.SelectedIndex);
                MessageBox.Show("Ein Eintrag wurde bearbeitet");
            }
            LoadEntrys();
        }
        //Eine Notiz wird gelöscht falls vorhanden
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                Notes.Delete(title.Text, Note.Text, allNotes.SelectedIndex);
                LoadEntrys();
                if (notes.Count > 0)
                {
                    MessageBox.Show("Ein Eintrag wurde bearbeitet");
                }
                else
                {
                    MessageBox.Show("Kein Eintrag vorhanden");
                }
            }
            catch {
                MessageBox.Show("Kein Eintrag vorhanden");
            }

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void note_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        //Anwendung wird geschlossen
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Derzeite Uhrzeit wird angezeigt
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime.Text = (" " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
        }
        //Anwendung wird minimiert
        private void MinimalizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Navigation folgt: derzeites Form wird geschlossen neues aufgerufen
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new AddEntry().ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            active.Top = 416;
            ChangeNote.Visible = true;
            DeleteNote.Visible = true;
            Note.Size = new Size(581, 350);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            active.Top = 341;
            ChangeNote.Visible = true;
            DeleteNote.Visible = true;
            Note.Size = new Size(581, 350);
        }

        private void HomeNav_Click(object sender, EventArgs e)
        {
            active.Top = 191;
            ChangeNote.Visible = false;
            DeleteNote.Visible = false;
            Note.Size = new Size(581, 405);
            
        }

        private void InfoNav_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Info().ShowDialog();
        }

       
    }
}
