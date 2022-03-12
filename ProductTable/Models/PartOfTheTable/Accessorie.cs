using FactoryParametrsOfProducts.Models.Material;
using FactoryParametrsOfProducts.Models.Figure;

namespace ProductTable.Models.PartOfTheTable
{
	/// <summary>
	/// Description of accessories.
	/// </summary>
	public class Accessorie : Interfaces.PartOfTheTable
	{
		public Accessorie(Metal material, Square figure) : base(material, figure)
		{ }
		public Accessorie() : base(null, null)
		{ }
	}
}
