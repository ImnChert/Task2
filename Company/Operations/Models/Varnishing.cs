using Company.Operations.Interfaces;
using ProductTable.Models.ModelsTable;

namespace Company.Operations.Models
{
	/// <summary>
	/// Varnishing operation.
	/// </summary>
	internal class Varnishing : IOperation
	{
		public void Processing(Table table)
			=> table.Price *= 1.35M;
	}
}
