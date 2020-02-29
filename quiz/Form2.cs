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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        Form4 quizForm = new Form4();
        private void button1_Click(object sender, EventArgs e)
        {
            quizForm.Show();
            this.Close();
        }
        Konto kontoForm = new Konto();
        private void button2_Click(object sender, EventArgs e)
        {
            kontoForm.Show();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }
        private void kontoForm_Closed(object sender, EventArgs e)
        {
           string[] graczeOffline = File.ReadAllLines(@".\graczeOffline.txt");
           listBox1.Items.Clear();
           listBox1.Items.AddRange(graczeOffline);
            listBox1.SetSelected(graczeOffline.Length-1, true);
        }

    }
}
