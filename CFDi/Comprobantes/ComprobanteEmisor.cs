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
	public class ComprobanteEmisor
	{

		[XmlAttribute]
		public string Rfc { get; set; }

		[XmlAttribute]
		public string Nombre { get; set; }

		[XmlAttribute]
		public string RegimenFiscal { get; set; }

		[XmlAttribute]
		public string FacAtrAdquirente { get; set; }
	}
}