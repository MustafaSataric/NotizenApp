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
    public partial class Show : Form
    {
        List<Notes> notes = Notes.getNotes();

        public Show()
        {
            InitializeComponent();
        }

        string firstTwenty(string input)
        {
            return input.Length > 20 ? input.Substring(0, 20) : input;
        }

        private void loadEntrys()
        {
            allNotes.Items.Clear();
            notes = Notes.getNotes();
            for (int i = 0; i < notes.Count; i++)
            {
                allNotes.Items.Add(firstTwenty(notes[i].topic) + " " + notes[i].note + " " + notes[i].time /*+ " " + notes[i].uuid*/);
            }
            try { allNotes.SelectedIndex = 0; }catch { }
        }
        private void Abrufen_Load(object sender, EventArgs e)
        {
            loadEntrys();
        }

        private void allNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            title.Text = notes[allNotes.SelectedIndex].topic;
            note.Text = notes[allNotes.SelectedIndex].note;
        }

        private void changeNote_Click(object sender, EventArgs e)
        {
            if(title.Text.Length == 0)
            {
                MessageBox.Show("Bitte Titel eingeben");
            }
            if (note.Text.Length == 0)
            {
                MessageBox.Show("Bitte Notiz eingeben");
            }
            if (note.Text.Length != 0 && title.Text.Length != 0)
            {
                Notes.change(title.Text, note.Text, allNotes.SelectedIndex);
            }
            loadEntrys();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                Notes.delete(title.Text, note.Text, allNotes.SelectedIndex);
                loadEntrys();
                MessageBox.Show("Ein Eintrag wurde gelöscht");
            }
            catch {
                MessageBox.Show("Kein Eintrag vorhanden");
            }

        }
    }
}
