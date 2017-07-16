namespace _1_QLSV
{
    partial class Timkiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.comboKhoa = new System.Windows.Forms.ComboBox();
            this.gridFSV = new System.Windows.Forms.DataGridView();
            this.lblSoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Tên Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh Sách Sinh Viên Theo Khoa";
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(121, 17);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(100, 20);
            this.txtTimTen.TabIndex = 2;
            this.txtTimTen.TextChanged += new System.EventHandler(this.txtTimTen_TextChanged);
            // 
            // comboKhoa
            // 
            this.comboKhoa.FormattingEnabled = true;
            this.comboKhoa.Location = new System.Drawing.Point(534, 17);
            this.comboKhoa.Name = "comboKhoa";
            this.comboKhoa.Size = new System.Drawing.Size(121, 21);
            this.comboKhoa.TabIndex = 3;
            this.comboKhoa.SelectedIndexChanged += new System.EventHandler(this.comboKhoa_SelectedIndexChanged);
           
            // 
            // gridFSV
            // 
            this.gridFSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFSV.Location = new System.Drawing.Point(47, 92);
            this.gridFSV.Name = "gridFSV";
            this.gridFSV.Size = new System.Drawing.Size(624, 150);
            this.gridFSV.TabIndex = 4;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(47, 343);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(68, 13);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số Sinh Viên";
            // 
            // Timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 368);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.gridFSV);
            this.Controls.Add(this.comboKhoa);
            this.Controls.Add(this.txtTimTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Timkiem";
            this.Text = "Timkiem";
            ((System.ComponentModel.ISupportInitialize)(this.gridFSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.ComboBox comboKhoa;
        private System.Windows.Forms.DataGridView gridFSV;
        private System.Windows.Forms.Label lblSoLuong;
    }
}