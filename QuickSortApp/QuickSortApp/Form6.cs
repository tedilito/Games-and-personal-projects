using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSortApp
{
    public partial class Form6 : Form
    {
        int numberOfElemnts;
        char userInputText;
        int checker = 0;
        char[] chars;
        public Form6()
        {
            InitializeComponent();
            textBox2.Hide();
            textBox1.Hide();
            textBox3.Hide();
            button3.Hide();

            button1.Hide();
            label3.Hide();
            label4.Hide();

            trackBar1.Minimum = 2;
            trackBar1.Maximum = 13;
            trackBar1.Value = 2;
        }
        void SortArray(char[] chars)
        {
            QuickSort(chars, 0, chars.Length - 1);
        }
        private void QuickSort(char[] chars, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = chars[left];

            while (i <= j)
            {
                while (chars[i] < pivot)
                {
                    i++;
                }
                while (chars[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    var tmp = chars[i];
                    chars[i] = chars[j];
                    chars[j] = tmp;


                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(chars, left, i);
            }

            if (i < right)

                QuickSort(chars, i, right);
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Show();
            trackBar1.Hide();
            label1.Hide();
            label2.Hide();
            button2.Hide();
            textBox1.Show();
            button1.Show();

          
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            numberOfElemnts = trackBar1.Value;
            chars = new char[numberOfElemnts];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInputText = Convert.ToChar(textBox1.Text);


            chars[checker] = userInputText;
            string unsortedElemnts = string.Join(",", chars);
            textBox3.Text = unsortedElemnts;
            checker++;
            textBox1.Clear();

            if (checker == numberOfElemnts)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                textBox2.Show();
                label3.Show();
                textBox3.Show();
                label4.Show();
                SortArray(chars);
                string elements = string.Join(",", chars);
                textBox2.Text = elements;

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected to sort chars. You can sort only characters. To start new sorting just close the Sorting Characters tab and select what you want to sort");
        }
    }
    
}
