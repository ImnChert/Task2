using ProductTable.Models.PartOfTheTable;
using System;
using System.Collections.Generic;

namespace ProductTable.Models.ModelsTable
{
	/// <summary>
	/// Abstract description of the table.
	/// </summary>
	public abstract class Table
	{
		public Top Top { get; set; }
		public Leg Leg { get; set; }
		public Accessorie Accessorie { get; set; }
		public decimal Price { get; set; }
		public string Name { get; set; }

		public Table() { }
		protected Table(Top top, Leg leg, Accessorie accessorie, string name)
		{
			Top = top;
			Leg = leg;
			Accessorie = accessorie;
			Price = top.Price + leg.Price + accessorie.Price;
			Name = name;
		}

		public override bool Equals(object obj)
		{
			return obj is Table table &&
				   EqualityComparer<Top>.Default.Equals(Top, table.Top) &&
				   EqualityComparer<Leg>.Default.Equals(Leg, table.Leg) &&
				   EqualityComparer<Accessorie>.Default.Equals(Accessorie, table.Accessorie);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Top, Leg, Accessorie);
		}

		public override string ToString()
			=> $"На столешницу было потрачено: {Top.Price}, на ножку: {Leg.Price}, на фурнитуру {Accessorie.Price}";
	}
}
