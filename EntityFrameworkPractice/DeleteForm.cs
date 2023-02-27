using EntityFrameworkPractice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkPractice
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var db = new ProductContext();
            var deletedItem = db.Products.FirstOrDefault(x => x.PID == textBox1.Text);
            if (deletedItem != null)
            {
                var msgBox = MessageBox.Show($"請確認以下資料是否要刪除:\n\n" +
                    $"商品編號：{deletedItem.PID}\n" +
                    $"商品名稱：{deletedItem.ProductName}\n\n注意，其相關資料也會刪除",
                    "系統訊息",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msgBox == DialogResult.Yes)
                {
                    //寫法一
                    db.Products.Attach(deletedItem);
                    db.Products.Remove(deletedItem);

                    //寫法二
                    //db.Entry(deletedItem).State = EntityState.Deleted; 
                    db.SaveChanges();
                    MessageBox.Show($"資料刪除成功，請回到主畫面查看資料", "系統訊息",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
