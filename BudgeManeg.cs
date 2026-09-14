using System.IO;
using System.Text;

namespace WindowsFormsApp1
{
    public class BudgeManager
    {
        private string filePath = "budgets.csv";

        public void AddBudge(Budge b)
        {
            bool fileExists = File.Exists(filePath);
            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                if (!fileExists)
                {
                    sw.WriteLine("Category,Amount");
                    sw.WriteLine($"{b.Category},{b.Amount}");
                }

            }
        }
    }
}

