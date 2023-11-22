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
    public partial class Form4 : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=");

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("재고가 확인되었습니다");
            this.Hide();

        }
    }
}
