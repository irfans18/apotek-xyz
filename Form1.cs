using WinFormsApp1.Config;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
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
            var users = context.Users.ToList();
            operatorTB.Text = users[0].Username;
            setFakturDate();
            setFakturNumber(context);
            dataGridView1.DataSource = users;
            
        }

        private void setFakturNumber(DrugStoreContext context)
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
        private void setFakturDate()
        {
            dateTB.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }
    }
}
