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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        public static string id, name, email, password, country;
               

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

            textBox1.Select();

            textBox1.Text = " ";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form15 sign = new Form15();
            sign.Show();
        }

        DBAccess objdbAccess = new DBAccess();
        DataTable dtReg = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            password = textBox2.Text;

            if (name.Equals(""))
            {
                MessageBox.Show("Must Enter Email...!!!");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Must Enter Password...!!!");
            }
            else
            {
                string query = "Select * from LOGIN where USERNAME = '" + name + "' AND Password = '" + password + "'";
                objdbAccess.readDatathroughAdapter(query, dtReg);

                if (dtReg.Rows.Count == 1)
                {
                    //MessageBox.Show(dtReg.Rows[0].ToString());
                    name = dtReg.Rows[0]["USERNAME"].ToString();
                    password  = dtReg.Rows[0]["PASSWORD"].ToString();
                    email = dtReg.Rows[0]["Email"].ToString();
                    id  =dtReg.Rows[0]["U_ID"].ToString();
                   

                    MessageBox.Show("Congrats, Successful Login..!!!");
                    this.Hide();
                    Form16 home = new Form16();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Unsuccessful Login Something is missing in your creditenals, Try Again..!!!");
                }
            }

        }

    }
}
