using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunstangExercise1
{
    public partial class Form1 : Form
    {
        //The players X and Y coordinates
        int playerX;
        int playerY;

        bool moveUp;
        bool moveDown;
        bool moveRight;
        bool moveLeft;


        public Form1()
        {
            //This code runs when program first starts 
            InitializeComponent();

            //Setting the X and Y coordinates
            playerX = 320;
            playerY = 112;

            //Updating the player's location
            picPlayer.Location = new Point(playerX, playerY);

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            picPlayer.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            picPlayer.Show();
        }

        //When the keys are pressed down
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //When the "W" key is pressed
            if (e.KeyCode == Keys.W)
            {
                moveUp = true;
            }

            if (e.KeyCode == Keys.S)
            {
                moveDown = true;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (moveUp == true)
            {
                //Player moves up by 5 units
                playerY = playerY - 5;

                //Update the player's location 
                picPlayer.Location = new Point(playerX, playerY);
            }

            if (moveDown == true)
            {
                //Player moves up by 5 units
                playerY = playerY + 5;

                //Update the player's location 
                picPlayer.Location = new Point(playerX, playerY);
            }

            if (moveRight == true)
            {
                //Player moves up by 5 units
                playerX = playerX + 5;

                //Update the player's location 
                picPlayer.Location = new Point(playerX, playerY);
            }

            if (moveLeft == true)
            {
                //Player moves up by 5 units
                playerX = playerX - 5;

                //Update the player's location 
                picPlayer.Location = new Point(playerX, playerY);
            }

            if (picPlayer.Bounds.IntersectsWith(picEnemy.Bounds) == true)
            {
                //picPlayer.Visible = false;
                picPlayer.Hide();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
        }
    }
}
