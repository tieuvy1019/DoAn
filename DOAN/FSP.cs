using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class FSP : Form
    {
        public FSP()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FSP_Load(object sender, EventArgs e)
        {
            try
            {
                NV context = new NV();
                List<HOADON> listHD = context.HOADONs.ToList();
                List<CTHD> listCT = context.CTHDs.ToList();
                List<NHANVIEN> listNV = context.NHANVIENs.ToList();
                List<SANPHAM> listSP = context.SANPHAMs.ToList();
                List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
                BindGrid(listSP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<SANPHAM> listSP)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listSP)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MASP;
                dataGridView1.Rows[index].Cells[1].Value = item.TENSP;
                dataGridView1.Rows[index].Cells[2].Value = item.DONVITINH;
                dataGridView1.Rows[index].Cells[3].Value = item.LOAI;
                dataGridView1.Rows[index].Cells[4].Value = item.XUATXU;
                dataGridView1.Rows[index].Cells[5].Value = item.NGAYSANXUAT;
                dataGridView1.Rows[index].Cells[6].Value = item.HANSUDUNG;
                dataGridView1.Rows[index].Cells[7].Value = item.DONGIA;
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NV context = new NV();
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin Sản phẩm!");
                SANPHAM s = new SANPHAM()
                {
                    MASP = textBox1.Text,
                    TENSP = textBox2.Text,
                    DONVITINH = textBox3.Text,
                    LOAI = textBox4.Text,
                    XUATXU = textBox5.Text,
                    NGAYSANXUAT = DateTime.Parse(textBox6.Text),
                    HANSUDUNG = DateTime.Parse(textBox7.Text),
                    DONGIA = int.Parse(textBox8.Text)
                };
                context.SANPHAMs.Add(s);
                //context.SaveChanges();
                List<HOADON> listHD = context.HOADONs.ToList();
                List<CTHD> listCT = context.CTHDs.ToList();
                List<NHANVIEN> listNV = context.NHANVIENs.ToList();
                List<SANPHAM> listSP = context.SANPHAMs.ToList();
                List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
                BindGrid(listSP);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NV context = new NV();
            try
            {
                SANPHAM dbDelete = context.SANPHAMs.FirstOrDefault(p => p.MASP == textBox1.Text);
                if (dbDelete != null)
                {
                    DialogResult dr = MessageBox.Show("Xác nhận xóa?", "YES/NO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        context.SANPHAMs.Remove(dbDelete);
                        //context.SaveChanges();
                        List<HOADON> listHD = context.HOADONs.ToList();
                        List<CTHD> listCT = context.CTHDs.ToList();
                        List<NHANVIEN> listNV = context.NHANVIENs.ToList();
                        List<SANPHAM> listSP = context.SANPHAMs.ToList();
                        List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
                        BindGrid(listSP);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        MessageBox.Show("Xoá dữ liệu thành công!");
                    }
                }
                else
                {
                    throw new Exception("Không tìm thấy MSP cần xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
