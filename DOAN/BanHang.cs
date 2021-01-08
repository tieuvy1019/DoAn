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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
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

        private void BanHang_Load(object sender, EventArgs e)
        {
            try
            {
                NV context = new NV();
                List<HOADON> listHD = context.HOADONs.ToList();
                List<CTHD> listCT = context.CTHDs.ToList();
                List<NHANVIEN> listNV = context.NHANVIENs.ToList();
                List<SANPHAM> listSP = context.SANPHAMs.ToList();
                List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
                BindGrid(listCT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<CTHD> listCT)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listCT)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MACTHD;
                dataGridView1.Rows[index].Cells[1].Value = item.SOHD;
                dataGridView1.Rows[index].Cells[2].Value = item.MANV;
                dataGridView1.Rows[index].Cells[3].Value = item.MASP;
                dataGridView1.Rows[index].Cells[4].Value = item.DONGIA;
            }
        }
    }
}
