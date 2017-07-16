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
    public partial class DKyMonHoc : Form
    {
        public DKyMonHoc()
        {
            InitializeComponent();
            load_DSSinhVien();
        }
        DataTable DKMH_DS()
        {
            string cmd = "SELECT MASV, MAMH FROM KETQUA";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Khoa.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        void load_DSSinhVien()
        {

            gridDKMH.DataSource = DKMH_DS();

            gridDKMH.Columns[0].HeaderText = "Mã SV";
            gridDKMH.Columns[1].HeaderText = "Mã MH";
          
           
        }

       
        //Kiem tra maSV co trong bảng SINHVIEN hay không
        bool KiemTraMaSV(string maSV) 
        { 
  
         SqlConnection dbCon = new SqlConnection(QuanLy.strConn ); 
            dbCon.Open(); 
            SqlCommand cmd = new SqlCommand("SELECT * FROM  SINHVIEN WHERE MASV='" + maSV  + "'", dbCon);     
            SqlDataReader reader = cmd.ExecuteReader(); 
            if (reader.HasRows) 
               return true; 
            else 
               return false; 
        } 
        //Kiem tra Ma MOn Hoc có trong bảng môn học không

        bool KiemTraMaMH(string maMH)
        {
            SqlConnection dbCon = new SqlConnection(QuanLy.strConn);
            dbCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM  MONHOC WHERE MAMONHOC='" + maMH + "'", dbCon); SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return true;
            else
                return false;
        }
        void themDKMH(string maSV, string maMH)
        {
            string cmd = "INSERT INTO KETQUA(MASV,MAMH) VALUES(N'" + maSV + "',N'" + maMH + "')";
            SqlConnection dbConn = new SqlConnection(QuanLy.strConn);
            dbConn.Open();
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();
            load_DSSinhVien();
        }
        void huyDKMH(string maSV, string maMH)
        {
            string cmd = "DELETE FROM KETQUA WHERE MASV='" + maSV + "'  AND MAMH='"+ maMH +"' ";
            SqlConnection connDB = new SqlConnection(Khoa.strConn);
            connDB.Open();         
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
            load_DSSinhVien();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
             int dem = 0;//Biến dùng để kiểm tra MãSV và MãMH có trong CSDL hay không? 
                string loi = "";//Nội dung thông báo lỗi 
                if (KiemTraMaSV(txtMaSV.Text) == false) 
 
                     loi += "- Mã sinh viên";  
                else 
                     dem++;//Mã sinh viên có trong CSDL 
                if (KiemTraMaMH(txtMaMH.Text) == false) 
                     loi += "- Mã môn học"; 
                else 
                     dem++;//Mã môn học có trong CSDL 
                if (dem == 2) 
                     themDKMH(txtMaSV.Text, txtMaMH.Text);   
                else 
                MessageBox.Show(loi + " không tồn tại!", "Thông báo");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
           
                huyDKMH(txtMaSV.Text, txtMaMH.Text);
          
        }
      
    }
}
