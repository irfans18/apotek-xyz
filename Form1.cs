using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WinFormsApp1.Config;
using WinFormsApp1.Models;
using WinFormsApp1.Models.Requests;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Stuff> _stuffList;
        Stuff _selectedItem;
        List<OrderItemsRequest> _orderItemsRequests;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var context = new DrugStoreContext();
            stuffIdCB.Focus();
            SetOperator(context);
            SetFakturDate();
            SetFakturNumber(context);
            SetComboBoxData(context);
            _orderItemsRequests = new List<OrderItemsRequest>();
            dataGridView1.DataSource = _orderItemsRequests;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }
        }
        private void SetComboBoxData(DrugStoreContext context)
        {

            var stuffs = context.Stuffs.ToList();
            stuffIdCB.Text = "Pilih Kode Barang";

            _stuffList = new List<Stuff>(stuffs);
            stuffs.ForEach(stuff =>
            {
                stuffIdCB.Items.Add(stuff);
            });
            //stuffIdCB.DataSource = stuffs;
            stuffIdCB.DisplayMember = "Id";
            stuffIdCB.ValueMember = "Name";
        }

        private void SetOperator(DrugStoreContext context)
        {
            var users = context.Users.ToList();
            operatorTB.Text = users[0].Username;
        }

        private void SetFakturNumber(DrugStoreContext context)
        {
            var orders = context.Orders.ToList();
            var order = orders.Last();
            var faktur = order.FakturNo;
            faktur = faktur.Substring(1);
            var fakturNumber = Int32.Parse(faktur) + 1;
            faktur = fakturNumber.ToString().Length switch
            {
                1 => "F00" + fakturNumber.ToString(),
                2 => "F0" + fakturNumber.ToString(),
                _ => "F" + fakturNumber.ToString()
            };
            //noFakturTB.Text = fakturNumber.ToString();
            noFakturTB.Text = faktur.ToString();
        }
        private void SetFakturDate()
        {
            dateTB.Text = DateTime.Now.ToString("dd MMM yyyy");
        }

        private void ClearForm()
        {
            stuffIdCB.Text = "Pilih Kode Barang";
            stuffNameTB.Clear();
            stuffPriceTB.Clear();
            subTotalTB.Clear();
            qtyTb.Clear();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void stuffIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = stuffIdCB.SelectedIndex;
            if (index < 0) _selectedItem = new Stuff();
            else
            {
                var item = _stuffList[index];
                _selectedItem = item;
                var price = item.Price.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
                price = price.Substring(0, price.Length - 3);
                price = price.Substring(2);

                stuffNameTB.Text = item.Name;
                stuffPriceTB.Text = price;


                var qty = Int32.Parse(qtyTb.Text.IsNullOrEmpty() ? "0" : qtyTb.Text);
                subTotalTB.Text = (qty * item.Price).ToString();
            }
        }


        private void qtyTb_TextChanged(object sender, EventArgs e)
        {
            var qty = int.Parse(qtyTb.Text.IsNullOrEmpty() ? "0" : qtyTb.Text);
            //var qty = Int32.Parse(qtyTb.Text);

            var priceNumber = (qty * _selectedItem.Price);
            var price = priceNumber.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
            price = price.Substring(0, price.Length - 3);
            price = price.Substring(2);
            subTotalTB.Text = price;

        }

        private void qtyTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var request = new OrderItemsRequest(
                dataGridView1.Rows.Count + 1,
                   _selectedItem.Id,
                   _selectedItem.Name,
                   int.Parse(qtyTb.Text),
                   int.Parse(qtyTb.Text) * _selectedItem.Price
                );
            _orderItemsRequests.Add(request);

            dataGridView1.DataSource = typeof(List<OrderItemsRequest>);
            dataGridView1.DataSource = _orderItemsRequests;

            int total = _orderItemsRequests.Aggregate(0, (sum, x) => sum + x.SubTotal);
            var price = total.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
            price = price.Substring(0, price.Length - 3);
            price = price.Substring(2);
            totalTB.Text = price;
        }

        private void moneyTB_TextChanged(object sender, EventArgs e)
        {
            var money = int.Parse(moneyTB.Text.IsNullOrEmpty() ? "0" : moneyTB.Text);
            //var qty = Int32.Parse(qtyTb.Text);

            int total = _orderItemsRequests.Aggregate(0, (sum, x) => sum + x.SubTotal);
            var priceNumber = (money - total);

            if (priceNumber > 0)
            {
                var price = priceNumber.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
                price = price.Substring(0, price.Length - 3);
                price = price.Substring(2);
                chanceTB.Text = price;
            }
            else
            {
                chanceTB.Text = "0";

            }
        }

        private void moneyTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //label1.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (e.ColumnIndex == 3)
            {
                var value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                _orderItemsRequests.Select(item =>
                {
                    if (item.No == e.RowIndex + 1)
                    {
                        item.JmlBeli = (int) value;
                        //int price = _orderItemsRequests.Where(req => )
                        //item.SubTotal = item.JmlBeli * 
                    }
                    return item;
                });

            }
            label1.Text = e.ColumnIndex.ToString();
        }
    }

}
