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

        string FirstTwenty(string input)
        {
            return input.Length > 20 ? input.Substring(0, 20) : input;
        }
        private void Abrufen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                allNotes.Items.Add(FirstTwenty(notes[i].note) + " " + notes[i].topic + " " + notes[i].time + " " + notes[i].uuid);
            }
            allNotes.SelectedIndex = 0;
        }

        private void allNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            title.Text = notes[allNotes.SelectedIndex].topic;
            note.Text = notes[allNotes.SelectedIndex].note;
        }

    }
}
