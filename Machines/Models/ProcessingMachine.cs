using System;

namespace Machines.Models
{
	public abstract class ProcessingMachine
	{
		public decimal Prica()
		{
			return IFigure + IMaterial;
		}
	}
}
