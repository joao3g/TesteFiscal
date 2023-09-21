using Fiscal.Controller;
using Fiscal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal
{
    public partial class CreateInvoice : Form
    {
        public CreateInvoice()
        {
            InitializeComponent();
        }

        private class Dataset
        {
            public float value;
            public string product;

            public Dataset(float value, string product)
            {
                this.value = value;
                this.product = product;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Dataset> datasets = new List<Dataset>();

            string emitter = textBox2.Text;
            DateTime date = dateTimePicker1.Value;

            NotaFiscal nota = new NotaFiscal(emitter, date);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string? value = row.Cells[0].Value.ToString();
                string? product = row.Cells[1].Value.ToString();

                if (value != null && product != null)
                {
                    float Fvalue = float.Parse(value, CultureInfo.InvariantCulture.NumberFormat);

                    Dataset dataset = new Dataset(Fvalue, product);
                    datasets.Add(dataset);
                }
            }


            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = dataGridView1.RowCount + 1;
        }
    }
}
