using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=");
            btn_logout.Visible = false;
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2(this);
            form2.Show();
           Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_store_Click(object sender, EventArgs e)
        {
           Form3 form3 = new Form3();
           form3.Show();
        }

        private void btn_release_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            btn_login.Visible = true;
            MessageBox.Show("로그아웃 되었습니다");
            btn_logout.Visible = false;
        }

    }
}
