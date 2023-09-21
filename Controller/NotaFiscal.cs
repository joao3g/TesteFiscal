using Npgsql;
using Fiscal.Model;

namespace Fiscal.Controller
{
    internal class NotaFiscalController
    {
        private const string TABLE_NAME = "NotaFiscal";

        public static async Task Insert(NotaFiscal item, NpgsqlConnection connection)
        {
            string commandText = $"INSERT INTO {TABLE_NAME} (emissor, data) VALUES (@emitter, @date)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("emitter", item.emitter);
                cmd.Parameters.AddWithValue("date", item.date);

                await cmd.ExecuteNonQueryAsync();
            }
        }

        public static async Task<List<NotaFiscal>> List(NpgsqlConnection connection)
        {
            List<NotaFiscal> result = new List<NotaFiscal>();

            string commandText = $"SELECT * FROM {TABLE_NAME}";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        string emitter = reader["emissor"] as string;
                        int? id = reader["idnota"] as int?;
                        DateTime? date = reader["data"] as DateTime?;

                        NotaFiscal nota = new NotaFiscal(id.Value, emitter, date.Value);
                        result.Add(nota);
                    }
            }

            return result;
        }
    }
}
