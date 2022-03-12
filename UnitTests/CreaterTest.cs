using Company;
using FactoryParametrsOfProducts.Models;
using FactoryParametrsOfProducts.Models.Figure;
using FactoryParametrsOfProducts.Models.Material;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductTable.Models.ModelsTable;
using ProductTable.Models.PartOfTheTable;

namespace UnitTests
{
	[TestClass]
	public class CreaterTest
	{
		[TestMethod]
		public void NewTableTest_СorrectExecution_AreEqual()
		{
			var facade = new Facade(new KitchenTableSubsystem());
			var creator = new Creator(TestChipboardCollection());

			var table = new KitchenTable(
						new Top(new Circle(), new Chipboard(1, 2, 3)),
						new Leg(new Chipboard(1, 2, 3)),
						new Accessorie(new Metal(2, 3, 4), new Square())
					);
			var createTable = creator.CreateNewTable(facade);

			Assert.AreEqual(table, createTable);
		}

		private ChipboardCollection TestChipboardCollection()
		{
			var chipboard = new ChipboardCollection();
			chipboard.Add(new Chipboard(1, 2, 3));
			chipboard.Add(new Chipboard(4, 2, 5));
			chipboard.Add(new Chipboard(2, 4, 7));
			chipboard.Add(new Chipboard(3, 5, 6));
			chipboard.Add(new Chipboard(3, 3, 4));

			return chipboard;
		}
	}
}
