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
        DrugStoreContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new DrugStoreContext();
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
            stuffIdCB.Focus();
            SetOperator();
            SetFakturDate();
            SetFakturNumber();
            SetComboBoxData();
            _orderItemsRequests = new List<OrderItemsRequest>();
            dataGridView1.DataSource = _orderItemsRequests;
        }
        private void SetComboBoxData()
        {

            var stuffs = _context.Stuffs.ToList();
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

        private void SetOperator()
        {
            var users = _context.Users.ToList();
            operatorTB.Text = users[0].Username.ToUpper();
        }

        private void SetFakturNumber()
        {
            var orders = _context.Orders.ToList();
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

        private void ClearCalculationField()
        {
            totalTB.Clear();
            qtyTb.Clear();
            chanceTB.Clear();
            moneyTB.Clear();
        }

        private void ResetAll()
        {
            SetFakturNumber();
            ClearForm();
            ClearCalculationField();
            _orderItemsRequests = new List<OrderItemsRequest>();
            dataGridView1.DataSource = typeof(List<OrderItemsRequest>);
            dataGridView1.DataSource = _orderItemsRequests;
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

        private void createOrder()
        {
            var orderRequest = new OrderRequest(
                DateTime.Now.ToLocalTime(),
                 _orderItemsRequests
                );

            List<OrderDetail> details = new List<OrderDetail>();
            Order order = new Order(
                    fakturNo: noFakturTB.Text,
                    new DateTime()
                );
            _context.Orders.Add(order);
            _context.SaveChanges();

            order.Details = _orderItemsRequests.Select(item =>
            {
                Stuff stuff = _context.Stuffs.FirstOrDefault(stf => stf.Name.Equals(item.Nama));

                if (stuff != null)
                {
                    return new OrderDetail(
                        order: order,
                        stuff: stuff,
                        qty: item.JmlBeli,
                        price: stuff.Price
                    );
                }
                else
                {
                    Console.WriteLine($"Stuff not found for item: {item.Nama}");
                    return null;
                }
            }).ToList();


            _context.SaveChanges();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(qtyTb.Text.IsNullOrEmpty() ? "0" : qtyTb.Text);
            if (qty > 0)
            {
                var request = new OrderItemsRequest(
                dataGridView1.Rows.Count + 1,
                   _selectedItem.Id,
                   _selectedItem.Name,
                   qty,
                   qty * _selectedItem.Price
                );
                _orderItemsRequests.Add(request);

                dataGridView1.DataSource = typeof(List<OrderItemsRequest>);
                dataGridView1.DataSource = _orderItemsRequests;

                SetPayment();

                CheckChance();
            }
            else
            {
                MessageBox.Show("Jumlah Barang tidak boleh kosong!");
            }
        }

        private void SetPayment()
        {
            int total = _orderItemsRequests.Aggregate(0, (sum, x) => sum + x.SubTotal);
            var price = total.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
            price = price.Substring(0, price.Length - 3);
            price = price.Substring(2);
            totalTB.Text = price;
        }

        private void SetChance(int chance)
        {
            var price = chance.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
            price = price.Substring(0, price.Length - 3);
            price = price.Substring(2);
            chanceTB.Text = price;
            saveButton.Enabled = true;
        }

        private void CheckChance()
        {
            int money = int.Parse(moneyTB.Text.IsNullOrEmpty() ? "0" : moneyTB.Text);
            int total = _orderItemsRequests.Aggregate(0, (sum, x) => sum + x.SubTotal);
            int chance = (money - total);

            if (chance >= 0)
            {
                SetChance(chance);
            }
            else
            {
                saveButton.Enabled = false;
                chanceTB.Text = "0";

            }
        }

        private void moneyTB_TextChanged(object sender, EventArgs e)
        {
            CheckChance();
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
            if (e.ColumnIndex == 3)
            {
                var value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                _orderItemsRequests.Select(item =>
                {
                    if (item.No == e.RowIndex + 1)
                    {
                        item.JmlBeli = (int)value;
                    }
                    return item;
                });

            }
            label1.Text = e.ColumnIndex.ToString();
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            int money = int.Parse(moneyTB.Text.IsNullOrEmpty() ? "0" : moneyTB.Text);
            //var qty = Int32.Parse(qtyTb.Text);

            int total = _orderItemsRequests.Aggregate(0, (sum, x) => sum + x.SubTotal);
            bool isValid = (money - total) >= 0 ? true : false;
            if (isValid)
            {
                createOrder();
                MessageBox.Show("Pembelian Berhasil");
                ResetAll();
            }
        }

        private void totalTB_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
