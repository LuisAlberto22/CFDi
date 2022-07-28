using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CFDi.Comprobantes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteConceptoComplementoConcepto
	{
		[XmlAnyElement]
		public XmlElement[] Any { get; set; }
	}
}