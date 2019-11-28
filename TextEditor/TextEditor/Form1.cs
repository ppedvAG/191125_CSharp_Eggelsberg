using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



using System.IO; // Input/Output - Operationen : Zugriff auf das Filesystem von Windows
using System.Xml.Serialization;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ziel: Alles, was in der Textbox drinnen steht, in eine Textdatei (.txt) gespeichert wird

            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, textBoxInhalt.Text);
                MessageBox.Show("Ihre Datei wurde erfolgreich gespeichert !");
            }
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Textdatei|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxInhalt.Text = File.ReadAllText(dlg.FileName);
                MessageBox.Show("Ihre Datei wurde erfolgreich geöffnet !");
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Windows Forms schließen:
            Close();

            // File -> Arbeiten mit Dateien
            // Directory -> Arbeiten mit Ordner

            // File.AppendText("demo"); //An eine Log-Datei was dazuschreiben

        }

        private void personAlsXMLSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            p1.Vorname = "Tom";
            p1.Nachname = "Ate";
            p1.Alter = 10;
            p1.Kontostand = 100;

            // Person als XML speichern:
            // XMLSerializer

            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            FileStream stream = new FileStream("Person.xml", FileMode.Create);

            serializer.Serialize(stream, p1);
            stream.Close();
        }

        private void personAusXMLLesenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            FileStream stream = new FileStream("Person.xml", FileMode.Open);

            // Cast
            Person p1 = (Person)serializer.Deserialize(stream);
            stream.Close();

            MessageBox.Show(p1.Vorname + " " + p1.Nachname);
        }
    }
}
