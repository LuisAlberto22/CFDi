using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CFDi.Comprobantes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteReceptor
	{
		[XmlAttribute]
		public string Rfc { get; set; }

		[XmlAttribute]
		public string Nombre { get; set; }

		[XmlAttribute]
		public string DomicilioFiscalReceptor { get; set; }

		[XmlAttribute]
		public string ResidenciaFiscal { get; set; }

		[XmlIgnore]
		public bool ResidenciaFiscalSpecified { get; set; }

		[XmlAttribute]
		public string NumRegIdTrib { get; set; }

		[XmlAttribute]
		public string RegimenFiscalReceptor { get; set; }

		[XmlAttribute]
		public string UsoCFDI { get; set; }
	}
}