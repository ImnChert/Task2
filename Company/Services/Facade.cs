using ProductTable.Models.ModelsTable;
using FactoryParametrsOfProducts.Models.Material;

namespace Company
{
	/// <summary>
	/// Implementation of the facade pattern.
	/// </summary>
	public class Facade
	{
		protected Subsystem _subsystem;

		public Chipboard ChipboardForLeg => _subsystem.ChipboardForLeg;

		public Chipboard ChipboardForTop => _subsystem.ChipboardForTop;

		public Facade(Subsystem subsystem)
		{
			_subsystem = subsystem;
		}

		/// <summary>
		/// Operations performed on the table.
		/// </summary>
		/// <param name="chipboardForTop">Chipboard sheet for the top.</param>
		/// <param name="chipboardForLeg">Chipboard sheet for the leg.</param>
		/// <returns>Table.</returns>
		public Table Operation(Chipboard chipboardForTop, Chipboard chipboardForLeg)
		{
			Table table = _subsystem.OpetationOne(chipboardForTop, chipboardForLeg);
			table = _subsystem.OperationTwo(table);

			return table;
		}
	}
}
