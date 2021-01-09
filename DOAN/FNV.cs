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
    public partial class FNV : Form
    {
        public FNV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FNV_Load(object sender, EventArgs e)
        {
            try
            {
                NV context = new NV();
                List<HOADON> listHD = context.HOADONs.ToList();
                List<CTHD> listCT = context.CTHDs.ToList();
                List<NHANVIEN> listNV = context.NHANVIENs.ToList();
                List<SANPHAM> listSP = context.SANPHAMs.ToList();
                List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
                BindGrid(listNV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<NHANVIEN> listNV)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listNV)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MANV;
                dataGridView1.Rows[index].Cells[1].Value = item.TENNV;
                dataGridView1.Rows[index].Cells[2].Value = item.NGAYSINH;
                dataGridView1.Rows[index].Cells[3].Value = item.DIACHI;
                dataGridView1.Rows[index].Cells[4].Value = item.SDT;
                dataGridView1.Rows[index].Cells[5].Value = item.TENDANGNHAP;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NV context = new NV();
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin Nhân viên!");
                NHANVIEN n = new NHANVIEN()
                {
                    MANV = textBox1.Text,
                    TENNV = textBox2.Text,
                    NGAYSINH = DateTime.Parse( textBox3.Text),
                    DIACHI = textBox4.Text,
                    SDT = textBox5.Text,
                    TENDANGNHAP=textBox6.Text
                };
                context.NHANVIENs.Add(n);
                context.SaveChanges();
                List<HOADON> listHD = context.HOADONs.ToList();
                List<CTHD> listCT = context.CTHDs.ToList();
                List<NHANVIEN> listNV = context.NHANVIENs.ToList();
                List<SANPHAM> listSP = context.SANPHAMs.ToList();
                List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
                BindGrid(listNV);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
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
                NHANVIEN dbDelete = context.NHANVIENs.FirstOrDefault(p => p.MANV == textBox1.Text);
                if (dbDelete != null)
                {
                    DialogResult dr = MessageBox.Show("Xác nhận xóa?", "YES/NO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        context.NHANVIENs.Remove(dbDelete);
                        context.SaveChanges();
                        List<HOADON> listHD = context.HOADONs.ToList();
                        List<CTHD> listCT = context.CTHDs.ToList();
                        List<NHANVIEN> listNV = context.NHANVIENs.ToList();
                        List<SANPHAM> listSP = context.SANPHAMs.ToList();
                        List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
                        BindGrid(listNV);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        MessageBox.Show("Xoá dữ liệu thành công!");
                    }
                }
                else
                {
                    throw new Exception("Không tìm thấy MNV cần xóa!");
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
