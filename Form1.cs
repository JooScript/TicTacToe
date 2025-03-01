using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool IsWinnerExist()
        {
            if (pb11.Tag.ToString() == pb22.Tag.ToString() && pb22.Tag.ToString() == pb33.Tag.ToString() && pb33.Tag.ToString() != "0")
            {
                pb11.BackColor = Color.Green;
                pb22.BackColor = Color.Green;
                pb33.BackColor = Color.Green;

                return true;
            }

            if (pb13.Tag.ToString() == pb22.Tag.ToString() && pb22.Tag.ToString() == pb31.Tag.ToString() && pb31.Tag.ToString() != "0")
            {
                pb13.BackColor = Color.Green;
                pb22.BackColor = Color.Green;
                pb31.BackColor = Color.Green;

                return true;
            }

            if (pb11.Tag.ToString() == pb12.Tag.ToString() && pb12.Tag.ToString() == pb13.Tag.ToString() && pb13.Tag.ToString() != "0")
            {
                pb11.BackColor = Color.Green;
                pb12.BackColor = Color.Green;
                pb13.BackColor = Color.Green;

                return true;
            }

            if (pb21.Tag.ToString() == pb22.Tag.ToString() && pb22.Tag.ToString() == pb23.Tag.ToString() && pb23.Tag.ToString() != "0")
            {
                pb21.BackColor = Color.Green;
                pb22.BackColor = Color.Green;
                pb23.BackColor = Color.Green;

                return true;
            }

            if (pb31.Tag.ToString() == pb32.Tag.ToString() && pb32.Tag.ToString() == pb33.Tag.ToString() && pb33.Tag.ToString() != "0")
            {
                pb31.BackColor = Color.Green;
                pb32.BackColor = Color.Green;
                pb33.BackColor = Color.Green;

                return true;
            }

            if (pb11.Tag.ToString() == pb21.Tag.ToString() && pb21.Tag.ToString() == pb31.Tag.ToString() && pb31.Tag.ToString() != "0")
            {
                pb11.BackColor = Color.Green;
                pb21.BackColor = Color.Green;
                pb31.BackColor = Color.Green;

                return true;
            }

            if (pb12.Tag.ToString() == pb22.Tag.ToString() && pb22.Tag.ToString() == pb32.Tag.ToString() && pb32.Tag.ToString() != "0")
            {
                pb12.BackColor = Color.Green;
                pb22.BackColor = Color.Green;
                pb32.BackColor = Color.Green;

                return true;
            }

            if (pb13.Tag.ToString() == pb23.Tag.ToString() && pb23.Tag.ToString() == pb33.Tag.ToString() && pb33.Tag.ToString() != "0")
            {
                pb13.BackColor = Color.Green;
                pb23.BackColor = Color.Green;
                pb33.BackColor = Color.Green;

                return true;
            }

            return false;
        }

        bool CheckGameRemain()
        {
            return !(pb11.Tag == "0" || pb12.Tag == "0" || pb21.Tag == "0" || pb13.Tag == "0" || pb22.Tag == "0" || pb23.Tag == "0" || pb33.Tag == "0" || pb32.Tag == "0" || pb31.Tag == "0");
        }

        void ChangePlayer()
        {
            if (lbPlayer.Text == "Player 1")
            {
                lbPlayer.Text = "Player 2";
                lbPlayer.Tag = "O";
                return;
            }

            if (lbPlayer.Text == "Player 2")
            {
                lbPlayer.Text = "Player 1";
                lbPlayer.Tag = "X";
                return;
            }
        }

        void Play(object sender)
        {
            if (lbPlayer.Text == "Player 1")
            {
                ((PictureBox)sender).Tag = "X";
                ((PictureBox)sender).Image = Resources.X;
            }
            if (lbPlayer.Text == "Player 2")
            {
                ((PictureBox)sender).Tag = "O";
                ((PictureBox)sender).Image = Resources.O;
            }
            ChangePlayer();
        }

        void DisableGame()
        {
            pb11.Enabled = false;
            pb12.Enabled = false;
            pb13.Enabled = false;
            pb21.Enabled = false;
            pb22.Enabled = false;
            pb23.Enabled = false;
            pb31.Enabled = false;
            pb32.Enabled = false;
            pb33.Enabled = false;
        }

        void EnableGame()
        {
            pb11.Enabled = true;
            pb12.Enabled = true;
            pb13.Enabled = true;
            pb21.Enabled = true;
            pb22.Enabled = true;
            pb23.Enabled = true;
            pb31.Enabled = true;
            pb32.Enabled = true;
            pb33.Enabled = true;
        }


        void RestartGame()
        {
            pb11.Image = Resources.QuestionMark;
            pb12.Image = Resources.QuestionMark;
            pb13.Image = Resources.QuestionMark;
            pb21.Image = Resources.QuestionMark;
            pb22.Image = Resources.QuestionMark;
            pb23.Image = Resources.QuestionMark;
            pb31.Image = Resources.QuestionMark;
            pb32.Image = Resources.QuestionMark;
            pb33.Image = Resources.QuestionMark;

            pb11.Tag = "0";
            pb12.Tag = "0";
            pb13.Tag = "0";
            pb21.Tag = "0";
            pb22.Tag = "0";
            pb23.Tag = "0";
            pb31.Tag = "0";
            pb32.Tag = "0";
            pb33.Tag = "0";

            pb11.BackColor = Color.Black;
            pb12.BackColor = Color.Black;
            pb13.BackColor = Color.Black;
            pb21.BackColor = Color.Black;
            pb22.BackColor = Color.Black;
            pb23.BackColor = Color.Black;
            pb31.BackColor = Color.Black;
            pb32.BackColor = Color.Black;
            pb33.BackColor = Color.Black;

            lbPlayer.Text = "Player 1";
            lbStatus.Text = "In Progress";

            EnableGame();

        }


        void EventOnClick(object sender)
        {
            if (((PictureBox)sender).Tag != "0")
            {
                MessageBox.Show("It is already played here?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            Play(sender);
            if (IsWinnerExist())
            {
                ChangePlayer();
                lbStatus.Text = "Winner";
                DisableGame();
                MessageBox.Show("Winner Winner", "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            if (CheckGameRemain())
            {
                lbStatus.Text = "Draw";
                MessageBox.Show("Game Over?", "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                DisableGame();
                return;
            }

        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            EventOnClick(sender);
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            EventOnClick(sender);
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            EventOnClick(sender);
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            EventOnClick(sender);
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            EventOnClick(sender);
        }

        private void pb23_Click(object sender, EventArgs e)
        {
            EventOnClick(sender);
        }

        private void pb31_Click(object sender, EventArgs e)
        {
            EventOnClick(sender);
        }

        private void pb32_Click(object sender, EventArgs e)
        {
            EventOnClick(sender);
        }

        private void pb33_Click(object sender, EventArgs e)
        {
            EventOnClick(sender);
        }
    }
}
