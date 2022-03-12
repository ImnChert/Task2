using ProductTable.Models.ModelsTable;
using Company.Operations.Models;
using Company.Operations.Interfaces;
using FactoryParametrsOfProducts.Models.Material;
using ProductTable.Models.PartOfTheTable;
using System.Collections.Generic;
using Company.Machines.Models;
using FactoryParametrsOfProducts.Models.Figure;

namespace Company
{
	public class KitchenTableSubsystem : Subsystem
	{
		public KitchenTableSubsystem() : base(new Chipboard(1, 2, 3), new Chipboard(1, 2, 3))
		{ }

		public override Table OpetationOne(Chipboard chipboardSheetForLeg, Chipboard chipboardSheetForTop)
		{
			var machinRectangle = new MachineForRectangleShape();
			var instruction = InstructionForCreate();
			var supplier = new MySupplier();

			supplier.BuyPartOfTheTable(instruction.Item1);
			machinRectangle.Create(instruction.Item2, chipboardSheetForLeg);
			machinRectangle.Create(instruction.Item3, chipboardSheetForTop);

			return new KitchenTable(instruction.Item3, instruction.Item2, instruction.Item1);
		}

		protected override (Accessorie, Leg, Top) InstructionForCreate()
		{
			return (
				new Accessorie(new Metal(2, 3, 4), new Square()),
				new Leg(ChipboardForLeg),
				new Top(new Circle(), ChipboardForTop)
				);
		}

		public override List<IOperation> AvailableOperations()
		{
			return new List<IOperation>()
			{
				new Grinding(),
				new Varnishing()
			};
		}
	}
}
