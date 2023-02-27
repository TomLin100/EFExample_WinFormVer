using EntityFrameworkPractice.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EntityFrameworkPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ImportDataToDB(string path)
        {
            var db = new ProductContext();
            try
            {
                var data = File.ReadAllLines(path)
                .Skip(1).Select(x => new Product
                {
                    PID = x.Split(',')[0],
                    ProductName = x.Split(',')[1],
                    Amount = int.Parse(x.Split(',')[2]),
                    Price = int.Parse(x.Split(',')[3]),
                    ProductType = x.Split(',')[4]
                });

                foreach (var item in data)
                {
                    db.Products.Add(item);
                    db.SaveChanges();
                }

                MessageBox.Show($"資料匯入成功!!!", "系統訊息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR!!!, 原因: {ex.Message}", "注意",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int BindData()
        {
            var context = new ProductContext();
            var data_sources = context.Products.ToList();
            dataGridView1.DataSource = data_sources;
            return data_sources.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data_count = BindData();
            if (data_count > 0)
            {
                importDataBtn.Text = "重新整理";
            }
            else
            {
                importDataBtn.Text = "匯入資料";
            }
        }

        private void updateDataBtn_Click(object sender, EventArgs e)
        {
            var updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }

        private void importDataBtn_Click(object sender, EventArgs e)
        {
            var db = new ProductContext();
            var isAlreadyHasData = db.Products.Count();

            if (isAlreadyHasData == 0)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = @"CSV檔 (*.csv)|*.csv";
                dlg.ShowDialog();
                ImportDataToDB(dlg.FileName);
            }
            BindData();
        }

        private void deleteDataBtn_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void insertDataBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.Show();
        }
    }
}
