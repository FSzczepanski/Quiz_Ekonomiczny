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
    public partial class QuizEkonomPytania : Form
    {
        public QuizEkonomPytania()
        {
            InitializeComponent();
        }
        public int[] los = new int[12];
        public static string[] temp= File.ReadAllLines(@".\temp.txt");
        public static string[] pytaniaEkonom = File.ReadAllLines(@".\" + temp[1] + @".txt");
        //public static string[] pytaniaEkonom = File.ReadAllLines(@".\pytaniaEkonom.txt");
        public string PoprawnaOdpowiedz;
        public static int score = 0;
        public int numer = 0;
        int liczbaPytan = pytaniaEkonom.Length / 6;

        QuizEkonomWynik wynikiForm = new QuizEkonomWynik();

        public void startLoad(object sender, EventArgs e)
        {
            QuizEkonomPytanie_Load();
        }
        public void QuizEkonomPytanie_Load()//object sender, EventArgs e
        {
            int ran1;
            Random r1 = new Random();
            bool powtorzenie = false;
            numer++;
            if (numer == 11)
            {
                wynikiForm.Show();
                this.Hide();
            }
            do
                {
                    powtorzenie = false;
                    ran1 = r1.Next(1, liczbaPytan + 1);
                    for(int j=1;j<numer;j++)
                    {
                        if (los[j] == ran1)
                            powtorzenie = true;
                    }
                } while (powtorzenie == true);
                los[numer] = ran1;

            textBox1.Text = pytaniaEkonom[los[numer] * 6 - 6];
            button1.Text = pytaniaEkonom[los[numer] * 6 - 5];
            button2.Text = pytaniaEkonom[los[numer] * 6 - 4];
            button3.Text = pytaniaEkonom[los[numer] * 6 - 3];
            button4.Text = pytaniaEkonom[los[numer] * 6 - 2];
            PoprawnaOdpowiedz = pytaniaEkonom[los[numer] * 6 - 1];
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text==PoprawnaOdpowiedz)
            {
                score++;
                label2.BackColor = System.Drawing.Color.Green;
                label2.Text = "Tak";
            }
            else
              {
                  label2.BackColor = System.Drawing.Color.Red;
                  label2.Text = "Nie";
              }
            QuizEkonomPytanie_Load();
        }


        public void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == PoprawnaOdpowiedz)
            {
                score++;
                label2.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                label2.BackColor = System.Drawing.Color.Red;
                label2.Text = "Nie";
            }
            QuizEkonomPytanie_Load();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == PoprawnaOdpowiedz)
            {
                score++;
                label2.BackColor = System.Drawing.Color.Green;
                label2.Text = "Tak";
            }
            else
            {

                label2.BackColor = System.Drawing.Color.Red;
                label2.Text = "Nie";
            }
            QuizEkonomPytanie_Load();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == PoprawnaOdpowiedz)
            {
                score++;
                label2.BackColor = System.Drawing.Color.Green;
                label2.Text = "Tak";
            }
            else
            {
                label2.BackColor = System.Drawing.Color.Red;
                label2.Text = "Nie";
            }
            QuizEkonomPytanie_Load();
        }
    }
}
