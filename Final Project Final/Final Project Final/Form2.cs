using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Final
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        int speed = -15; //Initialize Alien Spaceship speed, bullet speed, and score
        int score = 0;
        int bulletspeed = 15;
        private void timer1_Tick(object sender, EventArgs e) //Timer for Alien Spaceship movement
        {
            Resume.Hide(); //Hides labels that can later be activated/shown
            GameOverBox.Hide();
            FinalScore.Hide();
            AlienSpaceship1.Left += speed; //Makes Alien Spaceship move and makes it bounce back and forth by setting boundaries
            if (AlienSpaceship1.Left <= 0) speed = 15;
            if (AlienSpaceship1.Right > 824) speed = -15;
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e) //Connects Shooter's movement and actions to the keyboard
        {
            if (e.KeyCode == Keys.Left) //move left with left arrow key
            {
                if (Shooter.Left > 0)
                    Shooter.Left += -9;
            }
            if (e.KeyCode == Keys.Right) //move right with right arrow key
            {
                if (Shooter.Right < 824)
                    Shooter.Left += 9;
            }
            if (e.KeyCode == Keys.Space) //hit spacebar to shoot
            {
                Bullet.Show();
                Bullet.Left = Shooter.Left + 41;
                Bullet.Top = Shooter.Top;

            }
        }
        private void hitEnemy() //function that increases score and resets Aliens and bullet when a bullet hits an Alien
        {

            if (Bullet.Bounds.IntersectsWith(Alien1.Bounds))
            {
                score += 5;
                Alien1.Left = AlienSpaceship1.Left + 55;
                Alien1.Top = AlienSpaceship1.Top + 75;

                Bullet.Top = -100;
                Bullet.Left = -100;

            }
            if (Bullet.Bounds.IntersectsWith(Alien2.Bounds))
            {
                score += 5;
                Alien2.Left = AlienSpaceship1.Left + 55;
                Alien2.Top = AlienSpaceship1.Top + 75;

                Bullet.Top = -100;
                Bullet.Left = -100;
            }
            if (Bullet.Bounds.IntersectsWith(Alien3.Bounds))
            {
                score += 5;
                Alien3.Left = AlienSpaceship1.Left + 55;
                Alien3.Top = AlienSpaceship1.Top + 75;

                Bullet.Top = -100;
                Bullet.Left = -100;
            }
        }
        private void GameOver() //function that shows final score, shows game over box, and stops all movement when player reaches 0 hearts
        {
            FinalScore.Text = " ";
            FinalScore.Text = Score.Text;
            FinalScore.Show();
            GameOverBox.Show();
            timer1.Enabled = false;
            timer2.Enabled = false;

        }
        private void Hearts1() //function that takes a heart away whenever the player is hit by an Alien
        {

            if (Shooter.Bounds.IntersectsWith(Alien1.Bounds) && Heart1.Left < 139)
            {
                Heart1.Hide();
                Heart1.Left += 1;
                Alien1.Left = AlienSpaceship1.Left + 55;
                Alien1.Top = AlienSpaceship1.Top + 75;

            }
            if (Shooter.Bounds.IntersectsWith(Alien2.Bounds) && Heart1.Left < 139)
            {
                Heart1.Hide();
                Heart1.Left += 1;
                Alien2.Left = AlienSpaceship1.Left + 55;
                Alien2.Top = AlienSpaceship1.Top + 75;
            }
            if (Shooter.Bounds.IntersectsWith(Alien3.Bounds) && Heart1.Left < 139)
            {
                Heart1.Hide();
                Heart1.Left += 1;
                Alien3.Left = AlienSpaceship1.Left + 55;
                Alien3.Top = AlienSpaceship1.Top + 75;
            }
            if (Shooter.Bounds.IntersectsWith(Alien1.Bounds) && Heart1.Left == 139)
            {
                Heart3.Hide();
                Heart3.Left += 1;

                Alien1.Left = AlienSpaceship1.Left + 55;
                Alien1.Top = AlienSpaceship1.Top + 75;
            }
            if (Shooter.Bounds.IntersectsWith(Alien2.Bounds) && Heart1.Left == 139)
            {
                Heart3.Hide();
                Heart3.Left += 1;

                Alien2.Left = AlienSpaceship1.Left + 55;
                Alien2.Top = AlienSpaceship1.Top + 75;
            }
            if (Shooter.Bounds.IntersectsWith(Alien3.Bounds) && Heart1.Left == 139)
            {
                Heart3.Hide();
                Heart3.Left += 1;

                Alien3.Left = AlienSpaceship1.Left + 55;
                Alien3.Top = AlienSpaceship1.Top + 75;

            }
            if (Heart1.Left == 139 && Heart3.Left > 207)
            {
                Heart2.Hide();
                Heart2.Left += 1;
                GameOver(); //calls on GameOver function when there are 0 hearts
            }

        }
        private void LosePoints() //function that takes away points when an Alien reaches the ground
        {
            if (Alien1.Top >= 554)
            {
                score -= 10;
            }
            if (Alien2.Top >= 554)
            {
                score -= 10;
            }
            if (Alien3.Top >= 554)
            {
                score -= 10;
            }
        }
        private void InvisibleAlienPoints() //function that prevents player from losing points in the beginning when first two aliens are invisible
        {
            if (Alien2.Left == 146)
            {

                Score.Text = "" + score;
            }
            else if (Alien3.Left == 645)
            {

                Score.Text = "" + score;
            }
            else
            {
                LosePoints();
            }
        }

        private void timer2_Tick(object sender, EventArgs e) //Timer for Alien movement
        {
            //Function hides, sets boundaries for, and moves Aliens
            if (Alien2.Left == 146)//Hides Alien2 in the beginning so player won't be overwhelmed
            {
                Alien2.Hide();
            }
            if (Alien2.Top <= 554)
            {

                Alien2.Top += 11; //set Alien2 speed to 11
            }

            else
            {
                Alien2.Show(); //resets Alien to Alien Spaceship
                Alien2.Left = AlienSpaceship1.Left + 55;
                Alien2.Top = AlienSpaceship1.Top + 75;
            }
            if (Alien3.Left == 645)//Hides Alien3 in the beginning so player won't be overwhelmed
            {
                Alien3.Hide();
            }
            if (Alien3.Top <= 554)
            {

                Alien3.Top += 11;//set Alien3 speed to 11
            }

            else
            {
                Alien3.Show();//resets Alien to Alien Spaceship
                Alien3.Left = AlienSpaceship1.Left + 55;
                Alien3.Top = AlienSpaceship1.Top + 75;
            }
            if (Alien1.Top <= 554)
            {
                Alien1.Top += 11;//set Alien1 speed to 11

            }

            else
            {
                Alien1.Left = AlienSpaceship1.Left + 55; //resets Alien to Alien Spaceship
                Alien1.Top = AlienSpaceship1.Top + 75;


            }
            if (Bullet.Top == 357 || Bullet.Top == 384) //makes bullet invisible until player pushes spacebar to shoot
            {
                Bullet.Hide();
            }

            Bullet.Top -= bulletspeed; //makes bullet move
            Score.Text = "" + score; //increases score
            hitEnemy(); //calls on hitEnemy function
            Hearts1(); //calls on Hearts1 function
            InvisibleAlienPoints(); //calls on InvisibleAlienPoints function
        }

        private void Alien1_Click(object sender, EventArgs e)
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Heart1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)//Allows the player to go back to the main menu form when clicked
        {
            Form1 firstform = new Form1();
            firstform.Show();
            this.Hide(); //hides game form
            timer1.Enabled = false; //stops the game
            timer2.Enabled = false;
        }

        private void Pause_Click(object sender, EventArgs e)//Allows the player to pause the game when clicked
        {
            timer1.Enabled = false; //stops game movement
            timer2.Enabled = false;
            Resume.Show(); //Gives the player a choice to resume the game

        }

        private void Resume_Click(object sender, EventArgs e)//Allows the player to resume the game when clicked
        {
            timer1.Enabled = true; //continues game movement
            timer2.Enabled = true;
        }

        private void GameOverBox_Click_1(object sender, EventArgs e)//Allows player to restart the game when clicked
        {
            //lables,score,movement,locations,hearts,and timers restarted
            GameOverBox.Hide();
            FinalScore.Hide();
            Bullet.Hide();
            score = 0;
            Heart1.Left = 138;
            Heart1.Show();
            Heart2.Left = 266;
            Heart2.Show();
            Heart3.Left = 206;
            Heart3.Show();
            Alien1.Left = AlienSpaceship1.Left + 55;
            Alien1.Top = AlienSpaceship1.Top + 75;
            Alien2.Left = AlienSpaceship1.Left + 100;
            Alien2.Top = AlienSpaceship1.Top + 75;
            Alien3.Left = AlienSpaceship1.Left + 150;
            Alien3.Top = AlienSpaceship1.Top + 75;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
    }

}

