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

namespace project
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectQuery = string.Format("insert into project.입고('종류','수량','매입처','날짜')\r\nvalues ({0},{1},{2},{3}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            MessageBox.Show("입고 신청 되었습니다"); 
        }
    }
    
}
