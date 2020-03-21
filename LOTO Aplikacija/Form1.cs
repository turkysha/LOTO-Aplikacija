using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTO_Aplikacija
{
    public partial class Form1 : Form
    {
        private LOTO loto;
        public Form1()
        {
            InitializeComponent();
            loto = new LOTO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(txtBroj1.Text);
            vrijednosti.Add(txtBroj2.Text);
            vrijednosti.Add(txtBroj3.Text);
            vrijednosti.Add(txtBroj4.Text);
            vrijednosti.Add(txtBroj5.Text);
            vrijednosti.Add(txtBroj6.Text);
            vrijednosti.Add(txtBroj7.Text);
            bool ispravnaKombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                MessageBox.Show("Nije isparvno");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loto.GenerirajDobitnuKombinaciju();
            textBox7.Text = loto.DobitniBrojevi[0].ToString();
            textBox6.Text = loto.DobitniBrojevi[1].ToString();
            textBox5.Text = loto.DobitniBrojevi[2].ToString();
            textBox4.Text = loto.DobitniBrojevi[3].ToString();
            textBox3.Text = loto.DobitniBrojevi[4].ToString();
            textBox2.Text = loto.DobitniBrojevi[5].ToString();
            textBox1.Text = loto.DobitniBrojevi[6].ToString();

            int brojPogodaka = loto.IzracunajBrojPogodaka();
            label2.Text = brojPogodaka.ToString();
        }
    }
}
