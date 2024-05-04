using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models.Requests
{
    public class OrderItemsRequest
    {
        public OrderItemsRequest()
        {
        }

        public OrderItemsRequest(int no, string barangID, string nama, int jmlBeli, int subTotal)
        {
            No = no;
            BarangID = barangID;
            Nama = nama;
            JmlBeli = jmlBeli;
            SubTotal = subTotal;
        }

        public int No { get; set; }
        public string BarangID { get; set; }
        public string Nama { get; set; }
        public int JmlBeli {  get; set; }
        public int SubTotal {  get; set; }



    }
}
