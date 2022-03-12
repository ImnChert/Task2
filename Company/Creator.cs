using ProductTable.Models.ModelsTable;
using FactoryParametrsOfProducts.Models;
using FactoryParametrsOfProducts.Models.Material;
using System.Linq;
using System;

namespace Company
{
	public class Creator
	{
		private ChipboardCollection _chipboards;

		public Creator(ChipboardCollection chipboards)
		{
			_chipboards = chipboards;
		}

		/// <summary>
		/// Creating a new table.
		/// </summary>
		/// <param name="facade">Facade class object.</param>
		/// <returns>New table.</returns>
		public Table CreateNewTable(Facade facade)
		{
			(Chipboard, Chipboard) chip = FindMaterial(facade);
			var table = facade.Operation(chip.Item2, chip.Item1);
			GarbageCleaning();

			return table;
		}

		/// <summary>
		/// Finding the right chipboard sheets for the leg and for the countertop.
		/// </summary>
		/// <param name="facade">Facade class object.</param>
		/// <returns>Chipboard sheets.</returns>
		/// <exception cref="Exception">Exception.</exception>
		private (Chipboard, Chipboard) FindMaterial(Facade facade)
		{
			if (facade.ChipboardForLeg != null && facade.ChipboardForTop != null)
			{
				var suitableChipboardTop = (from item in _chipboards.Collection
											where item.Width >= facade.ChipboardForTop.Width &&
											item.Depth >= facade.ChipboardForTop.Depth &&
											item.Lenght >= facade.ChipboardForTop.Lenght
											select item).ToList();

				Chipboard item1 = null;

				if (suitableChipboardTop != null)
				{
					item1 = suitableChipboardTop.Min();
					_chipboards.Collection.Remove(item1);
				}

				var suitableChipboardLeg = (from item in _chipboards.Collection
											where item.Width >= facade.ChipboardForLeg.Width &&
											item.Depth >= facade.ChipboardForLeg.Depth &&
											item.Lenght >= facade.ChipboardForLeg.Lenght
											select item).ToList();

				Chipboard item2 = null;

				if (suitableChipboardLeg != null)
				{
					item2 = suitableChipboardLeg.Min();
				}

				return (item1, item2);
			}

			return (null, null);
		}

		private void GarbageCleaning()
		{
			foreach (var chipboard in _chipboards.Collection)
			{
				if (chipboard.Depth <= 0 || chipboard.Width <= 0 || chipboard.Lenght <= 0)
				{
					_chipboards.Remove(chipboard);
				}
			}
		}
	}
}
