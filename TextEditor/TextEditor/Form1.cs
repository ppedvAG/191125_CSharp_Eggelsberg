using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // Input/Output - Operationen : Zugriff auf das Filesystem von Windows

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
        }
    }
}
