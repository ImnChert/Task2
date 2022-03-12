using ProductTable.Interfaces;

namespace Company.Machines.Models
{
	/// <summary>
	/// Supplier of the company.
	/// </summary>
	internal class MySupplier : Supplier
	{
		/// <summary>
		/// A method for calculating the cost of a table.
		/// </summary>
		/// <param name="part">Part of the table.</param>
		public override void BuyPartOfTheTable(PartOfTheTable part)
		{
			part.Price = 400;
		}
	}
}
