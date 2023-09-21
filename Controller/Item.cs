using Fiscal.Model;
using Npgsql;

namespace Fiscal.Controller
{
    internal class ItemController
    {
        private const string TABLE_NAME = "Item";

        public static async Task Insert(Item item, NpgsqlConnection connection)
        {
            string commandText = $"INSERT INTO {TABLE_NAME} (idnota, produto, valor) VALUES (@IDinvoice, @product, @value)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("IDinvoice", item.IDinvoice);
                cmd.Parameters.AddWithValue("product", item.product);
                cmd.Parameters.AddWithValue("value", item.value);

                await cmd.ExecuteNonQueryAsync();
            }
        }

        public static async Task<double> getTotalValueByIDinvoice(int IDinvoice, NpgsqlConnection connection)
        {
            double result = 0;

            string commandText = $"SELECT SUM(valor) as soma FROM {TABLE_NAME}";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        double? sum = reader["soma"] as double?;
                        result = sum.Value;
                    }
            }

            return result;
        }
    }
}
