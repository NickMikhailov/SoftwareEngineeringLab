using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01v2.Models
{
    internal class SumTableModel
    {
        static private int counter;
        private int id;
        private string detail;
        private int quantity;

        public int ID
        {
            get { return id; }
        }
        public string Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public SumTableModel(string detail, int quantity)
        {
            id = ++counter;
            this.detail = detail;
            this.quantity = quantity;
        }
        public static void counterZero()
        {
            counter = 0;
        }
    }
}
