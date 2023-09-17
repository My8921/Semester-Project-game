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
using System.Data;
namespace WindowsFormsApp5
{
    public partial class Form9 : Form
    {

        int speed;
        int score;
        Random rand = new Random();
        bool gameover;

        DBAccess objdbAccess = new DBAccess();

        string user_name = Form14.name;
        string id = Form14.id;
        DataTable dtReg = new DataTable();
        public Form9()
        {
            InitializeComponent();
            Reset_Game();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (gameover == false)
            {
                var ballon = (PictureBox)sender;
                ballon.Top = rand.Next(700, 1000);
                ballon.Left = rand.Next(5, 500);




                score += 1;
            }


        }

        private void Form9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
                Form9 obj = new Form9();

                obj.Show();


                Reset_Game();

            }
        }
        private void Reset_Game()
        {
            speed = 3;
            score = 0;
            gameover = false;
            pictureBox4.Image = Properties.Resources.bomb;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {

                    x.Top = rand.Next(700, 1000);
                    x.Left = rand.Next(5, 500);


                }
            }
            GameTimer.Start();
          

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
           

            label1.Text = "SCORE:" + score.ToString();
          

            if (gameover == true)
            {


               string prev_Score;




              
                label1.Text = "SCORE " + score + " GAME OVER PRESS ENTER TO START AGAIN";
               

                string query = "Select Ballon_pop from score where U_ID = '" + Form14.id + "'";
                objdbAccess.readDatathroughAdapter(query, dtReg);

                if (dtReg.Rows.Count == 1)
                {
                    //MessageBox.Show(dtReg.Rows[0].ToString());
                    prev_Score = dtReg.Rows[0]["Ballon_pop"].ToString();

                   

               
                    if (int.Parse(prev_Score) < score)
                    {




                        SqlCommand sqlcommand = new SqlCommand("update Score  set Ballon_pop=@sc where U_ID=@id");
                        sqlcommand.Parameters.AddWithValue("@sc", score);
                        sqlcommand.Parameters.AddWithValue("@id", id);
                        int row = objdbAccess.executeQuery(sqlcommand);
                        if (row == 1)
                        {
                            MessageBox.Show("your new score is updated successfully");
                        }



                    }
                    
                }

                GameTimer.Stop();

            }
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        x.Top -= speed;
                    }

                    if (x.Top < -100)
                    {
                        x.Top = rand.Next(700, 1000);
                        x.Left = rand.Next(5, 200);

                    }
                    if (x.Top < -20 && (string)x.Tag == "ballon")
                    {
                        gameover = true;
                    }


                }


            }
        
   
            private void pictureBox4_Click(object sender, EventArgs e)
            {
                if (gameover == false)
                {
                    pictureBox4.Image = Properties.Resources.boom;
                    gameover = true;
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
