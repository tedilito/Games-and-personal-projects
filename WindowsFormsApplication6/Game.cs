using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Game : Form
    {

        string systemNum = "";
        string playerNum = string.Empty;
        int countCow = 0;
        int countBull = 0;
        int atempts = 9;

        public Game()
        {
            InitializeComponent();
            Random random = new Random();


            List<int> digits = new List<int>();

            while (digits.Count < 4)
            {

                int num = random.Next(1, 10);


                if (!digits.Contains(num))
                {
                    digits.Add(num);
                }
            }
            systemNum = (string.Join("", digits));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerNum += "1";
            textBox1.Text += button1.Text;

            button1.Enabled = false;
            if (textBox1.TextLength == 4)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerNum += "2";
            textBox1.Text += button2.Text;

            button2.Enabled = false;
            if (textBox1.TextLength == 4)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerNum += "3";
            textBox1.Text += button3.Text;

            button3.Enabled = false;
            if (textBox1.TextLength == 4)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playerNum += "4";
            textBox1.Text += button4.Text;

            button4.Enabled = false;
            if (textBox1.TextLength == 4)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            playerNum += "5";
            textBox1.Text += button5.Text;

            button5.Enabled = false;
            if (textBox1.TextLength == 4)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            playerNum += "6";
            textBox1.Text += button6.Text;

            button6.Enabled = false;
            if (textBox1.TextLength == 4)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            playerNum += "7";
            textBox1.Text += button7.Text;

            button7.Enabled = false;
            if (textBox1.TextLength == 4)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            playerNum += "8";
            textBox1.Text += button8.Text;

            button8.Enabled = false;
            if (textBox1.TextLength == 4)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            playerNum += "9";
            textBox1.Text += button9.Text;

            button9.Enabled = false;
            if (textBox1.TextLength == 4)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
           //listBox1.Items.Add(Convert.ToString(systemNum));
            atempts--;
            label4.Text = Convert.ToString(atempts);

            for (int i = 0; i < systemNum.Length; i++)
            {
                char currentSystemChar = systemNum[i];
                for (int k = 0; k < playerNum.Length; k++)
                {
                    char currentPlayerChar = playerNum[k];

                    if (currentSystemChar == currentPlayerChar)
                    {
                        if (i == k)
                        {
                            countBull++;
                        }
                        else
                        {
                            countCow++;
                        }
                    }


                }
            }

                        label1.Text = Convert.ToString(countCow);
                        label3.Text = Convert.ToString(countBull);


                        button11.Visible = true;

                        // HISTORY.Items.Add("History:");
                        listBox.Items.Add("Result:" + Convert.ToString(playerNum) + " Cow: " + Convert.ToString(countCow) + " Bull: " + Convert.ToString(countBull));
                        playerNum = "";

                    
                    

                
          
            
            if (countBull == 4)
            {
                won f2 = new won();
                f2.Show();
                NotifyIcon n1 = new NotifyIcon();
                n1.Text = "YOU WON ";
                Game f1 = new Game();
                f1.Hide();
            }
            else if (atempts == -1)
            {
                Game f1 = new Game();
                f1.Hide();
            
                label4.Text = "0";
                Lose f3 = new Lose();
                f3.Show();
                //MessageBox.Show("ytfiguoyh08y");



            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //HISTORY.Items.Clear();
            // HISTORY.Items.Add("History:");
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            // button11.Hide();
            textBox1.Clear();
            countCow = 0;
            countBull = 0;
            // bull = false;
            //  cow = false;
            playerNum = string.Empty;
      
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}