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
    public partial class Chon : Form
    {
        public Chon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BanHang b= new BanHang();
            this.Hide();
            b.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }
    }
}
