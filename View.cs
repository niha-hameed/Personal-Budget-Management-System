using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class View : Form
    {
        TransactionManager manager = new TransactionManager();

        public View()
        {
            InitializeComponent();
            // ربط الحدث لزر البحث
            ButSearch.Click += ButSearch_Click;
            label6.Visible = false;

        }

        private void View_Load(object sender, EventArgs e)
        {
            // تهيئة الأعمدة
            InitializeDataGridView();



            // تعيين تاريخ اليوم كقيمة افتراضية
            DtpDateForm.Value = DateTime.Today;
            DtpDateTo.Value = DateTime.Today;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Amount", "Amount");
            dataGridView1.Columns.Add("Category", "Category");
            dataGridView1.Rows.Clear();
        }

        private void ButSearch_Click(object sender, EventArgs e)
        {

            DateTime fromDate = DtpDateForm.Value.Date;
            DateTime toDate = DtpDateTo.Value.Date;

            // MessageBox.Show("From Date: " + fromDate.ToString("dd/MM/yyyy") + " To Date: " + toDate.ToString("dd/MM/yyyy"));

            // تحقق من رينج التاريخ
            if (toDate < fromDate)
            {
                label6.ForeColor = Color.Red;
                label6.Text = "تاريخ النهاية يجب أن يكون بعد أو يساوي تاريخ البداية";
                label6.Visible = true;
                return;
            }

            label6.Visible = false;

            //string selectedCategory = CmbCategoryFilter.SelectedItem?.ToString() ?? string.Empty;

            List<Transaction> allTransactions = manager.ReadTransactionsFromFile();
            List<Transaction> filtered = new List<Transaction>();

            // MessageBox.Show("Total transactions loaded: " + allTransactions.Count);



            foreach (var t in allTransactions)
            {

                bool inRange = t.Date.Date >= fromDate && t.Date.Date <= toDate;
                if (inRange)

                    filtered.Add(t);
            }
            // MessageBox.Show("Total filterd loaded: " + filtered.Count);

            // عرض النتائج في الجدول
            dataGridView1.Rows.Clear();

            foreach (var t in filtered)
            {
                dataGridView1.Rows.Add(
                    t.Date.ToString("dd/MM/yyyy"),
                    t.Amount,
                    t.Category
                );

            }


            // رسم الفئات في الشارت
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Category";
            chart1.ChartAreas[0].AxisY.Title = "Amount";
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Categories");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            var categorySums = filtered
                .GroupBy(t => t.Category)
                .Select(g => new { Category = g.Key, TotalAmount = g.Sum(t => t.Amount) });



            foreach (var item in categorySums)
            {
                series.Points.AddXY(item.Category, item.TotalAmount);
            }
            chart1.Series.Add(series);

            if (filtered.Count == 0)
            {
                MessageBox.Show("لا توجد معاملات مطابقة للبحث.");
            }
        }

    }
}