using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXO
{
    public partial class FormGameXO : Form
    {
        bool chooseGamer = true;
        Game myGame = new Game();

        public FormGameXO()
        {
            InitializeComponent();

            if (chooseGamer)
                //this.Text = "Крестики-нолики -> Очередь игрока 0";
            button9.Text = "Очередь игрока --> 0";
            else
              //  this.Text = "Крестики-нолики -> Очередь игрока X";
            button9.Text = "Очередь игрока --> X";

            //this.ActiveControl = null;

        //    button9.Focus();
        }

        
       

        private void button0_Click(object sender, EventArgs e)
        {
            int curr = Convert.ToInt16(((Button)sender).Tag);
            int checkEnd;


            if (chooseGamer)
                //this.Text = "Крестики-нолики -> Очередь игрока X";
            
            button9.Text = "Очередь игрока --> X";
            else
                //this.Text = "Крестики-нолики -> Очередь игрока 0";
            button9.Text = "Очередь игрока --> 0";




            //MessageBox.Show(temp.ToString(), "Была нажата кнопка с Tag: ");

            if (chooseGamer)
            {
                
                myGame.setValue_X_InMassiv(curr);
                chooseGamer = false;
            }
            else
            {
            
                myGame.setValue_O_InMassiv(curr);
                chooseGamer = true;
            }

            

            refreshWindow();
            checkEnd = myGame.checkToEnd();

            //MessageBox.Show(checkEnd.ToString());
         
            
            if (checkEnd == 1 || checkEnd ==2)
            {
                if (checkEnd == 1)
                {
                    MessageBox.Show("Игра закончена! Победили Х", "Крестики-нолики");
                    button9.Text = "Игра закончена! Победили Х.";
                    for (int i = 0; i < 9; i++)
                        retButton(i).Enabled = false;
                }                    

                if (checkEnd == 2)
                {
                    MessageBox.Show("Игра закончена! Победили 0.", "Крестики-нолики");
                    button9.Text = "Игра закончена! Победили 0";
                    for (int i = 0; i < 9; i++)
                        retButton(i).Enabled = false;
                }
                    
            }

            if (checkEnd == 100)
            {
                MessageBox.Show("Игра закончена! Ничья.", "Крестики-нолики");
                button9.Text = "Игра закончена";
            }
            

        }

        private void refreshWindow()
        {
            for (int i = 0; i < 9; i++)
            {
                //if (myGame.currenValueInMassiv(i) != 0)
                //{
                    if (myGame.currenValueInMassiv(i) == 1)
                    {
                    retButton(i).Text = "X";
                    retButton(i).Enabled = false;
                    }
                    
                    if (myGame.currenValueInMassiv(i) == 2)
                    {
                    retButton(i).Text = "0";
                    retButton(i).Enabled = false;
                    }

                this.SetStyle(ControlStyles.Selectable, false);

                if (myGame.currenValueInMassiv(i) == 0)
                        retButton(i).Text = "";

                button9.Focus();

                //}
                //retButton(i).Text = myGame.currenValueInMassiv(i).ToString();
            }
        }

        private Button retButton(int tag)
        {
            switch(tag)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                default: return null;           
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGame.newGame();

            for (int i = 0; i < 9; i++)              
                    retButton(i).Enabled = true;                
            
            refreshWindow();
        }

        private void FormGameXO_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Первым ходит игрок 0", "Крестики-нолики");
            //button9.Focus();
        }
    }
}
