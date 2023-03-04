using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerTest2
{
    internal class Player
    {
        int horizontalSpeed = 4, verticalSpeed = 4;
        int playerSize;
        public Rectangle playerHitbox = new Rectangle(10, 170, 1, 1);
        public Player(int _playerSize)
        {
        playerSize = _playerSize;
        
            playerHitbox.Width = playerSize;
            playerHitbox.Height = playerSize;
        }

        //move the player on comand
        public void moveVertical(int direction) 
        {
         playerHitbox.Y += (verticalSpeed * direction);
        }
        public void moveHorizontal(int direction)
        {
            playerHitbox.X += (horizontalSpeed * direction);
        }
        public void moveTo(int x, int y)
        {
            playerHitbox.X = x;
            playerHitbox.Y = y;
        }

    }
}
