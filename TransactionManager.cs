using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace WindowsFormsApp1
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
    }

    internal class TransactionManager
    {
        // دالة لتحويل التاريخ الهجري إلى ميلادي
        public DateTime ConvertHijriToGregorian(int hijriYear, int hijriMonth, int hijriDay)
        {
            HijriCalendar hijriCalendar = new HijriCalendar();
            try
            {
                DateTime gregorianDate = hijriCalendar.ToDateTime(hijriYear, hijriMonth, hijriDay, 0, 0, 0, 0);
                return gregorianDate;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("التاريخ الهجري المدخل غير صالح.");
                return DateTime.MinValue;
            }
        }

        // إضافة معاملة جديدة إلى ملف CSV
        public void AddTransactionToFile(DateTime date, decimal amount, string category)
        {
            var csv = new StringBuilder();

            // إضافة رأس الأعمدة إذا كان الملف فارغًا
            if (!File.Exists("transactions.csv"))
            {
                csv.AppendLine("Date,Amount,Category"); // إضافة رأس الأعمدة
            }

            // إضافة بيانات المعاملة
            csv.AppendLine($"{date.ToString("dd/MM/yyyy")},{amount},{category}");

            // حفظ البيانات في الملف
            File.AppendAllText("transactions.csv", csv.ToString());

            // تحقق من وجود الملف وتسجيل رسالة
            if (File.Exists("transactions.csv"))
            {
                MessageBox.Show("File created/updated successfully at: " + Path.GetFullPath("transactions.csv"));
            }
            else
            {
                MessageBox.Show("There was an error creating the file.");
            }
        }

        // قراءة المعاملات من ملف CSV
        public List<Transaction> ReadTransactionsFromFile()
        {
            var transactions = new List<Transaction>();

            if (File.Exists("transactions.csv"))
            {
                string[] lines = File.ReadAllLines("transactions.csv");

                // نبدأ من 1 لتخطي رأس الأعمدة
                for (int i = 1; i < lines.Length; i++)
                {
                    var parts = lines[i].Split(',');
                    if (parts.Length == 3)
                    {
                        DateTime date;
                        decimal amount;

                        // تحويل التاريخ الهجري إلى ميلادي
                        string[] hijriDateParts = parts[0].Split('/');
                        if (hijriDateParts.Length == 3)
                        {
                            int hijriYear = int.Parse(hijriDateParts[2]);
                            int hijriMonth = int.Parse(hijriDateParts[1]);
                            int hijriDay = int.Parse(hijriDateParts[0]);

                            date = ConvertHijriToGregorian(hijriYear, hijriMonth, hijriDay);
                        }
                        else
                        {
                            date = DateTime.MinValue; // إذا كانت البيانات غير صالحة
                        }

                        if (date != DateTime.MinValue && decimal.TryParse(parts[1], out amount))
                        {
                            transactions.Add(new Transaction
                            {
                                Date = date,
                                Amount = amount,
                                Category = parts[2]
                            });
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("لا يوجد ملف معاملات حتى الآن.");
            }

            return transactions;
        }
    }
}