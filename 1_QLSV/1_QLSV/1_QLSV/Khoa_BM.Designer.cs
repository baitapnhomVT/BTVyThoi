namespace _1_QLSV
{
    partial class Khoa_BM
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
            this.components = new System.ComponentModel.Container();
            this.grid_UpKh = new System.Windows.Forms.DataGridView();
            this.mAKHOADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHOADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSV_1DataSet = new _1_QLSV.QLSV_1DataSet();
            this.btnCapN = new System.Windows.Forms.Button();
            this.btncls = new System.Windows.Forms.Button();
            this.kHOATableAdapter = new _1_QLSV.QLSV_1DataSetTableAdapters.KHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid_UpKh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_UpKh
            // 
            this.grid_UpKh.AutoGenerateColumns = false;
            this.grid_UpKh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_UpKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_UpKh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHOADataGridViewTextBoxColumn,
            this.tENKHOADataGridViewTextBoxColumn});
            this.grid_UpKh.DataSource = this.kHOABindingSource;
            this.grid_UpKh.Location = new System.Drawing.Point(1, 0);
            this.grid_UpKh.Name = "grid_UpKh";
            this.grid_UpKh.Size = new System.Drawing.Size(284, 150);
            this.grid_UpKh.TabIndex = 0;
            // 
            // mAKHOADataGridViewTextBoxColumn
            // 
            this.mAKHOADataGridViewTextBoxColumn.DataPropertyName = "MAKHOA";
            this.mAKHOADataGridViewTextBoxColumn.HeaderText = "MAKHOA";
            this.mAKHOADataGridViewTextBoxColumn.Name = "mAKHOADataGridViewTextBoxColumn";
            // 
            // tENKHOADataGridViewTextBoxColumn
            // 
            this.tENKHOADataGridViewTextBoxColumn.DataPropertyName = "TENKHOA";
            this.tENKHOADataGridViewTextBoxColumn.HeaderText = "TENKHOA";
            this.tENKHOADataGridViewTextBoxColumn.Name = "tENKHOADataGridViewTextBoxColumn";
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qLSV_1DataSet;
            // 
            // qLSV_1DataSet
            // 
            this.qLSV_1DataSet.DataSetName = "QLSV_1DataSet";
            this.qLSV_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCapN
            // 
            this.btnCapN.Location = new System.Drawing.Point(57, 172);
            this.btnCapN.Name = "btnCapN";
            this.btnCapN.Size = new System.Drawing.Size(75, 35);
            this.btnCapN.TabIndex = 1;
            this.btnCapN.Text = "Cập Nhật";
            this.btnCapN.UseVisualStyleBackColor = true;
            this.btnCapN.Click += new System.EventHandler(this.btnCapN_Click);
            // 
            // btncls
            // 
            this.btncls.Location = new System.Drawing.Point(149, 172);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(75, 35);
            this.btncls.TabIndex = 2;
            this.btncls.Text = "Thoát";
            this.btncls.UseVisualStyleBackColor = true;
            this.btncls.Click += new System.EventHandler(this.btncls_Click);
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // Khoa_BM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.btncls);
            this.Controls.Add(this.btnCapN);
            this.Controls.Add(this.grid_UpKh);
            this.Name = "Khoa_BM";
            this.Text = "Khoa_BM";
            this.Load += new System.EventHandler(this.Khoa_BM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_UpKh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_UpKh;
        private System.Windows.Forms.Button btnCapN;
        private System.Windows.Forms.Button btncls;
        private QLSV_1DataSet qLSV_1DataSet;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private QLSV_1DataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHOADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHOADataGridViewTextBoxColumn;
    }
}