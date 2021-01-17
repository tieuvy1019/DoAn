using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOAN
{
    public partial class FDMK : Form
    {
        public FDMK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-4NRRL3NS\MSSQLSERVER01;Initial Catalog=demo;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select count (*)  from TAIKHOAN where TENDANGNHAP = N'" + textBox1.Text + "' and MATKHAU = N'" + textBox2.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (textBox3.Text == textBox4.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("update TAIKHOAN set MATKHAU = N '" + textBox3.Text + "' where TENDANGNHAP = N'" + textBox1.Text + "' and MATKHAU = N'" + textBox2.Text + "'", cn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.SetError(textBox3, "Bạn chưa nhập mật khẩu!!!");
                    errorProvider1.SetError(textBox4, "Bạn nhập mật khẩu chưa chính xác!!!");
                }

            }
            else
            {
                errorProvider1.SetError(textBox1, "Tên đăng nhập không chính xác!!!");
                errorProvider1.SetError(textBox2, "Bạn nhập mật khẩu cũ chưa chính xác!!!");
            }
        }
    }
}
