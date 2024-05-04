using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public Order Transaction { get; set; }
        public Stuff Stuff { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
    }
}
