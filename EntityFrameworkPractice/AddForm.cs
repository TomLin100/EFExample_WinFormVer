using EntityFrameworkPractice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkPractice
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new ProductContext();
            var isProductExist = db.Products.Any(p => p.PID == pid_TextBox.Text);
            if (!isProductExist) 
            {
                var product = new Product()
                {
                    PID = pid_TextBox.Text,
                    ProductName = pname_textBox.Text,
                    Amount = int.Parse(pamount_textBox.Text),
                    Price = int.Parse(price_textBox.Text),
                    ProductType = ptype_textBox.Text
                };
                db.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show($"資料新增成功，請回到主畫面查看資料", "系統訊息",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"資料庫內已有相同資料了", "注意",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
