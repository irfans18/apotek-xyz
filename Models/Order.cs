using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FakturNo { get; set; }
        public DateTime Date { get; set;}
        public User User { get; set; }

        public ICollection<OrderDetail> Details { get; set; }
    }
}
