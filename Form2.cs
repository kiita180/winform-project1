using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    
    public partial class Form2 : Form
    {
        Form1 f1;
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=");
        
        public Button btnLogin;
        
        public Form2(Form1 form)
        {
            InitializeComponent();
            f1 = form;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void button1_Click(object sender, EventArgs e)
        {
           
            Form1 form1 = new Form1();
            if (text_id.Text == "" && text_paw.Text == "")
            {
                MessageBox.Show("아이디,비밀번호를 입력하세요");
            }
            else if (text_id.Text == "root" && text_paw.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세여");
            }
            else if (text_id.Text == "" && text_paw.Text == "ehdrb123")
            {
                MessageBox.Show("아이디를 입력하세여");
            }
            else
            {
                MessageBox.Show(text_id.Text+"님 환영합니다");
                
                this.Hide();
                f1.label1.Text = text_id.Text + "님";
                f1.Visible = true;
                f1.btn_login.Text = "로그아웃";
            }

        }
    }
}
