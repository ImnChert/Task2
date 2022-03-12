using ProductTable.Interfaces;
using ProductTable.Models;
using ProductTable.Models.ModelsTable;
using ProductTable.Models.PartOfTheTable;
using System.Collections.Generic;
using System.Xml;

namespace ProductTable.Services
{
	public class XML : WorkingWithFiles
	{
		public XML() : base("test.xml")
		{ }

		public XML(string filename) : base(filename)
		{

		}

		public override CollectionTable Reader()
		{
			var list = new List<Table>();
			using var reader = XmlReader.Create(_filename);

			reader.ReadToFollowing("table");

			do
			{

				reader.MoveToFirstAttribute();

				Table table = SimpleFactory.SimpleFactroryTable(reader.Value);
				table.Name = reader.Value;

				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element)
					{
						switch (reader.Name)
						{
							case "Top":
								table.Top = new Top();
								XMLReadFormAndMaterial(table.Top, reader);
								break;
							case "Leg":
								table.Leg = new Leg();
								XMLReadFormAndMaterial(table.Leg, reader);
								break;
							case "Accessorie":
								table.Accessorie = new Accessorie();
								XMLReadFormAndMaterial(table.Accessorie, reader);
								break;
							case "Price":
								table.Price = reader.ReadElementContentAsDecimal();
								break;
							default:
								break;
						}
					}
				}

				list.Add(table);

			} while (reader.ReadToFollowing("table"));

			return new CollectionTable(list);
		}

		private void XMLReadFormAndMaterial(PartOfTheTable part, XmlReader reader)
		{
			reader.Read();
			reader.MoveToFirstAttribute();
			part.Figure = SimpleFactory.SimpleFactoryFigure(reader.Value);

			reader.Read();
			reader.MoveToFirstAttribute();
			part.Material = SimpleFactory.SimpleFactroryMaterial(reader.Value);

			reader.Read();
			part.Material.Depth = reader.ReadElementContentAsDouble();

			part.Material.Width = reader.ReadElementContentAsDouble();

			part.Material.Lenght = reader.ReadElementContentAsDouble();


			reader.Read();

		}

		public override void Writer(CollectionTable collection)
		{
			var xmlWriter = XmlWriter.Create(_filename);

			xmlWriter.WriteStartDocument();
			xmlWriter.WriteStartElement("tables");

			foreach (var table in collection.List)
			{
				xmlWriter.WriteStartElement("table");
				xmlWriter.WriteAttributeString("Name", table.Name);
				xmlWriter.WriteAttributeString("xmlns", "bk", null, "urn:abc");

				xmlWriter.WriteStartElement("Top");
				XMLWriteFormAndMaterial(table.Top, xmlWriter);
				xmlWriter.WriteEndElement();

				xmlWriter.WriteStartElement("Leg");
				XMLWriteFormAndMaterial(table.Leg, xmlWriter);
				xmlWriter.WriteEndElement();

				xmlWriter.WriteStartElement("Accessorie");
				XMLWriteFormAndMaterial(table.Accessorie, xmlWriter);
				xmlWriter.WriteEndElement();

				xmlWriter.WriteStartElement("Price");
				xmlWriter.WriteString(XmlConvert.ToString(table.Price));
				xmlWriter.WriteEndElement();

				xmlWriter.WriteEndElement();

			}

			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		private void XMLWriteFormAndMaterial(PartOfTheTable part, XmlWriter xmlWriter)
		{
			xmlWriter.WriteStartElement("Figure");
			xmlWriter.WriteAttributeString("Name", part.Figure.Name);
			xmlWriter.WriteEndElement();

			xmlWriter.WriteStartElement("Material");
			xmlWriter.WriteAttributeString("Type", part.Material.Name);

			xmlWriter.WriteStartElement("Depth");
			xmlWriter.WriteString(XmlConvert.ToString(part.Material.Depth));
			xmlWriter.WriteEndElement();

			xmlWriter.WriteStartElement("Width");
			xmlWriter.WriteString(XmlConvert.ToString(part.Material.Width));
			xmlWriter.WriteEndElement();

			xmlWriter.WriteStartElement("Lenght");
			xmlWriter.WriteString(XmlConvert.ToString(part.Material.Lenght));
			xmlWriter.WriteEndElement();

			xmlWriter.WriteEndElement();
		}
	}
}
