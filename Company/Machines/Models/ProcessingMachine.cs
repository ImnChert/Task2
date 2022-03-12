using FactoryParametrsOfProducts.Models.Figure;
using FactoryParametrsOfProducts.Models.Material;
using ProductTable.Interfaces;
using System;

namespace Company.Machines.Models
{
	/// <summary>
	/// Abstract implementation of the machine.
	/// </summary>
	public abstract class ProcessingMachine
	{
		protected Figure figure;

		public ProcessingMachine(Figure figure) => this.figure = figure;

		/// <summary>
		/// Drinking part of the table.
		/// </summary>
		/// <param name="part">Part of the table</param>
		/// <param name="material">Material for the part</param>
		/// <exception cref="Exception">Unexpected error.</exception>
		public void Create(PartOfTheTable part, Material material)
		{
			if (part.Figure.Name == figure.Name)
			{
				material.Depth -= part.Material.Depth;
				material.Width -= part.Material.Width;
				material.Lenght -= part.Material.Lenght;
			}
		}
	}
}
