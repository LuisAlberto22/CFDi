using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CFDi.Comprobantes
{
	[Serializable]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteInformacionGlobal
	{
		[XmlAttribute]
		public string Periodicidad { get; set; }
		[XmlAttribute]
		public string Meses{ get; set; }	
		[XmlAttribute]
		public short Año { get; set; }
	}
}