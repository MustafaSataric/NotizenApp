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
        public static bool home = true;
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
            //Form wird Zentriert
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            if (home)
            {
                //active.Top = 191;
                ChangeNote.Visible = false;
                DeleteNote.Visible = false;
                Note.Size = new Size(581, 466);
                Note.Enabled = false;
                title.Enabled = false;
            }
            else
            {
                Note.Enabled = true;
                title.Enabled = true;
                ChangeNote.Visible = true;
                DeleteNote.Visible = true;
            }
 
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


 
        //Derzeite Uhrzeit wird angezeigt
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = (DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
        }


    }
}
