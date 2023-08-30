using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Demon
{
    public partial class Game_Form : Form
    {
        private int birdPos;
        private int gravity;
        private int wallPos;
        private int wallGap;
        private int score;
        private static int scoret;
        private bool status; //0 live, 1 die
        private int key;
        private Random rd = new Random();

        public static int Score { get => scoret; set => scoret = value; }


        public Game_Form()
        {
            InitializeComponent();
            birdPos = cptbBird_up.Location.Y;
            score = 0;
            //at the first time or when the game restarted, the status of the bird will be set false means it is still alive
            status = false; 
            //the space between the walls
            wallGap = 180;
            //the position of the walls
            wallPos = dbfBackground.Width + 200;
            cptbBird_down.Visible = false;
            //gravity will be increased gradually
            gravity = 0;
            //a key object will fly randomly from the left edge of the form
            key = dbfBackground.Width + 200;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ptbTopWall.Height = rd.Next(20, dbfBackground.Height - wallGap - 20);
            ptbBottomWall.Height = dbfBackground.Height - wallGap - ptbTopWall.Height;
            ptbBottomWall.Location = new Point(ptbBottomWall.Location.X, ptbTopWall.Location.Y + ptbTopWall.Height + wallGap);
            //keyhole will be set to be at the middle of the walls
            cptbKeyhole.Location = new Point(ptbBottomWall.Location.X, ptbTopWall.Location.Y + ptbTopWall.Height + wallGap / 2);
            cptbKey.Location = new Point(cptbKey.Location.X, dbfBackground.Height - ptbGound.Height);
            //using color as a condition
            cptbKeyItem.BackColor = Color.Khaki;
        }

        private void timer_Control_Tick(object sender, EventArgs e)
        {
            lblInform.Visible = false;
            //control the bird
            gravity += 2;
            birdPos += gravity;
            if (cptbBird_up.Location.Y < -40)
                birdPos = -40;

            //set the next location for the bird
            cptbBird_up.Location = new Point(cptbBird_up.Location.X, birdPos);
            cptbBird_down.Location = new Point(cptbBird_up.Location.X, birdPos);

            //control the walls
            move();
            //collision check
            isCollision();
            //set the difficulty of the game
            difficulty();
        }

        private void move()
        {
            wallPos -= 5;
            key -= 8;
            ptbTopWall.Location = new Point(wallPos, ptbTopWall.Location.Y);
            ptbBottomWall.Location = new Point(wallPos, ptbBottomWall.Location.Y);
            cptbKeyhole.Location = new Point(wallPos, cptbKeyhole.Location.Y);
            cptbKey.Location = new Point(key, cptbKey.Location.Y);
            if (wallPos < -60)
            {
                wallPos = dbfBackground.Width;
                ptbTopWall.Height = rd.Next(40, dbfBackground.Height - wallGap - 10);
                ptbBottomWall.Height = dbfBackground.Height - wallGap - ptbTopWall.Height;
                ptbBottomWall.Location = new Point(ptbBottomWall.Location.X, ptbTopWall.Location.Y + ptbTopWall.Height + wallGap);
                cptbKeyhole.Location = new Point(ptbBottomWall.Location.X, ptbTopWall.Location.Y + ptbTopWall.Height + wallGap / 2);
                cptbKeyhole.Visible = true;

                //random the next location of the key
                key = dbfBackground.Width;
                cptbKey.Location = new Point(cptbKey.Location.X, rd.Next(15, dbfBackground.Height - ptbGound.Height));
                cptbKey.Visible = true;
                cptbKeyItem.BackColor = Color.Khaki;
            }
        }

        private void isCollision()
        {
            //bird hits the walls or the ground
            if (cptbBird_up.Bounds.IntersectsWith(ptbTopWall.Bounds) || cptbBird_up.Bounds.IntersectsWith(ptbBottomWall.Bounds) ||
                cptbBird_up.Bounds.IntersectsWith(ptbGound.Bounds) || cptbBird_down.Bounds.IntersectsWith(ptbTopWall.Bounds) ||
                cptbBird_down.Bounds.IntersectsWith(ptbBottomWall.Bounds) || cptbBird_down.Bounds.IntersectsWith(ptbGound.Bounds))
            {
                timer_Control.Stop();
                DialogResult dlr = MessageBox.Show("Game over, do you want to play again?", "Answer", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes) 
                {
                    score = 0;
                    lblScoCount.Text = "0";
                    cptbKeyItem.BackColor = Color.Khaki;
                    birdPos = 228;
                    gravity = -15;
                    wallPos = dbfBackground.Width + 200;
                    status = false;
                    cptbKey.Visible = true;
                    cptbKeyhole.Visible = true;
                    key = dbfBackground.Width + 200;
                }
                else if (dlr == DialogResult.No) 
                {
                    Score = Convert.ToInt32(lblBeScoCount.Text);
                    HighScore hs = new HighScore();
                    hs.Show();
                    this.Close();
                }
            }

            //bird hits the key
            if (cptbBird_up.Bounds.IntersectsWith(cptbKey.Bounds) || cptbBird_down.Bounds.IntersectsWith(cptbKey.Bounds))
            {
                cptbKeyItem.BackColor = Color.Crimson;
                cptbKey.Location = new Point(1000, 1000);
            }

            //bird hits the keyhole
            if (cptbBird_down.Bounds.IntersectsWith(cptbKeyhole.Bounds) || cptbBird_up.Bounds.IntersectsWith(cptbKeyhole.Bounds))
            {
                //addition check the backcolor of the KeyItem
                //if it is Crimson, means the bird hit the key before
                //if Khaki, means the bird didn't hit the key before
                if (cptbKeyItem.BackColor == Color.Crimson)
                {
                    score++;
                    lblScoCount.Text = score.ToString();
                    cptbKeyhole.Location = new Point(1000, 1000);
                    if (score > Convert.ToInt32(lblBeScoCount.Text))
                        lblBeScoCount.Text = score.ToString();
                    cptbKeyItem.BackColor = Color.Khaki;
                }
                else
                {
                    timer_Control.Stop();
                    DialogResult dlr = MessageBox.Show("Game over, do you want to play again?", "Answer", MessageBoxButtons.YesNo);
                    if (dlr == DialogResult.Yes)
                    {
                        score = 0;
                        lblScoCount.Text = "0";
                        cptbKeyItem.BackColor = Color.Khaki;
                        birdPos = 228;
                        gravity = -15;
                        wallPos = dbfBackground.Width + 200;
                        status = false;
                        key = dbfBackground.Width + 200;
                        cptbKey.Visible = true;
                        cptbKeyhole.Visible = true;
                    }
                    else if (dlr == DialogResult.No)
                    {
                        Score = Convert.ToInt32(lblBeScoCount.Text);
                        HighScore hs = new HighScore();
                        hs.Show();
                        this.Close();
                    }
                }
            }
        }

        private void difficulty()
        {
            switch (score) 
            {
                case int n when (n >= 6 && n < 11):
                    wallPos -= 6;
                    key -= 9;
                    break;
                case int n when (n >= 11 && n < 16):
                    wallPos -= 7;
                    key -= 10;
                    break;
            }
        }

        private void Game_Form_KeyDown(object sender, KeyEventArgs e)
        {
            //start the game
            switch(e.KeyCode) 
            {
                case Keys.Space:
                case Keys.W:
                    {
                        cptbBird_down.Visible = true;
                        timer_Control.Start();
                    }
                    break;
                default:
                    break;
            }
        }

        private void Game_Form_KeyUp(object sender, KeyEventArgs e)
        {
            cptbBird_down.Visible = false;
        }

        private void Game_Form_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //restart the game
            switch (e.KeyCode)
            {
                case Keys.Space:
                case Keys.W:
                    {
                        if (status)
                        {
                            birdPos = 228;
                            gravity = -15;
                            wallPos = dbfBackground.Width + 200;
                            status = false;
                            cptbKey.Visible = true;
                            key = dbfBackground.Width + 200;
                            cptbKeyhole.Visible = true;
                        }
                        else gravity = -15;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
