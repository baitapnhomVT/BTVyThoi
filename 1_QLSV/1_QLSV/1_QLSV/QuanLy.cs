using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_QLSV
{
    public partial class QuanLy : Form
    {
        public static string strConn = @"Data Source=GHOSTIM-ETEQMA2;Initial Catalog=QLSV_1;Integrated Security=True";
        public QuanLy()
        {
            InitializeComponent();
        }

        private void tStrMN_khoa_Click(object sender, EventArgs e)
        {
            Khoa frmkhoa = new Khoa();
            frmkhoa.Show();
        }

        private void tStrMN_SV_Click(object sender, EventArgs e)
        {
            Sinhvien frmSV = new Sinhvien();
            frmSV.Show();
        }

        private void tStrMN_DKMH_Click(object sender, EventArgs e)
        {
            DKyMonHoc FRMdk = new DKyMonHoc();
            FRMdk.Show();
        }

        private void tStrMN_out_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khoa_BM frmKBM = new Khoa_BM();
            frmKBM.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonHoc_BM frmMHBM = new MonHoc_BM();
            frmMHBM.Show();
        }

        private void tìmKiếmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timkiem frmTK = new Timkiem();
            frmTK.Show();
        }
    }
}
