namespace FactoryParametrsOfProducts.Models.Material
{
	/// <summary>
	/// A class implementing a metal.
	/// </summary>
	public class Metal : Material
	{
		public Metal() : base("Metal")
		{ }

		public Metal(double lenght, double width, double depth) : base(lenght, width, depth, "Metal")
		{
		}
	}
}
