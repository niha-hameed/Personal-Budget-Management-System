using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Budge
    {
        public string Category { get; set; }
        public decimal Amount { get; set; }

        public Budge(string category, decimal amount)
        {
            Category = category;
            Amount = amount;
        }
    }
}
