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
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            //MySqlConnection conn = new MySqlConnection(connection);
            //conn.Open();
            ///conn.Close();



        }
        string connection = "server=127.0.0.1; database=.....;user=keremdemirtrk; password=.....;";


        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "keremdemirtrk" && textBox2.Text == "kerem199898")
            {

            }
            admin_panel newform = new admin_panel();
            newform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
