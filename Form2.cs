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
    public partial class Form2 : Form
    {
        private Form1 forma1;

        private List<Pitanje> pitanja = new List<Pitanje>();

        public Form2(Form1 forma1)
        {
            InitializeComponent();
            this.forma1 = forma1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pitanje pitanje = new Pitanje();
            pitanje.TekstPitanja = textBox1.Text;
            pitanje.BrojBodova = float.Parse(textBox2.Text);

            pitanja.Add(pitanje);
            forma1.dataGridView1.Rows.Add(pitanja.Last().TekstPitanja, pitanja.Last().BrojBodova);
            forma1.dataGridView1.Update();
        }
    }
}
