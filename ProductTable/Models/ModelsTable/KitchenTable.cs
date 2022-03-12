using ProductTable.Models.PartOfTheTable;

namespace ProductTable.Models.ModelsTable
{
	/// <summary>
	/// Description of the kitchen table.
	/// </summary>
	public class KitchenTable : Table
	{
		public KitchenTable()
		{ }
		public KitchenTable(Top top, Leg leg, Accessorie accessorie) : base(top, leg, accessorie, "KitchenTable")
		{
		}
	}
}
