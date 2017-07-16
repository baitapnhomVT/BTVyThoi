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
    public partial class Khoa_BM : Form
    {
        SqlConnection dbConn; 
        DataTable ds;
        SqlDataAdapter adap;
        public Khoa_BM()
        {
            InitializeComponent();
          
        }
       

        DataTable Khoa_DS()
        {
            dbConn = new SqlConnection(Khoa.strConn); 
            adap = new SqlDataAdapter(); 
            dbConn.Open();     
            adap.SelectCommand = new SqlCommand("SELECT * FROM KHOA", dbConn);    
            ds = new DataTable();    
            adap.Fill(ds);     
            dbConn.Close();
            return ds;
        }

        private void Khoa_BM_Load(object sender, EventArgs e)
        {
            grid_UpKh.DataSource = Khoa_DS();
            grid_UpKh.Columns[0].HeaderText = "Mã khoa";
            grid_UpKh.Columns[1].HeaderText = "Tên khoa";
           
           
        }

        private void btnCapN_Click(object sender, EventArgs e)
        {
            adap.InsertCommand = new SqlCommand("INSERT INTO KHOA VALUES(@MAKHOA,@TenKhoa)", dbConn);
            adap.InsertCommand.Parameters.Add("@MAKHOA", SqlDbType.NVarChar).SourceColumn = "MAKHOA";
            adap.InsertCommand.Parameters.Add("@TenKhoa", SqlDbType.NVarChar).SourceColumn = "Tenkhoa";
            adap.UpdateCommand = new SqlCommand("UPDATE KHOA SET Tenkhoa = @TenKhoa WHERE MAKHOA = @MAKHOA", dbConn);
            adap.UpdateCommand.Parameters.Add("@MAKHOA", SqlDbType.NVarChar).SourceColumn = "MAKHOA";
            adap.UpdateCommand.Parameters.Add("@TenKhoa", SqlDbType.NVarChar).SourceColumn = "Tenkhoa";
            adap.DeleteCommand = new SqlCommand("DELETE FROM KHOA WHERE MAKHOA=", dbConn);
            adap.DeleteCommand.Parameters.Add("@MAKHOA", SqlDbType.NVarChar).SourceColumn = "MAKHOA";
            adap.Update(ds);
            grid_UpKh.DataSource = ds;
            dbConn.Close(); 
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

      
      
   }
}   
       

