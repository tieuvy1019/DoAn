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
    public partial class BCDT : Form
    {
        public BCDT()
        {
            InitializeComponent();
        }

        private void BCDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDataSet.CTHD' table. You can move, or remove it, as needed.
            this.CTHDTableAdapter.Fill(this.demoDataSet.CTHD, textBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CTHDTableAdapter.Fill(this.demoDataSet.CTHD, textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
