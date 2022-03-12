using FactoryParametrsOfProducts.Models.Material;
using System.Collections.Generic;

namespace FactoryParametrsOfProducts.Models
{
	/// <summary>
	/// Collection of chipboard.
	/// </summary>
	public class ChipboardCollection
	{
		public List<Chipboard> Collection;

		public ChipboardCollection()
			=> Collection = new List<Chipboard>();

		/// <summary>
		/// Adding a new chipboard.
		/// </summary>
		/// <param name="chipboard">New chipboard.</param>
		public void Add(Chipboard chipboard)
			=> Collection.Add(chipboard);

		/// <summary>
		/// Removing the chipboard.
		/// </summary>
		/// <param name="chipboard">Chipboard for removal.</param>
		public void Remove(Chipboard chipboard)
			=> Collection.Remove(chipboard);
	}
}
