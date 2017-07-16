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
    public partial class Timkiem : Form
    {
        SqlConnection dbConn;        
        DataTable ds;         
        SqlDataAdapter adap;         
        BindingSource bindSinhVien;
        int dem = 0;
        public Timkiem()
        {
            InitializeComponent();
            loadsinhvien();
        }
        DataTable SinhVien_DS() 
        {
            dbConn = new SqlConnection(Khoa.strConn); 
            adap = new SqlDataAdapter(); dbConn.Open(); 
            adap.SelectCommand = new SqlCommand("SELECT MASV as [Mã SV], HOSV as [Họ sinh viên], TENSV as [Tên SV], GIOITINH AS [Giới tính],NGAYSINH as [Ngày sinh],NOISINH as [Nơi sinh],MAKHOA as [Khoa] FROM SINHVIEN", dbConn); 
            ds = new DataTable(); 
            adap.Fill(ds); 
            dbConn.Close(); return ds;
        }
       // - Hàm trả về danh sách sinh viên dựa vào mã khoa: 
        DataTable SinhVienDS_MaKhoa(string maKhoa)  
        {    
            dbConn = new SqlConnection(QuanLy.strConn);    
            adap = new SqlDataAdapter();   
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT MASV as [Mã SV], HOSV as [Họ sinh viên], TENSV as [Tên SV], GIOITINH AS [Giới tính],NGAYSINH as [Ngày sinh],NOISINH as [Nơi sinh],MAKHOA as [Khoa] FROM SINHVIEN WHERE MAKHOA='" + maKhoa + "'", dbConn);  
            ds = new DataTable();   
            adap.Fill(ds);   
            dbConn.Close();   
            return ds; }
        //- Hàm trả về danh sách khoa: 
        DataTable Khoa_DS() 
        {    
            string cmd = "SELECT * FROM KHOA";    
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Khoa.strConn);    
            DataTable ds = new DataTable();    
            adap.Fill(ds);    
            return ds;  
        }
        //- Code xử lý sự kiện Form_Load: 
        private void frmSV_TimKiem_Load(object sender, EventArgs e)
        {
            
        }
        void loadsinhvien()
        {
            bindSinhVien = new BindingSource();
            bindSinhVien.DataSource = SinhVien_DS();
            gridFSV.DataSource = bindSinhVien;
            gridFSV.Columns[0].Width = 100;
            gridFSV.Columns[1].Width = 180;
            gridFSV.Columns[2].Width = 100;
            gridFSV.Columns[3].Width = 100;
            gridFSV.Columns[4].Width = 120;
            gridFSV.Columns[5].Width = 100;
            gridFSV.Columns[6].Width = 100;
            dem = gridFSV.RowCount - 1;
            lblSoLuong.Text = "Số sinh viên: " + dem.ToString();
            comboKhoa.DataSource = Khoa_DS();
            comboKhoa.DisplayMember = "TENKHOA";
            comboKhoa.ValueMember = "MAKHOA";
            comboKhoa.SelectedIndex = -1;
            comboKhoa.Text = "[Chọn khoa ...]";
        }

        private void comboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboKhoa.SelectedIndex == -1) || (comboKhoa.Text == ""))
                gridFSV.DataSource = SinhVien_DS();
            else
                gridFSV.DataSource = SinhVienDS_MaKhoa(comboKhoa.SelectedValue.ToString());
            dem = gridFSV.RowCount - 1;
            lblSoLuong.Text = "Số sinh viên: " + dem.ToString();
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            string str = "[Tên SV] LIKE '" + txtTimTen.Text + "%'";
            bindSinhVien.Filter = str;
            gridFSV.DataSource = bindSinhVien;
            dem = gridFSV.RowCount - 1;
            lblSoLuong.Text = "Số sinh viên: " + dem.ToString(); 
        }

   
       
      
            
    }

}
