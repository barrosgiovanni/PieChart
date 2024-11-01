using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieChart
{
    public class Category
    {
        public string Name { get; set; }
        public double TotalAmount { get; set; }
        public Category(string name, double totalAmount) 
        { 
            Name = name;
            TotalAmount = totalAmount;
        }
    }
}
