namespace EntityFrameworkPractice
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.importDataBtn = new System.Windows.Forms.Button();
            this.insertDataBtn = new System.Windows.Forms.Button();
            this.updateDataBtn = new System.Windows.Forms.Button();
            this.deleteDataBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 458);
            this.dataGridView1.TabIndex = 0;
            // 
            // importDataBtn
            // 
            this.importDataBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.importDataBtn.Location = new System.Drawing.Point(89, 488);
            this.importDataBtn.Margin = new System.Windows.Forms.Padding(5);
            this.importDataBtn.Name = "importDataBtn";
            this.importDataBtn.Size = new System.Drawing.Size(182, 78);
            this.importDataBtn.TabIndex = 1;
            this.importDataBtn.Text = "匯入資料";
            this.importDataBtn.UseVisualStyleBackColor = true;
            this.importDataBtn.Click += new System.EventHandler(this.importDataBtn_Click);
            // 
            // insertDataBtn
            // 
            this.insertDataBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insertDataBtn.Location = new System.Drawing.Point(353, 488);
            this.insertDataBtn.Margin = new System.Windows.Forms.Padding(5);
            this.insertDataBtn.Name = "insertDataBtn";
            this.insertDataBtn.Size = new System.Drawing.Size(182, 78);
            this.insertDataBtn.TabIndex = 2;
            this.insertDataBtn.Text = "新增資料";
            this.insertDataBtn.UseVisualStyleBackColor = true;
            this.insertDataBtn.Click += new System.EventHandler(this.insertDataBtn_Click);
            // 
            // updateDataBtn
            // 
            this.updateDataBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.updateDataBtn.Location = new System.Drawing.Point(607, 488);
            this.updateDataBtn.Margin = new System.Windows.Forms.Padding(5);
            this.updateDataBtn.Name = "updateDataBtn";
            this.updateDataBtn.Size = new System.Drawing.Size(182, 78);
            this.updateDataBtn.TabIndex = 3;
            this.updateDataBtn.Text = "修改資料";
            this.updateDataBtn.UseVisualStyleBackColor = true;
            this.updateDataBtn.Click += new System.EventHandler(this.updateDataBtn_Click);
            // 
            // deleteDataBtn
            // 
            this.deleteDataBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteDataBtn.Location = new System.Drawing.Point(849, 488);
            this.deleteDataBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteDataBtn.Name = "deleteDataBtn";
            this.deleteDataBtn.Size = new System.Drawing.Size(182, 78);
            this.deleteDataBtn.TabIndex = 4;
            this.deleteDataBtn.Text = "刪除資料";
            this.deleteDataBtn.UseVisualStyleBackColor = true;
            this.deleteDataBtn.Click += new System.EventHandler(this.deleteDataBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 592);
            this.Controls.Add(this.deleteDataBtn);
            this.Controls.Add(this.updateDataBtn);
            this.Controls.Add(this.insertDataBtn);
            this.Controls.Add(this.importDataBtn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "主畫面";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button importDataBtn;
        private System.Windows.Forms.Button insertDataBtn;
        private System.Windows.Forms.Button updateDataBtn;
        private System.Windows.Forms.Button deleteDataBtn;
    }
}

