using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class Form8 : Form
    {
        bool left;
        bool right;
        bool shooting;
        bool isGameOver;
        int score;
        int playerspeed = 12;
        int bulletspeed;
        int enemyspeed;
        Random rand = new Random();

        DBAccess objdbAccess = new DBAccess();
        DataTable dtReg = new DataTable();

        public Form8()
        {
            InitializeComponent();
            Reset_Game();
        }

        private void Form8_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Right)
            {
                right = true;

            }


            if (e.KeyCode == Keys.Left)
            {
                left = true;

            }






        }

        private void Form8_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                right = false;

            }


            if (e.KeyCode == Keys.Left)
            {
                left = false;

            }


            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
                Bullet.Top = Player.Top;
                Bullet.Left = Player.Left + (Player.Width / 2);

            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                this.Close();
                Form8 obj = new Form8();
                obj.Show();
               
                Reset_Game();


            }

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Reset_Game()
        {
           isGameOver=false;

            enemyspeed = 6;
            E1.Left = rand.Next(10, 615);
            E2.Left = rand.Next(10, 615);
            E3.Left = rand.Next(10, 615);
         

            E1.Top = rand.Next(0, 200) * -1;

            E2.Top = rand.Next(0, 500) * -1;
            E3.Top = rand.Next(0, 900) * -1;

            score = 0;
            bulletspeed = 0;
            Bullet.Left = -300;
            shooting = false;
            label1.Text = "SCORE :" + score.ToString();
            GameTimer.Start();
        }
      
        
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            E1.Top += enemyspeed;
            E2.Top += enemyspeed;
            E3.Top += enemyspeed;




            label1.Text ="SCORE :"+ score.ToString();

            if (isGameOver  == true)
            {


                string prev_Score;





                label1.Text = "SCORE " + score + " GAME OVER PRESS ENTER TO START AGAIN";


                string query = "Select shooter from score where U_ID = '" + Form14.id + "'";
                objdbAccess.readDatathroughAdapter(query, dtReg);

                if (dtReg.Rows.Count == 1)
                {
                    //MessageBox.Show(dtReg.Rows[0].ToString());
                    prev_Score = dtReg.Rows[0]["shooter"].ToString();

                    MessageBox.Show("yes i am in");


                    MessageBox.Show("your prev score is " + prev_Score);
                    MessageBox.Show("your current score is " + score);


                    if (int.Parse(prev_Score) < score)
                    {




                        SqlCommand sqlcommand = new SqlCommand("update Score  set Ballon_pop=@sc where U_ID=@id");
                        sqlcommand.Parameters.AddWithValue("@sc", score);
                        sqlcommand.Parameters.AddWithValue("@id",Form14.id);
                        int row = objdbAccess.executeQuery(sqlcommand);
                        if (row == 1)
                        {
                            MessageBox.Show("your new score is updated successfully");
                        }



                    }

                }

                GameTimer.Stop();

            }


            if (left==true && Player.Left > 0)
            {
                Player.Left -= playerspeed;
            }
            if(right==true && Player.Left< 609)
            {
                Player.Left += playerspeed;
            }

            if(E1.Top>479 || E2.Top >479 || E3.Top >479 )
            {
                isGameOver = true;
            }

            if(shooting==true)
            {
                bulletspeed = 20;

                Bullet.Top -= bulletspeed;

            }
            else
            {
               Bullet.Left = -300;
            }

            if(Bullet.Top < -30)
            {
                shooting = false;
            }



            if(Bullet.Bounds.IntersectsWith(E1.Bounds) )
            {
                score += 1;
                E1.Top = -400;
                E1.Left = rand.Next(20, 600);
                shooting = false;
            }



            if (Bullet.Bounds.IntersectsWith(E2.Bounds))
            {
                score += 1;
                E2.Top = -600;
                E2.Left = rand.Next(20, 600);
                shooting = false;
            }


            if (Bullet.Bounds.IntersectsWith(E3.Bounds))
            {
                score += 1;
                E3.Top = -650;
                E3.Left = rand.Next(20, 600);
                shooting = false;
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form16 obj = new Form16();
            obj.Show();
        }
    }
}
