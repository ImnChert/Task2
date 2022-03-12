using FactoryParametrsOfProducts.Models.Figure;
using FactoryParametrsOfProducts.Models.Material;
using ProductTable.Models.ModelsTable;
using System;

namespace ProductTable.Services
{
	internal class SimpleFactory
	{
		public static Table SimpleFactroryTable(string value)
		{
			if (value == "KitchenTable")
				return new KitchenTable();
			throw new Exception("ERROR");
		}

		public static Figure SimpleFactoryFigure(string value)
		{
			if (value == "Circle")
				return new Circle();
			else if (value == "Rectangle")
				return new Rectangle();
			else if (value == "Square")
				return new Square();
			throw new Exception("ERROR");
		}

		public static Material SimpleFactroryMaterial(string value)
		{
			if (value == "Metal")
				return new Metal();
			else if (value == "Chipboard")
				return new Chipboard();
			throw new Exception("ERROR");
		}
	}
}
