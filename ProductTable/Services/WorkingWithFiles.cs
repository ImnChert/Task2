using ProductTable.Models;

namespace ProductTable.Services
{
	public abstract class WorkingWithFiles
	{
		protected string _filename;

		public WorkingWithFiles(string filename)
		{
			_filename = filename;
		}

		public abstract CollectionTable Reader();

		public abstract void Writer(CollectionTable collection);
	}
}
