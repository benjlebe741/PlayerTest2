using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerTest2
{
    public partial class Form1 : Form
    {
        bool aDown, wDown, sDown, dDown;
        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        Player player1 = new Player(27);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1.playerHitbox);
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
            //tell me whats happening
            coordinateLabel.Text = $"X:{player1.playerHitbox.X}\nY:{player1.playerHitbox.Y}";
            
            //move player
            if (sDown == true & wDown == false){ player1.moveVertical(1); }
            else if (wDown == true & sDown == false) { player1.moveVertical(-1); }
            if (dDown == true & aDown == false) { player1.moveHorizontal(1); }
            else if (aDown == true & dDown == false) { player1.moveHorizontal(-1); }


            //refresh and move to paint
            Refresh();
        }

        #region Key UP and Key DOWN
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
            }
             
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }
        #endregion
    }
}
