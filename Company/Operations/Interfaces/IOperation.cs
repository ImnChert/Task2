using ProductTable.Models.ModelsTable;

namespace Company.Operations.Interfaces
{
	/// <summary>
	/// Interface for operations.
	/// </summary>
	public interface IOperation
	{
		/// <summary>
		/// Table processing.
		/// </summary>
		/// <param name="table">Table</param>
		public void Processing(Table table);
	}
}
