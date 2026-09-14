using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();

           
        }

        private void TxtWaming_Click(object sender, EventArgs e)
        {
            //تحذير بتجاوز الميزانيه 
            TxtWaming.Visible = false;
        }

        private void AddBudget_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BudgetLimet.Text = " الميزانية " + trackBar1.Value.ToString();

            if (trackBar1.Value > 300)
            {
                TxtWaming.Text = "تحذير: قمت بتجاوز نص الميزانية العامة !";
                TxtWaming.BackColor = Color.Red;
                TxtWaming.ForeColor = Color.White;
            }
            else
            {
                TxtWaming.Text = "";
                TxtWaming.BackColor = Color.White;
                TxtWaming.ForeColor = Color.Black;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            BudgetFood.Text = " الميزانية " + trackBar2.Value.ToString();

            if (trackBar2.Value > 200)
            {
                TxtWaming.Text = "تنبيه: ميزانية الطعام مرتفعة!";
                TxtWaming.BackColor = Color.Red;
                TxtWaming.ForeColor = Color.White;
            }
            else
            {
                TxtWaming.Text = "";
                TxtWaming.BackColor = Color.White;
                TxtWaming.ForeColor = Color.Black;
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            BudgetCoffe.Text = " الميزانية " + trackBar3.Value.ToString();

            if (trackBar3.Value > 150)
            {
                TxtWaming.Text = "تنبيه: ميزانية القهوة مرتفعة!";
                TxtWaming.BackColor = Color.Red;
                TxtWaming.ForeColor = Color.White;
            }
            else
            {
                TxtWaming.Text = "";
                TxtWaming.BackColor = Color.White;
                TxtWaming.ForeColor = Color.Black;
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {

            BudgetShopping.Text = trackBar4.Text = "الميزانيه " + trackBar4.Value.ToString();


            if (trackBar4.Value > 200)
            {
                TxtWaming.Text = "تنبيه: ميزانية التسوق مرتفعة!";
                TxtWaming.BackColor = Color.Red;
                TxtWaming.ForeColor = Color.White;
            }
            else
            {
                TxtWaming.Text = "";
                TxtWaming.BackColor = Color.White;
                TxtWaming.ForeColor = Color.Black;
            }
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {

            BudgetBills.Text = trackBar5.Text = "الميزانيه " + trackBar5.Value.ToString();


            if (trackBar5.Value > 400)
            {
                TxtWaming.Text = "تنبيه: ميزانية الفواتير مرتفعة!";
                TxtWaming.BackColor = Color.Red;
                TxtWaming.ForeColor = Color.White;
            }
            else
            {
                TxtWaming.Text = "";
                TxtWaming.BackColor = Color.White;
                TxtWaming.ForeColor = Color.Black;
            }

        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {

            BudgetOther.Text = trackBar6.Text = "الميزانيه " + trackBar6.Value.ToString();


            if (trackBar6.Value > 350)
            {
                TxtWaming.Text = "تنبيه: ميزانية اخرى مرتفعة!";
                TxtWaming.BackColor = Color.Red;
                TxtWaming.ForeColor = Color.White;
            }
            else
            {
                TxtWaming.Text = "";
                TxtWaming.BackColor = Color.White;
                TxtWaming.ForeColor = Color.Black;
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // جمع القيم
            int foodBudget = trackBar2.Value;
            int coffeBudget = trackBar3.Value;
            int shoppingBudget = trackBar4.Value;
            int billsBudget = trackBar5.Value;
            int otherBudget = trackBar6.Value;

            //  حفظ القيم في ملف CSV أو نصي
            string filePath = "budgets.csv";

            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                sw.WriteLine("Category,Amount");
                sw.WriteLine($"Food,{foodBudget}");
                sw.WriteLine($"Coffe,{coffeBudget}");
                sw.WriteLine($"Shopping,{shoppingBudget}");
                sw.WriteLine($"Bills,{billsBudget}");
                sw.WriteLine($"Other,{otherBudget}");
            }

            MessageBox.Show("تم حفظ الميزانيات بنجاح!");
        }
    }
}
