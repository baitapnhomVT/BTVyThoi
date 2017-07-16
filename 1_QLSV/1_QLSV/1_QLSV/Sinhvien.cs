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
    public partial class Sinhvien : Form
    {
        public Sinhvien()
        {
            InitializeComponent();
            load_DSSinhVien();
           
        }
        void load_DSSinhVien()
        {

            gridSVList.DataSource = SinhVien_DS();

            gridSVList.Columns[0].HeaderText = "Mã SV";
            gridSVList.Columns[1].HeaderText = "Họ SV";
            gridSVList.Columns[2].HeaderText = "Tên SV";
            gridSVList.Columns[3].HeaderText = "Giới tính";
            gridSVList.Columns[4].HeaderText = "Ngày sinh";
            gridSVList.Columns[5].HeaderText = "Nơi sinh";
            gridSVList.Columns[6].HeaderText = "Mã khoa";

            cbox_Khoa.DataSource = Khoa_DS();
            cbox_Khoa.DisplayMember = "TenKhoa";
            cbox_Khoa.ValueMember = "MaKhoa"; 
        }

        DataTable Khoa_DS()
        {
            string cmd = "SELECT * FROM KHOA";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Khoa.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        DataTable SinhVien_DS()
        {
            string cmd = "SELECT * FROM SINHVIEN";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Khoa.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        void themSinhVien(string maSV, string hoSV, string tenSV, string   gioiTinh, string ngaySinh, string noiSinh, string maKhoa) 
        { 
            string cmd = "INSERT INTO SINHVIEN VALUES('" + maSV + "',N'" + hoSV  + "',N'" + tenSV + "', N'"+gioiTinh+"' ,'" + ngaySinh  + "',N'" + noiSinh  + "',N'" + maKhoa  + "')"; 
            SqlConnection dbConn = new SqlConnection(Khoa.strConn ); 
            dbConn.Open(); 
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);  
            dbCmd.ExecuteNonQuery(); 
            dbConn.Close();
            load_DSSinhVien();
        }
        void suaSinhVien(string maSV, string hoSV, string tenSV, string gioiTinh, string ngaySinh, string noiSinh, string maKhoa)
        {
            string cmd = "UPDATE SINHVIEN SET HOSV=N'" + hoSV + "',TENSV=N'" + tenSV + "',GIOITINH=N'" + gioiTinh + "' ,NGAYSINH='" + ngaySinh + "',NOISINH=N'" + noiSinh + "',MAKHOA=N'" + maKhoa + "' WHERE  MASV='" + maSV + "'";
            SqlConnection dbConn = new SqlConnection(Khoa.strConn);
            dbConn.Open();
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();
            load_DSSinhVien();
        }
        void xoaSinhVien(string maSV)
        {
            SqlConnection connDB = new SqlConnection(Khoa.strConn);
            connDB.Open();
            string cmd = "DELETE FROM SINHVIEN WHERE MASV='" + maSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
            
            load_DSSinhVien();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string gt;
            if (rad_Nam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            themSinhVien(txtMaSV.Text, txtHoSV.Text, txtTenSV.Text, gt.ToString(), date_NgaySinh.Text, txtNoiSinh.Text, cbox_Khoa.SelectedValue.ToString());
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string gt ;
            if (rad_Nam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            suaSinhVien(txtMaSV.Text, txtHoSV.Text, txtTenSV.Text, gt.ToString(), date_NgaySinh.Text, txtNoiSinh.Text, cbox_Khoa.SelectedValue.ToString());
            
        }

       

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            xoaSinhVien(txtMaSV.Text);
            
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
