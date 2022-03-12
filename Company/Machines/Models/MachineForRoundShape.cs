using FactoryParametrsOfProducts.Models.Figure;

namespace Company.Machines.Models
{
	/// <summary>
	/// Machine for processing round shapes.
	/// </summary>
	internal class MachineForRoundShape : ProcessingMachine
	{
		public MachineForRoundShape() : base(new Circle())
		{ }
	}
}
