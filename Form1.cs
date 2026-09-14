using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Reflection.Emit;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TransactionManager manager = new TransactionManager();

        public Form1()
        {
            InitializeComponent();

            // مثال تعبئة الخيارات
            CmbCategory.Items.AddRange(new string[] { "Food", "Transport", "Shopping", "Other" });
            CmbCategory.SelectedIndex = -1;
            TxtOtherCategory.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // التحقق من أن التاريخ ليس من المستقبل
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {

                label1.Text = "لا يمكنك إدخال تاريخ من المستقبل";
                label1.Visible = true;
            }
            else
            {
                label1.Text = "";
            }
        }

        private void CmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // التحقق من اختيار فئة
            if (CmbCategory.SelectedIndex == -1)
            {
                label2.Text = "يرجى اختيار الفئة.";
                label2.Visible = true;
                TxtOtherCategory.Visible = false;
            }
            else if (CmbCategory.SelectedItem.ToString() == "Other")
            {
                TxtOtherCategory.Visible = true;
                label2.Text = "يرجى كتابة الفئة في الحقل المخصص.";
                label2.Visible = true;

            }
            else
            {
                TxtOtherCategory.Visible = false;
                label2.Text = "";
            }
        }

        private void TxtOtherCategory_TextChanged(object sender, EventArgs e)
        {
            // التحقق من خانة الفئة الأخرى
            if (CmbCategory.SelectedItem != null && CmbCategory.SelectedItem.ToString() == "Other" && string.IsNullOrWhiteSpace(TxtOtherCategory.Text))
            {
                label2.Text = "يرجى كتابة الفئة في الحقل المخصص";
                label3.Visible = true;

            }
            else
            {
                label2.Text = "";
            }
        }

        private void TxtAmont_TextChanged(object sender, EventArgs e)
        {
            decimal amount;
            if (!decimal.TryParse(TxtAmont.Text, out amount))
            {
                label3.Text = "يرجى إدخال مبلغ صالح";
                label3.Visible = true;

            }
            else if (amount <= 0)
            {
                label3.Text = "المبلغ يجب أن يكون أكبر من الصفر";
                label3.Visible = true;

            }
            else
            {
                label3.Text = "";
            }
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            // التحقق من كل الشروط
            bool valid = true;

            // التاريخ
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                label1.Text = "لا يمكنك إدخال تاريخ من المستقبل";
                label1.Visible = true;

                valid = false;
            }
            else
            {
                label1.Text = "";
            }

            // الفئة
            string category = "";
            if (CmbCategory.SelectedIndex == -1)
            {
                label2.Text = "يرجى اختيار الفئة";
                label2.Visible = true;

                valid = false;
            }
            else if (CmbCategory.SelectedItem.ToString() == "Other")
            {
                if (string.IsNullOrWhiteSpace(TxtOtherCategory.Text))
                {
                    label2.Text = "يرجى كتابة الفئة في الحقل المخصص";
                    label2.Visible = true;

                    valid = false;
                }
                else
                {
                    label2.Text = "";
                    category = TxtOtherCategory.Text.Trim();
                }
            }
            else
            {
                label2.Text = "";
                category = CmbCategory.SelectedItem.ToString();
            }

            // المبلغ
            decimal amount;
            if (!decimal.TryParse(TxtAmont.Text, out amount))
            {
                label3.Text = "يرجى إدخال مبلغ صالح";
                label3.Visible = true;

                valid = false;
            }
            else if (amount <= 0)
            {
                label3.Text = "المبلغ يجب أن يكون أكبر من الصفر";
                label3.Visible = true;

                valid = false;
            }
            else
            {
                label3.Text = "";
            }

            // إضافة المعاملة إذا كل الشروط صحيحة
            if (valid)
            {
                manager.AddTransactionToFile(dateTimePicker1.Value.Date, amount, category);
                MessageBox.Show("تمت إضافة المعاملة بنجاح");
                // تحديث القائمة أو الجدول إذا لديك
            }
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            // تفريغ الحقول
            dateTimePicker1.Value = DateTime.Now.Date;
            CmbCategory.SelectedIndex = -1;
            TxtOtherCategory.Text = "";
            TxtOtherCategory.Visible = false;
            TxtAmont.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void SaveTransactions(List<Transaction> transactions)
         {
             var csv = new StringBuilder();
             csv.AppendLine("Date,Amount,Category");
             foreach (var t in transactions)
             {
                 csv.AppendLine($"{t.Date:dd/MM/yyyy},{t.Amount},{t.Category}");
             }
             File.WriteAllText("transactions.csv", csv.ToString());
         }

        private void AddTransaction_Click(object sender, EventArgs e)
        {
          

        }

            private void AddBudget_Click(object sender, EventArgs e)
            {
                // مثال: فتح نافذة الميزانية أو إدخال القيم مباشرة
                // إذا كنت تعمل على نافذة جديدة:
                Budget budgetForm = new Budget();
                budgetForm.ShowDialog();

            // إذا كنت تعمل على نفس الواجهة:
            // ضع كود إضافة الميزانية هنا

             //MessageBox.Show("تم الضغط على زر AddBudge!"); // رسالة للتأكد من عمل الحدث
            }

       /* private void Summary_Click(object sender, EventArgs e)
        {
           
            Summary summaryForm = new Summary(); // إنشاء نافذة الملخص
            summaryForm.Show(); // عرضها
        }*/

        private void view_Click(object sender, EventArgs e)
        {
            View viewForm=new View();
            viewForm.Show();
        }
    }
}

    

    
