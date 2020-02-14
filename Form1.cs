using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rok
{
    public partial class Form1 : Form
    {
        private List<IspitniRok> ispitniRok = new List<IspitniRok>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IspitniRok rok = new IspitniRok();
            rok.NazivPredmeta = textBox1.Text;
            rok.NazivRoka = textBox2.Text;
            rok.Datum = dateTimePicker1.Value;

            ispitniRok.Add(rok);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2(this);
            forma2.ShowDialog();
        }

    }
}
