using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal.Model
{
    internal class NotaFiscal
    {
        public int ID { get; set; }
        public string emitter { get; set; }
        public DateTime date { get; set; }
        public double value { get; set; }

        public NotaFiscal(int id, string emitter, DateTime date, double value)
        {
            this.ID = id;
            this.emitter = emitter;
            this.date = date;
            this.value = value;
        }
    }
}
