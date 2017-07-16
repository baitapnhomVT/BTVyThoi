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

namespace _1_QLSV
{
   
    public partial class Khoa : Form
    {
        public static string strConn = @"Data Source=GHOSTIM-ETEQMA2;Initial Catalog=QLSV_1;Integrated Security=True";
       
        void themKhoa(string maKhoa, string tenKhoa) 
        { 
            SqlConnection connDB = new SqlConnection(Khoa.strConn); 
            connDB.Open(); 
            string cmd = "INSERT INTO KHOA VALUES('" + maKhoa + "',N'" + tenKhoa + "')"; 
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB); 
            sqlCmd.ExecuteNonQuery(); 
            connDB.Close(); 
        }
        void suaKhoa(string maKhoa, string tenKhoa)
        {
            SqlConnection connDB = new SqlConnection(Khoa.strConn);
            connDB.Open(); string cmd = "UPDATE KHOA SET TENKHOA='" + tenKhoa + "' WHERE MAKHOA='" + maKhoa + "'"; 
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaKhoa(string maKhoa)
        {
            SqlConnection connDB = new SqlConnection(Khoa.strConn);
            connDB.Open();
            string cmd = "DELETE FROM KHOA WHERE MAKHOA='" + maKhoa + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        DataTable DSKhoa()
        {
            string cmd = "SELECT * FROM KHOA";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Khoa.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        void load_DSKhoa()
        {
            grid_KhoaList.DataSource = DSKhoa();
            grid_KhoaList.Columns[0].HeaderText = "Mã khoa";
            grid_KhoaList.Columns[1].HeaderText = "Tên khoa";
        }
        public Khoa()
        {
            InitializeComponent();
            load_DSKhoa();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themKhoa(txtMK.Text, txtTK.Text);
            load_DSKhoa();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            suaKhoa(txtMK.Text, txtTK.Text);
            load_DSKhoa();
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            xoaKhoa(txtMK.Text);
            load_DSKhoa();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
