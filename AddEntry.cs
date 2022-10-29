using System.Threading;
namespace NotizenApp
{
    public partial class AddEntry : Form
    {
        public AddEntry()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Es wird gepr�ft ob alle eingaben korrekt sind falls nicht wird erneute eingabe aufgefordert
            //Falls doch wird neue Notiz hinzugef�gt
            if (topic.Text.Length == 0)
            {
                MessageBox.Show("Bitte Thema eingeben");
            }
            if (note.Text.Length == 0)
            {
                MessageBox.Show("Bitte Notiz eingeben");
            }
            if (topic.Text.Length != 0 && note.Text.Length != 0)
            {
                MessageBox.Show("Neue Notiz wurde hinzugef�gt");
                Notes.AddNote(topic.Text, note.Text);
                topic.Text = "";
                note.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form wird zentriert
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = (DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);

        }
    }
}