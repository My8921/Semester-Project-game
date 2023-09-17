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
    public partial class Form16 : Form
    {



        SqlConnection con = new SqlConnection(" Data Source = DESKTOP-2JLH2DT\\SQLEXPRESS; Initial Catalog = Gaming_board; Integrated Security = True");
       
        SqlCommand cmd;
        SqlDataAdapter adp;


        DataTable dt;
        DBAccess objdbAccess = new DBAccess();

        public Form16()
        {
            InitializeComponent();
            show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void show()
        {
            
            adp = new SqlDataAdapter("select T_Rex,FloopyBird,car_racing,shooter,Ballon_pop from Score where U_ID LIKE @SE;",con);

            adp.SelectCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@SE",
                Value = "%" + Form14.id + "%",
                SqlDbType = SqlDbType.VarChar,
                Size = 2000  // Assuming a 2000 char size of the field annotation (-1 for MAX)
            });


            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;


           


        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel9.Visible = false;

            label2.Text = Form14.name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel5.Visible = true;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel9.Visible = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();


            Form14 obj = new Form14();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {


            this.Hide();
            Form7 obj = new Form7();
            obj.Show();


        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            Form6 obj1 = new Form6();
            obj1.Show();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form6 obj1 = new Form6();
            obj1.Show();


        }

        private void label5_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form6 obj1 = new Form6();
            obj1.Show();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form5 obj = new Form5();
            obj.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 obj = new Form5();
            obj.Show();

        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {

            this.Hide();
            Form5 obj = new Form5();
            obj.Show();

        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form7 obj = new Form7();
            obj.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 obj = new Form8();
            obj.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 obj = new Form8();
            obj.Show();
        }

      

        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form9 obj = new Form9();
            obj.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form8 obj = new Form8();
            obj.Show();
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form9 obj = new Form9();
            obj.Show();

        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form9 obj = new Form9();
            obj.Show();


            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7 obj = new Form7();
            obj.Show();
        }
    }
}
