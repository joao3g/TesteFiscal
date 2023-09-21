using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiscal.Model;

namespace Fiscal.Controller
{
    internal class NotaFiscalController
    {
        private const string TABLE_NAME = "NotaFiscal";

        public static async Task Insert(NotaFiscal item, NpgsqlConnection connection)
        {
            string commandText = $"INSERT INTO {TABLE_NAME} (idnota, emissor, date, value) VALUES (@id, @emitter, @date, @value)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("id", item.ID);
                cmd.Parameters.AddWithValue("emitter", item.emitter);
                cmd.Parameters.AddWithValue("date", item.date);
                cmd.Parameters.AddWithValue("value", 10.10);

                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
