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
                MessageBox.Show("Neue Notiz wurde hinzugefügt");
                Notes.AddNote(topic.Text, note.Text);
                topic.Text = "";
                note.Text = "";
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
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime.Text = (" " + DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EditEntry.edit = true;
            new EditEntry().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EditEntry.edit = false;
            new EditEntry().ShowDialog();
        }

        private void HomeNav_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EditEntry.home = true;
            new EditEntry().ShowDialog();
        }
    }
}