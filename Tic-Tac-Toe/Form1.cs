using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   

    public partial class frmSampleForm : Form
    {


        struct Player
        {
            public string Name;
            public char Char;
        }

        Player Player1;
        Player Player2;
        Player CurrentPlayer;

        bool[] ButtonsCheck;
        bool GameOver = false;
        int Counter = 0;
        public frmSampleForm()
        {
            InitializeComponent();

        }

        void ReadButtons()
        {
            ButtonsCheck = new bool[9];
            for(int i = 0; i<9; i++)
            {
                ButtonsCheck[i] = false;
            }
            if((btn1.Tag.ToString())[0] == CurrentPlayer.Char)
                ButtonsCheck[0] = true;
            if ((btn2.Tag.ToString())[0] == CurrentPlayer.Char)
                ButtonsCheck[1] = true;
            if ((btn3.Tag.ToString())[0] == CurrentPlayer.Char)
                ButtonsCheck[2] = true;
            if ((btn4.Tag.ToString())[0] == CurrentPlayer.Char)
                ButtonsCheck[3] = true;
            if ((btn5.Tag.ToString())[0] == CurrentPlayer.Char)
                ButtonsCheck[4] = true;
            if ((btn6.Tag.ToString())[0] == CurrentPlayer.Char)
                ButtonsCheck[5] = true;
            if ((btn7.Tag.ToString())[0] == CurrentPlayer.Char)
                ButtonsCheck[6] = true;
            if ((btn8.Tag.ToString())[0] == CurrentPlayer.Char)
                ButtonsCheck[7] = true;
            if ((btn9.Tag.ToString())[0] == CurrentPlayer.Char)
                ButtonsCheck[8] = true;
        }

        void ChangeButtonsBackgroundColor(Button [] buttons)
        {
            foreach (Button button in buttons)
            {
                button.BackColor = Color.FromArgb(128, 255, 128);
            }
        }
        bool CheckWinPattern()
        {
            bool IsWin = false;
            Button[] Buttons  = new Button[3];
            if (ButtonsCheck[0] == true && ButtonsCheck[1] == true && ButtonsCheck[2] == true)
            {
                Buttons[0] = btn1;
                Buttons[1] = btn2;
                Buttons[2] = btn3;
                ChangeButtonsBackgroundColor(Buttons);
                IsWin = true; 
            }
            else if (ButtonsCheck[3] == true && ButtonsCheck[4] == true && ButtonsCheck[5] == true)
            {
                Buttons[0] = btn4;
                Buttons[1] = btn5;
                Buttons[2] = btn6;
                ChangeButtonsBackgroundColor(Buttons);
                IsWin = true;
            }
            else if (ButtonsCheck[6] == true && ButtonsCheck[7] == true && ButtonsCheck[8] == true)
            {
                Buttons[0] = btn7;
                Buttons[1] = btn8;
                Buttons[2] = btn9;
                ChangeButtonsBackgroundColor(Buttons);
                IsWin = true;
            }
            else if (ButtonsCheck[0] == true && ButtonsCheck[3] == true && ButtonsCheck[6] == true)
            {
                Buttons[0] = btn1;
                Buttons[1] = btn4;
                Buttons[2] = btn7;
                ChangeButtonsBackgroundColor(Buttons);
                IsWin = true;
            }
            else if (ButtonsCheck[1] == true && ButtonsCheck[4] == true && ButtonsCheck[7] == true)
            {
                Buttons[0] = btn2;
                Buttons[1] = btn5;
                Buttons[2] = btn8;
                ChangeButtonsBackgroundColor(Buttons);
                IsWin = true;
            }
            else if (ButtonsCheck[2] == true && ButtonsCheck[5] == true && ButtonsCheck[8] == true)
            {
                Buttons[0] = btn3;
                Buttons[1] = btn6;
                Buttons[2] = btn9;
                ChangeButtonsBackgroundColor(Buttons);
                IsWin = true;
            }
            else if (ButtonsCheck[0] == true && ButtonsCheck[4] == true && ButtonsCheck[8] == true)
            {
                Buttons[0] = btn1;
                Buttons[1] = btn5;
                Buttons[2] = btn9;
                ChangeButtonsBackgroundColor(Buttons);
                IsWin = true;
            }
            else if (ButtonsCheck[2] == true && ButtonsCheck[4] == true && ButtonsCheck[6] == true)
            {
                Buttons[0] = btn3;
                Buttons[1] = btn5;
                Buttons[2] = btn7;
                ChangeButtonsBackgroundColor(Buttons);
                IsWin = true;
            }

            return IsWin;
        }
        bool CheckIfWinner()
        {
            ReadButtons();
            return CheckWinPattern();
           
        }

        void ButtonEvent(Button button)
        {
            if (GameOver)
                return;
            Counter+=1;
            if ((button.Tag.ToString())[0] != '?' )
            {
                MessageBox.Show("Wrong Choice!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurrentPlayer.Char == 'X')
                button.BackgroundImage = Properties.Resources.X;
            else
                button.BackgroundImage = Properties.Resources.O;
            if (CurrentPlayer.Char == Player1.Char)
            {
                button.Tag = Player1.Char;
                if (CheckIfWinner())
                {
                    MessageBox.Show(CurrentPlayer.Name, "Winner");
                    GameOver = true;
                    lbTurn.Text = "GameOver";
                    lbWinner.Text = CurrentPlayer.Name;
                    return;
                }

                CurrentPlayer = Player2;
            }
            else
            {
                button.Tag = Player2.Char;
                if (CheckIfWinner())
                {
                    MessageBox.Show(CurrentPlayer.Name, "Winner");
                    lbWinner.Text = CurrentPlayer.Name;
                    lbTurn.Text = "GameOver";
                    GameOver = true;
                    return;

                }
                CurrentPlayer = Player1;
            }
            if(Counter ==9)
            {
                GameOver = true;
                lbTurn.Text = "GameOver";
                lbWinner.Text = "Draw";
                MessageBox.Show("Draw", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lbTurn.Text = CurrentPlayer.Name;
        }
        private void frmSampleForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White) ;
            pen.Width = 8;
            pen.StartCap =System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 520, 75, 520, 380);

            e.Graphics.DrawLine(pen, 380, 75, 380, 380);

            e.Graphics.DrawLine(pen, 270, 170, 630, 170);

            e.Graphics.DrawLine(pen, 270, 275, 630, 275);

        }

        void ResetButtons(Button button)
        {
            button.BackgroundImage = Properties.Resources.question_mark_96;
            button.Enabled = true;
            button.BackColor = Color.Black;
            button.Tag = "?";
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetButtons(btn1);
            ResetButtons(btn2);
            ResetButtons(btn3);
            ResetButtons(btn4);
            ResetButtons(btn5);
            ResetButtons(btn6); 
            ResetButtons(btn7);
            ResetButtons(btn8);
            ResetButtons(btn9);

            CurrentPlayer = Player1;
            lbWinner.Text = "In Progress";
            lbTurn.Text = CurrentPlayer.Name;
            GameOver = false;
            Counter = 0;    

        }

        private void btn_Click(object sender, EventArgs e)
        {
           
                ButtonEvent((Button)(sender));
        }
        
        private void frmSampleForm_Load(object sender, EventArgs e)
        {
            Player1.Char = 'X';
            Player2.Char = 'O';

            Player1.Name = "Player 1";
            Player2.Name = "Player 2";

            CurrentPlayer = Player1;
        }


    }
}
