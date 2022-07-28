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
	public class ComprobanteConceptoACuentaTerceros
	{
		[XmlAttribute]
		public string RfcACuentaTerceros { get; set; }

		[XmlAttribute]
		public string NombreACuentaTerceros { get; set; }

		[XmlAttribute]
		public string RegimenFiscalACuentaTerceros { get; set; }

		[XmlAttribute]
		public string DomicilioFiscalACuentaTerceros { get; set; }
	}
}