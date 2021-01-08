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


namespace DOAN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=21AK22-COM\MSSQLSERVER01;Initial Catalog=demo;Integrated Security=True");
            
            
                conn.Open();
                string tk = textBox1.Text;
                string mk = textBox2.Text;
                string sql = "select *from TAIKHOAN where TENDANGNHAP= '" + tk + "' and MATKHAU= '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true )
                {
                    Chon v = new Chon();
                    this.Hide();
                    v.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại ", "Thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
