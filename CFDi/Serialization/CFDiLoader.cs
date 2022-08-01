using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System;
using CFDi.Comprobantes;
using CFDi.Exception;

namespace CFDi.Serialization
{
	public class CFDiLoader
	{
		private XmlSerializer _serializer;
		public readonly int version;
		public readonly string @namespace;
		public CFDiLoader(Type type, string @namespace, int version)
		{
			_serializer = new XmlSerializer(type, @namespace);
			this.version = version;
			this.@namespace = @namespace;
		}

		public void SaveCFDi(string directoryPath, ComprobanteBase cfdi)
		{
			_serializer.Serialize(new StreamWriter(PathFormat(directoryPath, cfdi.GetXmlName())), cfdi);
		}


		public void SaveCFDi(XmlWriter stream, ComprobanteBase cfdi)
		{
			_serializer.Serialize(stream, cfdi);
		}

		private string PathFormat(string directoryPath, string fileName)
		{
			return Path.Combine(directoryPath, fileName.EndsWith(".xml") ? fileName : fileName + ".xml");
		}

		public ComprobanteBase LoadCFDi(string directoryPath, string fileName)
		{
			string path = Path.Combine(directoryPath, fileName);
			using (var stream = new FileStream(path, FileMode.Open))
			{
				return LoadCFDi(stream);
			}
		}

		public ComprobanteBase LoadCFDi(Stream stream)
		{
			XmlReader reader = new XmlTextReader(stream);
			return _serializer.Deserialize(reader) as ComprobanteBase;
		}
	}
}