﻿namespace Fiscal.Model
{
    internal class NotaFiscal
    {  
        public int ID { get; set; }
        public string emitter { get; set; }
        public DateTime date { get; set; }
        public double value { get; set; }

        public NotaFiscal(int id, string emitter, DateTime date)
        {
            this.ID = id;
            this.emitter = emitter;
            this.date = date;
        }
    }
}
