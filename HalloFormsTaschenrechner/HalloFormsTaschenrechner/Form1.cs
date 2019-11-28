using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HalloFormsTaschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int zahl1 = int.Parse(textBoxZahl1.Text);
            int zahl2 = int.Parse(textBoxZahl2.Text);

            int erg = zahl1 + zahl2;

            textBoxErg.Text = erg.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            int zahl1 = int.Parse(textBoxZahl1.Text);
            int zahl2 = int.Parse(textBoxZahl2.Text);

            int erg = zahl1 - zahl2;

            textBoxErg.Text = erg.ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            int zahl1 = int.Parse(textBoxZahl1.Text);
            int zahl2 = int.Parse(textBoxZahl2.Text);

            int erg = zahl1 * zahl2;

            textBoxErg.Text = erg.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            int zahl1 = int.Parse(textBoxZahl1.Text);
            int zahl2 = int.Parse(textBoxZahl2.Text);

            int erg = zahl1 / zahl2;

            textBoxErg.Text = erg.ToString();
        }
    }
}
