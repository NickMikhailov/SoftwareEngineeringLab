using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01v2.Models
{
    class TableModel
    {
        static private int counter = 0;
        public int Id { get; }
        public string Detail { get; set; }
        public int Cell { get; set; }
        public int Quantity { get; set; }
        public TableModel(string detail, int cell, int quantity) {
            Id = ++counter;
            Detail = detail;
            Cell = cell;
            Quantity = quantity;
        }
    }
}
