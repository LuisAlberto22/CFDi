
using System.Xml.Serialization;
using System.IO;

namespace CFDi.Serialization
{
	public class CFDiSerializer
	{
		private XmlSerializer _serializer;

		public CFDiSerializer()
		{
			_serializer = new XmlSerializer(typeof(CFDi), "http://www.sat.gob.mx/cfd/4");
		}

		public void Serialize(string path, CFDi cfdi)
		{
			_serializer.Serialize(new StreamWriter(path), cfdi);
		}

		public void Serialize(TextWriter stream, CFDi cfdi)
		{
			_serializer.Serialize(stream, cfdi);
		}

		public CFDi DeSerialize(string path)
		{
			try
			{
				using (var stream = new FileStream(path, FileMode.Open))
				{
					return _serializer.Deserialize(stream) as CFDi;
				}
			}
			catch
			{
				return null;
			}
		}

		public CFDi DeSerialize(TextReader stream)
		{
			return _serializer.Deserialize(stream) as CFDi;
		}
	}
}