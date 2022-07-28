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
	public class ComprobanteConceptoImpuestosRetencion
	{
		[XmlAttribute]
		public string Impuesto { get; set; }

		[XmlAttribute]
		public decimal Importe { get; set; }
		[XmlAttribute]
		public decimal Base { get; set; }

		[XmlAttribute]
		public string TipoFactor { get; set; }

		[XmlAttribute]
		public decimal TasaOCuota { get; set; }
	}
}