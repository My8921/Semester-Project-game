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
    public partial class Form7 : Form
    {
        bool jump;
        int jumpspeed;
        int force;
        int score;
        int obsspeed;
        Random rand = new Random();
        int position;
        bool gameover;


        DBAccess objdbAccess = new DBAccess();
        DataTable dtReg = new DataTable();

        public Form7()
        {
            InitializeComponent();
            Game_Reset();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {

            Runner.Top += jumpspeed;
            label1.Text = "SCORE :" + score.ToString();
           
            if (jump == true && force <0)
            {
                jump = false;

            }




            if(jump==true)
            {
                jumpspeed = -20;

                force -= 1; //tell the limit;

              

            }

            else
            {
                jumpspeed = 14; //ab usy neecha lany ka liye;
            }

            if (Runner.Top > 312 && jump == false)   // to maintains the balance
            {
                force = 12;
                Runner.Top = 312;
                jumpspeed = 0;
            }




            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obs")
                {
                    x.Left -= obsspeed;


                    if (x.Left < -50)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (Runner.Bounds.IntersectsWith(x.Bounds))
                    {
                       

                            string prev_Score;





                            label1.Text = "SCORE " + score + " GAME OVER PRESS ENTER TO START AGAIN";


                            string query = "Select T_Rex from score where U_ID = '" + Form14.id + "'";
                            objdbAccess.readDatathroughAdapter(query, dtReg);

                            if (dtReg.Rows.Count == 1)
                            {
                                //MessageBox.Show(dtReg.Rows[0].ToString());
                                prev_Score = dtReg.Rows[0]["T_Rex"].ToString();

                                MessageBox.Show("yes i am in");


                                MessageBox.Show("your prev score is " + prev_Score);
                                MessageBox.Show("your current score is " + score);


                                if (int.Parse(prev_Score) < score)
                                {




                                    SqlCommand sqlcommand = new SqlCommand("update Score  set T_Rex=@sc where U_ID=@id");
                                    sqlcommand.Parameters.AddWithValue("@sc", score);
                                    sqlcommand.Parameters.AddWithValue("@id", Form14.id);
                                    int row = objdbAccess.executeQuery(sqlcommand);
                                    if (row == 1)
                                    {
                                        MessageBox.Show("your new score is updated successfully");
                                    }



                                }

                            }

                            GameTimer.Stop();

                    




                        
                        label1.Text = "Press R to Restart the game !!!!!!!!";

                        gameover = true;
                    }
                }
            }









        }
        private void Game_Reset()
        {
            force = 12;

            jumpspeed = 0;
            jump = false;
            score = 0;
            obsspeed = 8;
            label1.Text = "SCORE:" + score.ToString();
            gameover = false;
            Runner.Top = 312;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag=="obs")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 15);


                    x.Left = position;



                }


            }

            GameTimer.Start();

        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Space && jump==false)
            {
                jump = true;
            }


        }

        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {

            if(jump==true)
            {
                jump = false;

            }
            if (e.KeyCode == Keys.R && gameover == true)
            {


                this.Close();
                Form7 obj = new Form7();
                obj.Show();

                Game_Reset();
            }


        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form16 obj = new Form16();
            obj.Show();
        }
    }
}
