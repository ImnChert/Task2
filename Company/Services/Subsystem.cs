using ProductTable.Models.ModelsTable;
using Company.Operations.Interfaces;
using System.Collections.Generic;
using FactoryParametrsOfProducts.Models.Material;
using ProductTable.Models.PartOfTheTable;

namespace Company
{
	/// <summary>
	/// Implementation of the instructions for creating a table.
	/// </summary>
	/// <typeparam name="T">Type of the table.</typeparam>
	public abstract class Subsystem
	{
		public Chipboard ChipboardForLeg { get; }
		public Chipboard ChipboardForTop { get; }

		public Subsystem()
		{
			ChipboardForLeg = null;
			ChipboardForTop = null;
		}

		public Subsystem(Chipboard chipboardForTop, Chipboard chipboardForLeg = null)
		{
			ChipboardForLeg = chipboardForLeg;
			ChipboardForTop = chipboardForTop;
		}

		/// <summary>
		/// Implementation of the instructions for creating a table.
		/// </summary>
		/// <param name="chipboardSheetForLeg">Chipboard sheet for the leg.</param>
		/// <param name="chipboardSheetForTop">Chipboard sheet for the top.</param>
		/// <returns>Table.</returns>
		public abstract Table OpetationOne(Chipboard chipboardSheetForLeg, Chipboard chipboardSheetForTop);

		/// <summary>
		/// Instructions for creating a table.
		/// </summary>
		/// <returns>Parts of the table.</returns>
		protected abstract (Accessorie, Leg, Top) InstructionForCreate();

		/// <summary>
		/// Processing of the table.
		/// </summary>
		/// <param name="table">Table.</param>
		/// <returns>Processed table.</returns>
		public Table OperationTwo(Table table)
		{
			foreach (IOperation item in AvailableOperations())
				item.Processing(table);

			return table;
		}

		/// <summary>
		/// List of available treatments.
		/// </summary>
		/// <returns>List of available treatments.</returns>
		public abstract List<IOperation> AvailableOperations();
	}
}
