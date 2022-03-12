using FactoryParametrsOfProducts.Models.Figure;
using FactoryParametrsOfProducts.Models.Material;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductTable.Models;
using ProductTable.Models.ModelsTable;
using ProductTable.Models.PartOfTheTable;
using ProductTable.Services;
using System.Collections.Generic;

namespace UnitTests
{
	[TestClass]
	public class XMLTest
	{
		[TestMethod]
		public void XMLWriterAndXMLReader_ÑorrectExecution_AreEqual()
		{
			var table = new List<Table>
				{
					new KitchenTable(
						new Top(new Circle(), new Chipboard(1,2,3)),
						new Leg(new Chipboard(1,2,3)),
						new Accessorie(new Metal(2,3,4), new Square())
					)
				};

			var xml = new XML();
			xml.Writer(new CollectionTable(table));

			var collection = xml.Reader();
			Assert.AreEqual(collection.List[0], table[0]);
		}
	}
}
