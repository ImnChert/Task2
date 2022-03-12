using Company.Operations.Interfaces;
using ProductTable.Models.ModelsTable;

namespace Company.Operations.Models
{
	/// <summary>
	/// Grinding operation.
	/// </summary>
	internal class Grinding : IOperation
	{
		public void Processing(Table table)
			=> table.Price *= 1.2M;
	}
}
