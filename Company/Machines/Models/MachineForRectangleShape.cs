using FactoryParametrsOfProducts.Models.Figure;

namespace Company.Machines.Models
{
	/// <summary>
	/// Machine for processing rectangle shapes.
	/// </summary>
	internal class MachineForRectangleShape : ProcessingMachine
	{
		public MachineForRectangleShape() : base(new Rectangle())
		{ }
	}
}
