using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HalloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKlickMich_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo Welt");
            MessageBox.Show("Wollen wir eine Pause machen?",
                            "Eine wichtige Frage", 
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
        }
    }
}
