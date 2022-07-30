using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System;
using CFDi.Comprobantes;

namespace CFDi.Serialization
{
	public class CFDiLoader
	{
		private XmlSerializer _serializer;

		public CFDiLoader(Type type, string @namespace)
		{
			_serializer = new XmlSerializer(type, @namespace);
		}

		public void SaveCFDi(string directoryPath, ComprobanteBase cfdi)
		{
			_serializer.Serialize(new StreamWriter(PathFormat(directoryPath, cfdi.GetXmlName())), cfdi);
		}


		public void SaveCFDi(Stream stream, ComprobanteBase cfdi)
		{
			_serializer.Serialize(stream, cfdi);
		}

		private string PathFormat(string directoryPath, string fileName)
		{
			return Path.Combine(directoryPath, fileName.EndsWith(".xml") ? fileName : fileName + ".xml");
		}

		public ComprobanteBase LoadCFDi(string directoryPath, string fileName)
		{
			try
			{
				string path = Path.Combine(directoryPath, fileName);
				using (var stream = new FileStream(directoryPath, FileMode.Open))
				{
					return LoadCFDi(stream);
				}
			}
			catch (InvalidOperationException)
			{
				return null;
			}
		}

		public ComprobanteBase LoadCFDi(Stream stream)
		{
			try
			{
				XmlReader reader = new XmlTextReader(stream);
				if (_serializer.CanDeserialize(reader))
				{
					return _serializer.Deserialize(reader) as ComprobanteBase;
				}
				throw new Exception();
			}
			catch (InvalidOperationException)
			{
				return null;
			}
		}
	}
}