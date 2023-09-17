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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        DataTable dtReg = new DataTable();
        DBAccess objdbAccess = new DBAccess();

        int gravity = 7;
        int score = 0;
       const int pipeSpeed = 4;
        bool gameover = false;
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void Flopytimer_Tick(object sender, EventArgs e)
        {
            pictureBox6.Top += gravity;
            pictureBox7.Left -= pipeSpeed;
            pictureBox8.Left -= pipeSpeed;
            label1.Text = score.ToString();
            if(pictureBox7.Left<-40)
            {

                pictureBox7.Left = 538;
                score++;
            }


            if (pictureBox8.Left < -40)
            {

                pictureBox8.Left = 538;
                score++;
            }
            if((pictureBox6.Bounds.IntersectsWith(pictureBox7.Bounds)) || pictureBox6.Bounds.IntersectsWith(pictureBox8.Bounds) || pictureBox6.Bounds.IntersectsWith(pictureBox5.Bounds)||pictureBox6.Top<-20)
            {
                game_over();
            }



        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -7;
               
            }

        }

        private void Form5_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 7;

            }

            if (e.KeyCode == Keys.Enter && gameover == true)
            {
                this.Close();
                Form5 obj = new Form5();
                obj.Show();
            }

        }


        private void game_over()
        {







            string prev_Score;





            label1.Text = "SCORE " + score + " GAME OVER PRESS ENTER TO START AGAIN";


            string query = "Select FloopyBird from score where U_ID = '" + Form14.id + "'";
            objdbAccess.readDatathroughAdapter(query, dtReg);

            if (dtReg.Rows.Count == 1)
            {
                //MessageBox.Show(dtReg.Rows[0].ToString());
                prev_Score = dtReg.Rows[0]["FloopyBird"].ToString();

                MessageBox.Show("yes i am in");


                MessageBox.Show("your prev score is " + prev_Score);
                MessageBox.Show("your current score is " + score);


                if (int.Parse(prev_Score) < score)
                {




                    SqlCommand sqlcommand = new SqlCommand("update Score  set FloopyBird=@sc where U_ID=@id");
                    sqlcommand.Parameters.AddWithValue("@sc", score);
                    sqlcommand.Parameters.AddWithValue("@id", Form14.id);
                    int row = objdbAccess.executeQuery(sqlcommand);
                    if (row == 1)
                    {
                        MessageBox.Show("your new score is updated successfully");
                    }



                }

            }

           







            gameover = true;
            Flopytimer.Stop();
            label1.Text += " GAME OVER !!!!!!!!!!!!!! PRESS ENTER  TO RESTART THE GAME";









        }

    }
}
