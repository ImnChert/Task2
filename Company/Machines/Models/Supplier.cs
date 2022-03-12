using ProductTable.Interfaces;

namespace Company.Machines.Models
{
	/// <summary>
	/// Abstract implementation of the provider.
	/// </summary>
	internal abstract class Supplier
	{
		/// <summary>
		/// A method for calculating the cost of a table.
		/// </summary>
		/// <param name="part">Part of the table.</param>
		public abstract void BuyPartOfTheTable(PartOfTheTable part);
	}
}
