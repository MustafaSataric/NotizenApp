using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotizenApp
{
    public class Notes
    {
        public string note;
        public string topic;
        public string uuid;
        public string time;

        Notes(string note, string topic, string uuid, string time)
        {
            this.note = note;
            this.topic = topic;
            this.uuid = uuid;
            this.time = time;
        }

        public static void addNote(string topic, string note)
        {
            using (StreamWriter sw = File.AppendText(System.IO.Directory.GetCurrentDirectory()
            + "/../../../Database/note.txt"))
            {
                sw.WriteLine(UUID.generateUniqueID() + ";" + topic + ";" + note + ";" + (DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year) + ";");

            }
        }

        public static List<Notes> getNotes(){
            List<Notes> notes = new List<Notes>();
            using (StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory()
            + "/../../../Database/note.txt"))
            {
                string line;
                int iLfdNr = 0;
                // Read and display lines from the file until the end of
                // the file is reached.
                while (!sr.EndOfStream)
                {

                    string[] zeile = sr.ReadLine().Split(';');
                    Notes premature = new Notes(zeile[0], zeile[1], zeile[2],zeile[3]);
                    notes.Add(premature);
                }

            }
            return notes;
        }
}
}
