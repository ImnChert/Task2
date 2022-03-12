using FactoryParametrsOfProducts.Models.Figure;
using FactoryParametrsOfProducts.Models.Material;

namespace ProductTable.Models.PartOfTheTable
{
	/// <summary>
	/// Description of top.
	/// </summary>
	public class Top : Interfaces.PartOfTheTable
	{
		public Top(Figure figure, Chipboard material) : base(material, figure)
		{ }

		public Top() : base(new Chipboard(), null)
		{ }
	}
}
