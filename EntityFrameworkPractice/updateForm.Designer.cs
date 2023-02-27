namespace EntityFrameworkPractice
{
    partial class UpdateForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateDataBtn = new System.Windows.Forms.Button();
            this.ptype_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pamount_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pname_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pid_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "搜尋欲修改之商品編號";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 29);
            this.textBox1.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(445, 40);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(121, 48);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "搜尋";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateDataBtn);
            this.panel1.Controls.Add(this.ptype_textBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.price_textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pamount_textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pname_textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pid_TextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(35, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 426);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // updateDataBtn
            // 
            this.updateDataBtn.Location = new System.Drawing.Point(70, 354);
            this.updateDataBtn.Name = "updateDataBtn";
            this.updateDataBtn.Size = new System.Drawing.Size(394, 48);
            this.updateDataBtn.TabIndex = 4;
            this.updateDataBtn.Text = "修改";
            this.updateDataBtn.UseVisualStyleBackColor = true;
            this.updateDataBtn.Click += new System.EventHandler(this.updateDataBtn_Click);
            // 
            // ptype_textBox
            // 
            this.ptype_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ptype_textBox.Location = new System.Drawing.Point(168, 300);
            this.ptype_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.ptype_textBox.Name = "ptype_textBox";
            this.ptype_textBox.Size = new System.Drawing.Size(296, 29);
            this.ptype_textBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(66, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "商品類型";
            // 
            // price_textBox
            // 
            this.price_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.price_textBox.Location = new System.Drawing.Point(168, 222);
            this.price_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(296, 29);
            this.price_textBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(66, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "商品價格";
            // 
            // pamount_textBox
            // 
            this.pamount_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pamount_textBox.Location = new System.Drawing.Point(168, 154);
            this.pamount_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.pamount_textBox.Name = "pamount_textBox";
            this.pamount_textBox.Size = new System.Drawing.Size(296, 29);
            this.pamount_textBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(66, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "商品數量";
            // 
            // pname_textBox
            // 
            this.pname_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pname_textBox.Location = new System.Drawing.Point(168, 86);
            this.pname_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.pname_textBox.Name = "pname_textBox";
            this.pname_textBox.Size = new System.Drawing.Size(296, 29);
            this.pname_textBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(66, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "商品名稱";
            // 
            // pid_TextBox
            // 
            this.pid_TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pid_TextBox.Location = new System.Drawing.Point(168, 24);
            this.pid_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.pid_TextBox.Name = "pid_TextBox";
            this.pid_TextBox.Size = new System.Drawing.Size(296, 29);
            this.pid_TextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(66, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "商品編號";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.Text = "修改資料";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateDataBtn;
        private System.Windows.Forms.TextBox ptype_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pamount_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pname_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pid_TextBox;
        private System.Windows.Forms.Label label6;
    }
}