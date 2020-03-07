using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
namespace WindowsFormsApplication2
{
    public partial class admin_panel : Form
    {

        string connection = "server=127.0.0.1; database=.....;user=keremdemirtrk; password=......;";
        public admin_panel()
        {
            InitializeComponent();
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            string komut = "select * from member";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridüyeler.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kisikontrol = true;
            tabControl1.SelectedIndex = 0;
            //yeni pencerte aç
            //açılan penceree üyeleri listele
            //üyeler seçilsin
            //butona tıjklansın üye seçimi kapansın
            //üyeler alıcıya gelsin

        }
        bool kisikontrol = false;

        private void button1_Click(object sender, EventArgs e)
        {
            int mailadreslerisayısı = listBox1.Items.Count;
            for (int i = 0; i < mailadreslerisayısı; i++)
            {
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("....");
                ePosta.To.Add(listBox1.Items[i].ToString());
                ePosta.Subject = "DENEME";
                ePosta.Body = textBox1.Text;
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("....", "....");
                smtp.Host = "....";
                smtp.Port = .. as.. as.;
                // smtp.EnableSsl = true;
                smtp.Send(ePosta);
            }

        }

        private void datagridüyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kisikontrol == true)
            {
                string deneme = datagridüyeler.CurrentRow.Cells["Mail"].Value.ToString();
                //textBox/*2.Text = deneme;*/
                listBox1.Items.Add(deneme);
                //tabControl1.SelectedIndex = 1;

            }
        }

        private void datagridüyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();

                }
                conn.Open();
                string komut = "insert into member values('" + textBox5.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "')";
                MySqlCommand cmd = new MySqlCommand(komut, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("TEBRİKLER,KD FARKI İLE KAYIT OLDU.");

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }





        }
    }
}
