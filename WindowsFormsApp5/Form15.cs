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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        DBAccess objdbAccess = new DBAccess();

        string username;
        string Email;
        string Password;
        string id;
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string Email = textBox3.Text;
            string Password = textBox2.Text;
            string id1;
           

            if (username.Equals(""))
            {
                MessageBox.Show("Enter User Name...!!!");
            }
            else if (Email.Equals(""))
            {
                MessageBox.Show("Enter User Email...!!!");
            }
            else if (Password.Equals(""))
            {
                MessageBox.Show("Enter User Password...!!!");
            }
           
            else
            {
                SqlCommand sqlcommand = new SqlCommand("insert into LOGIN(USERNAME, Email, Password) values(@Name, @Email, @Password)");
                sqlcommand.Parameters.AddWithValue("@Name", username);
                sqlcommand.Parameters.AddWithValue("@Email", Email);
                sqlcommand.Parameters.AddWithValue("@Password", Password);
               
                int row = objdbAccess.executeQuery(sqlcommand);
                if (row == 1)
                {
                    MessageBox.Show("Sign Up Successful");
                  

                    DataTable dtReg = new DataTable();
                    string query = "Select * from LOGIN where USERNAME = '" + username + "' AND Email = '" + Email + "' AND Password='"+Password+ "'";

             
                    objdbAccess.readDatathroughAdapter(query, dtReg);

                    if (dtReg.Rows.Count == 1)
                    {
                       
                        id = dtReg.Rows[0]["U_ID"].ToString();
    
                    }

                    SqlCommand sqli = new SqlCommand("insert into Score(U_ID, T_Rex,Ballon_pop,car_racing,shooter,FloopyBird) values(@id,@T,@B, @c, @s,@f)");
                    sqli.Parameters.AddWithValue("@id", id);

                    sqli.Parameters.AddWithValue("@T",0);

                    sqli.Parameters.AddWithValue("@B",0);

                    sqli.Parameters.AddWithValue("@C", 0);

                    sqli.Parameters.AddWithValue("@s", 0);
                    sqli.Parameters.AddWithValue("@f", 0);



                    int r = objdbAccess.executeQuery(sqli);


                    if(r==1)
                    {
                        MessageBox.Show("your New high score is updated");
                    }














                    this.Hide();
                    Form14 l1 = new Form14();
                    l1.Show();





                }
                else
                {
                    MessageBox.Show("Try Again...");
                }
            }

        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 obj1 = new Form14();
           
            obj1.Show();
        }
    }
    }

