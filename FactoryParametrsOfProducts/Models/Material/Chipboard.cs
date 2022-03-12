namespace FactoryParametrsOfProducts.Models.Material
{
	/// <summary>
	/// A class implementing a chipboard.
	/// </summary>
	public class Chipboard : Material
	{
		public Chipboard() : base("Chipboard")
		{ }

		public Chipboard(double lenght, double width, double depth) : base(lenght, width, depth, "Chipboard")
		{
		}
	}
}
