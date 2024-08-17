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
    public partial class Form8 : Form
    {

        private Button[] buttons;
        private Queue<Action> actions;
        private System.Windows.Forms.Timer timer;
        private bool isSortingCompleted = false;

        public Form8()
        {
            InitializeComponent();
            buttons = new Button[5];

            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;

            actions = new Queue<Action>();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; 
            timer.Tick += new EventHandler(Timer_Tick);

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }












        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SortArray(buttons);
            ColorButtons(buttons);
            timer.Start();
            button6.Hide();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (actions.Count > 0)
            {
                actions.Dequeue().Invoke();
            }
            else if (!isSortingCompleted)
            {
                ColorButtons(buttons);
                isSortingCompleted = true;
            }
        }

        void SortArray(Button[] buttons)
        {
            QuickSort(buttons, 0, buttons.Length - 1);
        }

        private void QuickSort(Button[] buttons, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = int.Parse(buttons[left].Text);
            actions.Enqueue(() => buttons[left].BackColor = Color.Red);

            while (i <= j)
            {
                while (i <= right && int.Parse(buttons[i].Text) < pivot)
                {
                    i++;
                }
                while (j >= 0 && int.Parse(buttons[j].Text) > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int iCopy = i;
                    int jCopy = j;
                    actions.Enqueue(() =>
                    {
                        var tmp = buttons[iCopy];
                        buttons[iCopy] = buttons[jCopy];
                        buttons[jCopy] = tmp;

                        var tmpLocation = buttons[iCopy].Location;
                        buttons[iCopy].Location = buttons[jCopy].Location;
                        buttons[jCopy].Location = tmpLocation;

                        buttons[iCopy].BackColor = Color.Green;
                        buttons[jCopy].BackColor = Color.Green;

                    });
                    i++;
                    j--;
                }
            }

        


            actions.Enqueue(() => buttons[left].BackColor = Color.Red);
            if (left < j)
            {
                QuickSort(buttons, left, j);
            }

            if (i < right)
            {
                QuickSort(buttons, i, right);
            }
        }


        void ColorButtons(Button[] buttons)
        {
            // Sort the array of buttons based on their Text property
            Button[] sortedButtons = buttons.OrderBy(button => int.Parse(button.Text)).ToArray();

            for (int i = 0; i < sortedButtons.Length - 1; i++)
            {
                // Change the color of the button to blue if it's in the correct position
                if (sortedButtons[i] == buttons[i])
                {
                    actions.Enqueue(() => buttons[i].BackColor = Color.Blue);
                }
                else
                {
                    actions.Enqueue(() => buttons[i].BackColor = Color.Red);
                }
            }
        }


    }
}