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
    public partial class QuizEkonom : Form
    {
        public QuizEkonom()
        {
            InitializeComponent();
        }
        QuizEkonomPytania PytaniaForm = new QuizEkonomPytania();
       
        private void button1_Click(object sender, EventArgs e)
        {
            PytaniaForm.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void QuizEkonom_Load(object sender, EventArgs e)
        {

        }
         private void quizName(object sender, EventArgs e)
{
    string [] temp= File.ReadAllLines(@".\temp.txt");
    label1.Text=temp[1];
}
    }
}
