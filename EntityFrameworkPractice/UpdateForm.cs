using EntityFrameworkPractice.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EntityFrameworkPractice
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var db = new ProductContext();
            var result = db.Products.FirstOrDefault(x => x.PID == textBox1.Text);
            if (result != null)
            {
                panel1.Visible = true;
                pid_TextBox.Text = result.PID;
                pname_textBox.Text = result.ProductName;
                pamount_textBox.Text = result.Amount.ToString();
                price_textBox.Text = result.Price.ToString();
                ptype_textBox.Text = result.ProductType;
            }
            else
            {
                MessageBox.Show($"資料庫內找不到您所搜尋的資料，請再次搜尋!", "注意",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateDataBtn_Click(object sender, EventArgs e)
        {
            var db = new ProductContext();
            var result = db.Products.FirstOrDefault(x => x.PID == textBox1.Text);
            var updated_product = new Product()
            {
                PID = pid_TextBox.Text,
                ProductName = pname_textBox.Text,
                ProductType = ptype_textBox.Text,
                Amount = int.Parse(pamount_textBox.Text),
                Price = int.Parse(price_textBox.Text)
            };

            if (result != null)
            {
                //第一種寫法
                result.PID = updated_product.PID;
                result.ProductName = updated_product.ProductName;
                result.Amount = updated_product.Amount;
                result.Price = updated_product.Price;
                result.ProductType = updated_product.ProductType;

                //第二種寫法
                //db.Entry(result).CurrentValues.SetValues(updated_product);

                db.SaveChanges();
                MessageBox.Show($"資料修改成功，請回到主畫面查看資料", "系統訊息",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"資料庫內找不到您要修改的資料，請再次搜尋!", "注意",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
