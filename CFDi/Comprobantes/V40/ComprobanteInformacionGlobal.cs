using System;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteInformacionGlobal
	{
		private string mesesField;

		private short añoField;

		private string periodicidadField;

		[XmlAttribute]
		public string Periodicidad
		{
			get
			{
				return periodicidadField;
			}
			set
			{
				periodicidadField = value;
			}
		}

		[XmlAttribute]
		public string Meses
		{
			get
			{
				return mesesField;
			}
			set
			{
				mesesField = value;
			}
		}

		[XmlAttribute]
		public short Año
		{
			get
			{
				return añoField;
			}
			set
			{
				añoField = value;
			}
		}
	}
}