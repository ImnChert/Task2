using FactoryParametrsOfProducts.Models.Figure;
using FactoryParametrsOfProducts.Models.Material;

namespace ProductTable.Models.PartOfTheTable
{
	/// <summary>
	/// Description of leg.
	/// </summary>
	public class Leg : Interfaces.PartOfTheTable
	{
		public Leg(Material material) : base(material, new Rectangle())
		{ }
		public Leg() : base(null, new Rectangle())
		{ }
	}
}
