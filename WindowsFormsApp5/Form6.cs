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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
           Resetgame();
        }
        int roadspeed;
        int trafficspeed;
        int playerspeed = 12;
        int score;
        int carimage;

        Random r = new Random();
        Random carposition = new Random();

        DBAccess objdbAccess = new DBAccess();
        DataTable dtReg = new DataTable();
        bool left;
        bool right;

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Track1_Click(object sender, EventArgs e)
        {

        }

        private void track2_Click(object sender, EventArgs e)
        {

        }

        private void Down(object sender, MouseEventArgs e)
        {

        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                left = true;
            }

            if(e.KeyCode==Keys.Right)
            {
                right = true;

            }
        }

        private void Form6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                right = false;

            }
        }
        private void changecar(PictureBox tempcar)
        {
            carimage = r.Next(1,9);


            switch(carimage)
            {
                case 1:
                    tempcar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempcar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempcar.Image = Properties.Resources.carGrey;
                    break;

                case 4:
                    tempcar.Image = Properties.Resources.carOrange;
                    break;


                case 5:
                    tempcar.Image = Properties.Resources.carPink;
                    break;

                case 6:
                    tempcar.Image = Properties.Resources.CarRed;
                    break;
                case 7:


                    tempcar.Image = Properties.Resources.carYellow;
                    break;

                case 8:
                    tempcar.Image = Properties.Resources.TruckBlue;
                    break;

                case 9:

                    tempcar.Image = Properties.Resources.TruckWhite;
                    break;}

            tempcar.Top = carposition.Next(200, 500)*-1;

            if((string)tempcar.Tag=="left")
            {
                tempcar.Left = carposition.Next(5, 191);
            }

            if ((string)tempcar.Tag == "right")
            {
               tempcar.Left = carposition.Next(255, 388);
            }



        }


        private void over()
        {

            string prev_Score;





          
            string query = "Select car_racing from score where U_ID = '" + Form14.id + "'";
            objdbAccess.readDatathroughAdapter(query, dtReg);

            if (dtReg.Rows.Count == 1)
            {
                //MessageBox.Show(dtReg.Rows[0].ToString());
                prev_Score = dtReg.Rows[0]["car_racing"].ToString();

                MessageBox.Show("yes i am in");


                MessageBox.Show("your prev score is " + prev_Score);
                MessageBox.Show("your current score is " + score);


                if (int.Parse(prev_Score) < score)
                {




                    SqlCommand sqlcommand = new SqlCommand("update Score  set car_racing=@sc where U_ID=@id");
                    sqlcommand.Parameters.AddWithValue("@sc", score);
                    sqlcommand.Parameters.AddWithValue("@id", Form14.id);
                    int row = objdbAccess.executeQuery(sqlcommand);
                    if (row == 1)
                    {
                        MessageBox.Show("your new score is updated successfully");
                    }



                }

            }
            


























            playSound();
            Game.Stop();

            Explosion.Visible = true;
            Player.Controls.Add(Explosion);
            Explosion.Location = new Point(-8, 5);
            Explosion.BackColor = Color.Transparent;
            Award.Visible = true;
            Award.BringToFront();

            button1.Enabled = true;
        }

        private void Resetgame()
        {
            button1.Enabled = false;
            Explosion.Visible = false;
            Award.Visible = false;
            left = false;
            right = false;
            score = 0;
            Award.Image = Properties.Resources.bronze;
            roadspeed = 5;
            trafficspeed = 15;

            Car1.Top = carposition.Next(200,500) * -1;
            Car1.Left = carposition.Next(49, 191);

            Car2.Top = carposition.Next(200, 500) * -1;
            Car2.Left = carposition.Next(255, 388);

            Game.Start();





        }
        
        private void playSound()
        {
            System.Media.SoundPlayer hitted = new System.Media.SoundPlayer(Properties.Resources.hit);
            hitted.Play();
        }

        private void Game_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score:" + score.ToString();
            score++;
            if(Player.Left>8 && left==true)
            {
                Player.Left -= playerspeed;
            }

            if (Player.Left < 425 && right == true)
            {
                Player.Left += playerspeed;
            }

            Track1.Top += roadspeed;
            track2.Top += roadspeed;

            if (Track1.Top>491)
            {
                Track1.Top = -491;
            }

            if (track2.Top >491 )
            {
                track2.Top = -491;
            }
            Car1.Top += trafficspeed;
            Car2.Top += trafficspeed;

            if(Car1.Top>360)
            {
                changecar(Car1);
            }

            if (Car2.Top > 360)
            {
                changecar(Car2);
            }

            if(Player.Bounds.IntersectsWith(Car1.Bounds) || Player.Bounds.IntersectsWith(Car2.Bounds))
            {
                over();


            }


            if(score>40 && score <500)
            {
                Award.Image = Properties.Resources.bronze;

            }


            if (score > 500 && score < 2000)
            {
                Award.Image = Properties.Resources.silver;

            }

            if (score > 500 && score < 2000)
            {
                Award.Image = Properties.Resources.silver;
                roadspeed = 20;
                trafficspeed = 22;

            }
            if (score >  2000)
            {
                Award.Image = Properties.Resources.gold;
                roadspeed = 27;
                trafficspeed = 25;
            }








        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form16 obj = new Form16();
            obj.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 obj = new Form6();
            obj.Show();
        }
    }
}
