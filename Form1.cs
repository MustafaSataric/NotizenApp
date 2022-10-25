using System.Threading;
namespace NotizenApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                Notes.addNote(topic.Text, note.Text);
            }

        }

        private void Thema_Click(object sender, EventArgs e)
        {

        }

        private void currentTime_Click(object sender, EventArgs e)
        {

        }
        private void currentTime_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Tick(object sender, EventArgs e)
        {


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime.Text = (" " + DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);

        }
    }
}