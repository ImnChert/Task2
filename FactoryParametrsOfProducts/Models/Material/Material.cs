using System;

namespace FactoryParametrsOfProducts.Models.Material
{
	/// <summary>
	/// Interface for describing material.
	/// </summary>
	public abstract class Material : IComparable<Material>
	{
		public double Lenght { get; set; }
		public double Width { get; set; }
		public double Depth { get; set; }
		public string Name { get; }

		protected Material(string name)
		{
			Name = name;
		}

		protected Material(double lenght, double width, double depth, string name)
		{
			Lenght = lenght;
			Width = width;
			Depth = depth;
			Name = name;
		}

		public override bool Equals(object obj)
		{
			return obj is Material material &&
				   Lenght == material.Lenght &&
				   Width == material.Width &&
				   Depth == material.Depth &&
				   Name == material.Name;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Lenght, Width, Depth, Name);
		}

		public int CompareTo(Material other)
		{
			if (other == null)
				return 1;
			if (this.Depth + this.Lenght + this.Width >= other.Depth + other.Width + other.Lenght)
				return 1;
			return -1;
		}
	}
}
