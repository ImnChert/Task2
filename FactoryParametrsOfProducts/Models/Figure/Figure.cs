using System;

namespace FactoryParametrsOfProducts.Models.Figure
{
	/// <summary>
	/// Interface for describing shapes.
	/// </summary>
	public abstract class Figure
	{
		public string Name { get; set; }

		protected Figure(string name)
		{
			Name = name;
		}

		public override bool Equals(object obj)
		{
			return obj is Figure figure &&
				   Name == figure.Name;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Name);
		}
	}
}
