using ProductTable.Models;
using ProductTable.Models.ModelsTable;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProductTable.Services
{
	public class JSON
	{
		private string _filename;

		public JSON()
		{
			_filename = "test.json";
		}
		public JSON(string filename)
		{
			_filename = filename;
		}

		public async Task<CollectionTable> ReaderAsync()
		{
			var collection = new CollectionTable();

			using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
			{
				Table? table = await JsonSerializer.DeserializeAsync<Table>(fs);
				collection.Add(table);
			}

			return collection;
		}

		public async Task WriterAsync(CollectionTable collection)
		{
			using (FileStream fs = new FileStream(_filename, FileMode.OpenOrCreate))
			{
				foreach (Table table in collection.List)
				{

					await JsonSerializer.SerializeAsync<Table>(fs, table);
					Console.WriteLine("Data has been saved to file");

				}
			}
		}
	}
}
