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
    public partial class wyborTrybu : Form
    {
        public wyborTrybu()
        {
            InitializeComponent();
        }
        Form3 OnlineForm = new Form3();
        private void buttonOfflineClick(object sender, EventArgs e)
        {
            File.AppendAllText(@".\temp.txt", "2");
            OnlineForm.Show();
            this.Hide();
        }
        Form2 OfflineForm = new Form2();
        private void buttonOnlineClick(object sender, EventArgs e)
        {
            File.AppendAllText(@".\temp.txt", "1");
            OfflineForm.Show();
            this.Hide();
            
        }

       private void create_temp(object sender, EventArgs e)
        {
            if (File.Exists(@".\temp.txt"))
            {
                File.Delete(@".\temp.txt");
            }
            StreamWriter temp = File.CreateText(@".\temp.txt");
            temp.Close();

            string []dstPath = { @".\graczeOffline.txt", @"wyborQuizu.txt", @"Quiz Ekonomiczny.txt"};
            string []srcPath = { @"..\..\graczeOffline.txt", @"..\..\wyborQuizu.txt", @"..\..\Quiz Ekonomiczny.txt" };
            for(int i=0;i<srcPath.Length;i++)
                if (!File.Exists(dstPath[i]))
                File.Copy(srcPath[i], dstPath[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
