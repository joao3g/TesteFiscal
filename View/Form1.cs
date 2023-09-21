using Fiscal.Model;
using Fiscal.Controller;

namespace Fiscal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Database database = Database.Instance;

            // DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
            // NotaFiscal nota = new NotaFiscal("Joao", date1);

            // Item item = new Item(1, 1, "Produto 1", 10.45);
            // await ItemController.Insert(item, database.connection);

            List<NotaFiscal> lista = await NotaFiscalController.List(database.connection);

            dataGridView1.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateInvoice createInvoice = new CreateInvoice();

            createInvoice.Show();
        }
    }
}