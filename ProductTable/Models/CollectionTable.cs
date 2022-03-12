using ProductTable.Models.ModelsTable;
using System.Collections.Generic;

namespace ProductTable.Models
{
	/// <summary>
	/// Description of the table collection.
	/// </summary>
	public class CollectionTable
	{
		private List<Table> list;

		public List<Table> List => list;

		public CollectionTable(List<Table> list) => this.list = list;
		public CollectionTable() => list = new List<Table>();
		/// <summary>
		/// Adding a table to the list.
		/// </summary>
		/// <param name="table">New table.</param>
		public void Add(Table table) => list.Add(table);
		/// <summary>
		/// Removing a table from the list.
		/// </summary>
		/// <param name="table">Table.</param>
		public void Remove(Table table) => list.Remove(table);
		/// <summary>
		/// Sorting the collection by name.
		/// </summary>
		public void SortByName() => list.Sort((x, y) => string.Compare(x.Name, y.Name));
		/// <summary>
		/// Sorting the collection by price.
		/// </summary>
		public void SortByPrice() => list.Sort((x, y) => decimal.Compare(x.Price, y.Price));
	}
}
