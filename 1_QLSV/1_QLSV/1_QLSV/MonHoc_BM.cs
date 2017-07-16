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
