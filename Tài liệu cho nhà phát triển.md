Tài Liệu Cho Nhà Phát Triển
Hiện tại , phần mềm vẫn chưa được hoàn thiện về bản Môn Học. Các module Danh mục đề tài, Quản lý đề tài,Thống kê vẫn chưa hoàn thiện.
+ Bạn đều cần phải tạo trước các bảng mình muốn thao tác trong database của SQL Serve
B1. Tạo một Windows Foms để tạo bản ( Tạo bản Môn Học để phát triển )
 <p align="center">
  <img width="550" height="350" src="https://github.com/baitapnhomVT/BTVyThoi/blob/master/form1.png">
</p>

B2. Kéo các toolbox sang để  tạo dao diên cho fom
  <p align="center">
  <img width="550" height="350" src="https://github.com/baitapnhomVT/BTVyThoi/blob/master/formdg.png">
</p>

B3. Sử dụng thuật code cho fom Viết code cho form. Lưu ý: xử lý trực tiếp các thao tác tính toán cũng như thao tác với SQL Server trên form.
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
    public partial class MonHoc_BM : Form
    {
        SqlCommandBuilder scb;        
        DataTable dt;
        SqlDataAdapter da;
        public MonHoc_BM()
        {
            InitializeComponent();
        }

        private void btncls_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MonHoc_BM_Load(object sender, EventArgs e)
        {
            
          //this.mONHOCTableAdapter.Fill(this.qLSV_1DataSet1.MONHOC);

        }

        private void btncCN_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(da);
            da.Update(dt);
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            SqlConnection connDB = new SqlConnection(Khoa.strConn);
            da = new SqlDataAdapter(@"SELECT * FROM MONHOC", connDB);
            dt = new DataTable();
            da.Fill(dt);
            gridMH.DataSource = dt;
        }
    }
}

