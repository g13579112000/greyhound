using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greyhound
{
    public partial class Form1 : Form
    {
        private Guy[] guys;
        private Greyhound[] greyhounds;
        public Form1()
        {
            InitializeComponent();
            string[] names = new string[3]
            {
                "Joe", "Bob", "Al"
            };
            TextBox[] textBoxes = new TextBox[3]
            {
                joeTextBox,bobTextBox,alTextBox
            };
            RadioButton[] radioButtons = new RadioButton[3]
            {
                joeRadioButton,bobRadioButton,alRadioButton
            };
            PictureBox[] pictureBoxes = new PictureBox[4]
            {
                dogPictureBox1,dogPictureBox2,dogPictureBox3,dogPictureBox4
            };
            guys = new Guy[3];
            greyhounds = new Greyhound[4];

            for (int i = 0; i < guys.Length; i++)
            {
                guys[i] = new Guy()
                {
                    Name = names[i],
                    Cash = 1000,
                    MyTextBox = textBoxes[i],
                    MyRadioButtom = radioButtons[i]
                };
                guys[i].UpdateRadioButton();
            }
            for (int i = 0; i < greyhounds.Length; i++)
            {
                greyhounds[i] = new Greyhound()
                {
                    StartingPosition = 65,
                    RacetrackLength = 532,
                    MyPictureBox = pictureBoxes[i]
                };
            }

        }

        private void Initialize()
        {
            for (int i =0; i< greyhounds.Length; i++)
            {
                greyhounds[i].TakeStartingPosition();
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked == true)
                guys[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value-1);
            if (bobRadioButton.Checked == true)
                guys[1].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value-1);
            if (alRadioButton.Checked == true)
                guys[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value-1);
            return;
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            Initialize();
            bool isHaveWinner = false;
            int winnerNumber = 0;
            Random randomlize = new Random();
            while (isHaveWinner == false)
            {
                // 叫出物件實體就是
                // 一個亂數
                int randomNumber = randomlize.Next(greyhounds.Length);
                greyhounds[randomNumber].Run(); // 用這個亂數選取一個 Greyhound，而且讓他跑
                for (int i = 0; i < greyhounds.Length; i++) // 如果沒有任何一隻 greyhound 抵達跑道終點, 則 isHaveWinner 是 false
                {
                    if(greyhounds[i].Location >= greyhounds[i].RacetrackLength)
                    {
                        isHaveWinner = true; // 否則 isHaveWinner 就會是 true
                        winnerNumber = i;
                    }
                }
                
            }
            for(int i = 0; i< guys.Length; i++)
            {
                guys[i].Collect(winnerNumber);
            }
            MessageBox.Show($"Dog #{winnerNumber+1} is Win!");
        }
    }
}
