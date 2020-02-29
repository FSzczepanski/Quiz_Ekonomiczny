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
    public partial class QuizEkonomWynik : Form
    {
        public QuizEkonomWynik()
        {
            InitializeComponent();
        }

        private void QuizEkonomWynik_Load(object sender, EventArgs e)
        {
            int wynik = int.Parse(QuizEkonomPytania.score.ToString());
            QuizEkonomPytania.score = 0;
            if (wynik ==1)
            {
                label1.Text = wynik + " punkt";
            }
            else if (wynik == 2 || wynik == 3 || wynik == 4)
            {
                label1.Text = wynik + " punkty";
            }
            else
            {
                label1.Text = wynik + " punktów";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] temp = File.ReadAllLines(@".\temp.txt");
            string tryb = temp[0];
            if (tryb == "1")
            {
                Form2 OfflineForm = new Form2();
                OfflineForm.Show();
            }
            this.Hide();
        }
    }
}
