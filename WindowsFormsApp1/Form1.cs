using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool xTurn = true;
        private int CheckWin()
        {
            if (button1.Text == "X" && button2.Text == "X" && button5.Text == "X") return 1;
            if (button3.Text == "X" && button4.Text == "X" && button6.Text == "X") return 1;
            if (button9.Text == "X" && button7.Text == "X" && button8.Text == "X") return 1;
            if (button1.Text == "X" && button3.Text == "X" && button7.Text == "X") return 1;
            if (button2.Text == "X" && button4.Text == "X" && button8.Text == "X") return 1;
            if (button5.Text == "X" && button6.Text == "X" && button9.Text == "X") return 1;
            if (button1.Text == "X" && button4.Text == "X" && button9.Text == "X") return 1;
            if (button5.Text == "X" && button4.Text == "X" && button7.Text == "X") return 1;

            if (button1.Text == "O" && button2.Text == "O" && button5.Text == "O") return 0;
            if (button3.Text == "O" && button4.Text == "O" && button6.Text == "O") return 0;
            if (button9.Text == "O" && button7.Text == "O" && button8.Text == "O") return 0;
            if (button1.Text == "O" && button3.Text == "O" && button7.Text == "O") return 0;
            if (button2.Text == "O" && button4.Text == "O" && button8.Text == "O") return 0;
            if (button5.Text == "O" && button6.Text == "O" && button9.Text == "O") return 0;
            if (button1.Text == "O" && button4.Text == "O" && button9.Text == "O") return 0;
            if (button5.Text == "O" && button4.Text == "O" && button7.Text == "O") return 0;
            return -1;
        }
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xTurn = true;
        }
        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xTurn = false;
        }
        int XCount = 0;
        int OCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Button senderB = (Button)sender;
            if (xTurn)
            {
                senderB.Text = "X";
                XCount++;
            }
            else
            {
                OCount++;
                senderB.Text = "O";
            }
            xTurn = !xTurn;
            senderB.Enabled = false;
            if (XCount >= 3 || OCount >= 3)
            {
                int s = CheckWin();
                if (s == 1)
                {
                    MessageBox.Show("Player X Win", "Player X Win", MessageBoxButtons.OK);
                    Application.Restart();
                    XCount = 0;
                    OCount = 0;
                }
                if (s == 0)
                {
                    MessageBox.Show("Player O Win", "Player O Win", MessageBoxButtons.OK);
                    Application.Restart();
                    XCount = 0;
                    OCount = 0;
                }
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator: Denis Melnyk \nhttps://github.com/germiBest", "Credits", MessageBoxButtons.OK);
        }
    }
}