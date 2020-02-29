using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace quiz
{
    public partial class Konto : Form
    {
        public Konto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string noweKonto = "\n"+textBox1.Text;
            textBox1.Clear();
            bool powtorzenie = false;
            string[] graczeOffline = File.ReadAllLines(@".\graczeOffline.txt");
            for (int i = 0; i < graczeOffline.Length; i++)
            {
                if (noweKonto.Trim() == graczeOffline[i])
                {
                    MessageBox.Show("Istnieje konto o takiej nazwie. Wpisz inną nazwę");
                    powtorzenie = true;
                    break;
                }
            }
            if(!powtorzenie)
            {
                MessageBox.Show("konto utworzone");
                File.AppendAllText(@".\graczeOffline.txt", noweKonto);
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
