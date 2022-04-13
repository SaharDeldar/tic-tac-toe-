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
        Button[,] dokmeha;
        int ply;
        public Form1()
        {

            InitializeComponent();
   
            dokmeha = new Button[3, 3] {{ button1, button2,button3 },
                                                { button4,button5 ,button6 },
                                               { button7,button8,button9} };
            newgame();
        }
        

        private void button9_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text == "")
            {
                if (ply == 1)
                {
                    this_button.Text = "X";
                    this_button.ForeColor = Color.DarkGreen;
                    this_button.BackColor = Color.LightGreen;

                    ply = 2;
                }
                else if (ply == 2)
                {
                    this_button.Text = "O";
                    this_button.ForeColor = Color.Red;
                    this_button.BackColor = Color.Pink;
                    ply = 1;
                }
                chekgame();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            newgame();
        }
        private void newgame()
        {
            ply = 1;
           
            for (int i = 0; i < 3; i++)

            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].BackColor = Color.Purple;
                    dokmeha[i, j].Text = "";
                }
            }
        }
        private void chekgame()
        {
           if( dokmeha[0,0].Text== "X" && dokmeha[0,1].Text== "X" && dokmeha[0, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
          else if (dokmeha[1, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dokmeha[2, 0].Text == "X" && dokmeha[2, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }

            else if (dokmeha[0, 0].Text == "X" && dokmeha[1, 0].Text == "X" && dokmeha[2,0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dokmeha[0, 1].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dokmeha[2, 0].Text == "X" && dokmeha[2, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }

            else if (dokmeha[0, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dokmeha[0, 2].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dokmeha[0, 0].Text == "O" && dokmeha[0, 1].Text == "O" && dokmeha[0, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dokmeha[1, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dokmeha[2, 0].Text == "O" && dokmeha[2, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dokmeha[0, 0].Text == "O" && dokmeha[1, 0].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dokmeha[0, 1].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dokmeha[2, 0].Text == "O" && dokmeha[2, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }

            else if (dokmeha[0, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dokmeha[0, 2].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dokmeha[0, 0].Text != "" && dokmeha[0, 1].Text != "" && dokmeha[0, 2].Text != "" && dokmeha[1, 0].Text != "" && dokmeha[1, 1].Text != "" && dokmeha[1, 2].Text != "" && dokmeha[2, 0].Text != "" && dokmeha[2, 1].Text != "" && dokmeha[2, 2].Text != "")
            {
                MessageBox.Show("مساوی امتیازات برابر هستند");
                newgame();
            }

        }
    }
} 
