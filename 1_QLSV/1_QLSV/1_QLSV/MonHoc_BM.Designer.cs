namespace _1_QLSV
{
    partial class MonHoc_BM
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
            this.gridMH = new System.Windows.Forms.DataGridView();
            this.btnshow = new System.Windows.Forms.Button();
            this.btncCN = new System.Windows.Forms.Button();
            this.btncls = new System.Windows.Forms.Button();
            this.qLSV_1DataSet1 = new _1_QLSV.QLSV_1DataSet1();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new _1_QLSV.QLSV_1DataSet1TableAdapters.MONHOCTableAdapter();
            this.mAMONHOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENMONHOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODVHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMH
            // 
            this.gridMH.AutoGenerateColumns = false;
            this.gridMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAMONHOCDataGridViewTextBoxColumn,
            this.tENMONHOCDataGridViewTextBoxColumn,
            this.sODVHTDataGridViewTextBoxColumn});
            this.gridMH.DataSource = this.mONHOCBindingSource;
            this.gridMH.Location = new System.Drawing.Point(23, 12);
            this.gridMH.Name = "gridMH";
            this.gridMH.Size = new System.Drawing.Size(567, 150);
            this.gridMH.TabIndex = 0;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(23, 207);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(112, 33);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "Xem";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btncCN
            // 
            this.btncCN.Location = new System.Drawing.Point(260, 207);
            this.btncCN.Name = "btncCN";
            this.btncCN.Size = new System.Drawing.Size(112, 33);
            this.btncCN.TabIndex = 2;
            this.btncCN.Text = "Cập Nhật";
            this.btncCN.UseVisualStyleBackColor = true;
            this.btncCN.Click += new System.EventHandler(this.btncCN_Click);
            // 
            // btncls
            // 
            this.btncls.Location = new System.Drawing.Point(478, 207);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(112, 33);
            this.btncls.TabIndex = 3;
            this.btncls.Text = "Thoát";
            this.btncls.UseVisualStyleBackColor = true;
            this.btncls.Click += new System.EventHandler(this.btncls_Click);
            // 
            // qLSV_1DataSet1
            // 
            this.qLSV_1DataSet1.DataSetName = "QLSV_1DataSet1";
            this.qLSV_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLSV_1DataSet1;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // mAMONHOCDataGridViewTextBoxColumn
            // 
            this.mAMONHOCDataGridViewTextBoxColumn.DataPropertyName = "MAMONHOC";
            this.mAMONHOCDataGridViewTextBoxColumn.HeaderText = "MAMONHOC";
            this.mAMONHOCDataGridViewTextBoxColumn.Name = "mAMONHOCDataGridViewTextBoxColumn";
            // 
            // tENMONHOCDataGridViewTextBoxColumn
            // 
            this.tENMONHOCDataGridViewTextBoxColumn.DataPropertyName = "TENMONHOC";
            this.tENMONHOCDataGridViewTextBoxColumn.HeaderText = "TENMONHOC";
            this.tENMONHOCDataGridViewTextBoxColumn.Name = "tENMONHOCDataGridViewTextBoxColumn";
            // 
            // sODVHTDataGridViewTextBoxColumn
            // 
            this.sODVHTDataGridViewTextBoxColumn.DataPropertyName = "SODVHT";
            this.sODVHTDataGridViewTextBoxColumn.HeaderText = "SODVHT";
            this.sODVHTDataGridViewTextBoxColumn.Name = "sODVHTDataGridViewTextBoxColumn";
            // 
            // MonHoc_BM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 261);
            this.Controls.Add(this.btncls);
            this.Controls.Add(this.btncCN);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.gridMH);
            this.Name = "MonHoc_BM";
            this.Text = "MonHoc_BM";
            this.Load += new System.EventHandler(this.MonHoc_BM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMH;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btncCN;
        private System.Windows.Forms.Button btncls;
        private QLSV_1DataSet1 qLSV_1DataSet1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLSV_1DataSet1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAMONHOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENMONHOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODVHTDataGridViewTextBoxColumn;
    }
}