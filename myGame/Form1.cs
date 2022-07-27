using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        int ch = 0;
        Button btn;
        bool flag = true;
        

        private void button1_Click(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (flag)
                donafre();
            else
                taknafre();


        }

    

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
        }

     


        bool isWin(string str)
        {

            if (btn1.Text == str && btn2.Text == str && btn3.Text == str)
            {
                MessageBox.Show(str + " is Win !!!!!!!!");
                reset();
                return true;



            }
            else if (btn4.Text == str && btn5.Text == str && btn6.Text == str)
            {
                MessageBox.Show(str + " is Win !!!!!!!!");
                reset();
                return true;


            }
            else if (btn7.Text == str && btn8.Text == str && btn9.Text == str)
            {
                MessageBox.Show(str + " is Win !!!!!!!!");
                reset();
                return true;


            }
            else if (btn7.Text == str && btn1.Text == str && btn4.Text == str)
            {
                MessageBox.Show(str + "is Win !!!!!!!!");
                reset();
                return true;


            }
            else if (btn3.Text == str && btn6.Text == str && btn9.Text == str)
            {
                MessageBox.Show(str + "is Win !!!!!!!!");
                reset();
                return true;


            }
            else if (btn5.Text == str && btn2.Text == str && btn8.Text == str)
            {
                MessageBox.Show(str + " is Win !!!!!!!!");
                reset();
                return true;


            }
            else if (btn5.Text == str && btn3.Text == str && btn7.Text == str)
            {
                MessageBox.Show(str + " is Win !!!!!!!!");
                reset();
                return true;


            }
            else if (btn1.Text == str && btn5.Text == str && btn9.Text == str)
            {
                MessageBox.Show(str + " is Win !!!!!!!!");
                reset();
                return true;


            }

            return false;



        }

        void reset()
        {
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
        }

        void donafre()
        {

            if (ch % 2 == 0)

                btn.Text = "X";
            else
                btn.Text = "O";


            btn.Enabled = false;
            isWin(btn.Text);
            ch++;
        }





        void taknafre()
        {
   
                btn.Text = "X";
                btn.Enabled = false;


            int botch=0;
            bool gg = false;
            Random or = new Random();
            Button[] btnList = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            int rand = or.Next(0, 9);

         
            while (botch<9)
            {
                botch++;
                if (btnList[rand].Text == "")
                {
                    btnList[rand].Text = "O";
                    btnList[rand].Enabled = false;
                    gg=isWin(btnList[rand].Text);
                    
                    break;
                }
                rand = or.Next(0, 9);

             

            }
            if(gg==false)
            isWin(btn.Text);




        }
   

        private void دونفرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = true;
            reset();

        }

        private void تکنفرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = false;
            reset();
                  
                       

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void دربارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("رضا حیدری رشته نرم افزار دانشکده سروش ");
        }

    
    }
}
