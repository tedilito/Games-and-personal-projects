using static QuickSortApp.Form8;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace QuickSortApp
{
    public partial class Form1 : Form
    {
        int numberOfElemnts;
        double userInputText;
        int checker = 0;
        double[] numbers;
        public Form1()
        {

            InitializeComponent();
            textBox2.Hide();
            textBox1.Hide();
            textBox3.Hide();
            button3.Hide();

            button1.Hide();
            label3.Hide();
            label4.Hide();

            Form3 f2 = new Form3();
            f2.Hide();

            trackBar1.Minimum = 2;
            trackBar1.Maximum = 13;
            trackBar1.Value = 2;



        }
        void SortArray(double[] numbers)
        {
            QuickSort(numbers, 0, numbers.Length - 1);
        }
        private void QuickSort(double[] numbers, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = numbers[left];

            while (i <= j)
            {
                while (numbers[i] < pivot)
                {
                    i++;
                }
                while (numbers[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    var tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;


                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(numbers, left, i);
            }

            if (i < right)
            {
                QuickSort(numbers, i, right);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {




            userInputText = double.Parse(textBox1.Text);


            numbers[checker] = userInputText;
            string unsortedElemnts = string.Join(",", numbers);
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
                SortArray(numbers);
                string elements = string.Join(",", numbers);
                textBox2.Text = elements;

            }
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            numberOfElemnts = trackBar1.Value;
            numbers = new double[numberOfElemnts];
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected to sort numbers. If you are entering a fractional number the decimal point must be a '.' . To start new sorting just close the Sorting Numbers tab and select what you want to sort");
        }
    }



}
