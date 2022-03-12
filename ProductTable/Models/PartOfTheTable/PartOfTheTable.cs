using FactoryParametrsOfProducts.Models.Figure;
using FactoryParametrsOfProducts.Models.Material;
using System;
using System.Collections.Generic;

namespace ProductTable.Interfaces
{
	/// <summary>
	/// Description of the table part.
	/// </summary>
	public abstract class PartOfTheTable
	{
		public Material Material { get; set; }
		public Figure Figure { get; set; }
		public decimal Price { get; set; }

		protected PartOfTheTable(Material material, Figure figure)
		{
			Material = material;
			Figure = figure;
		}

		public override bool Equals(object obj)
		{
			return obj is PartOfTheTable table &&
				   EqualityComparer<Material>.Default.Equals(Material, table.Material) &&
				   EqualityComparer<Figure>.Default.Equals(Figure, table.Figure);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Material, Figure);
		}
	}
}