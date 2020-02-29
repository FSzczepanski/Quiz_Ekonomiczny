using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@".\temp.txt", "\n"+WyborQuizu.SelectedItem.ToString());
            string wybranyQuiz = WyborQuizu.SelectedItem.ToString();
            string [] wybranyQuizPytania=File.ReadAllLines(@".\"+wybranyQuiz+@".txt");
            int liczbaPytan = wybranyQuizPytania.Length / 6;
            QuizEkonom EkonomForm = new QuizEkonom();
                EkonomForm.Show();
                this.Hide();
            }

        private void Form4_Shown(object sender, EventArgs e)
        {
            string[] wybor = File.ReadAllLines(@".\wyborQuizu.txt");
            foreach (string q in wybor)
            {
                WyborQuizu.Items.Add(q);
            }
            WyborQuizu.SetSelected(0, true);
        }
    }
}
