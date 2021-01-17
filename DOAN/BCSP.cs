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
    public partial class BCSP : Form
    {
        public BCSP()
        {
            InitializeComponent();
        }

        private void BCSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.SANPHAMTableAdapter.Fill(this.demoDataSet1.SANPHAM, textBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SANPHAMTableAdapter.Fill(this.demoDataSet1.SANPHAM, textBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
