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
	public class ComprobanteConceptoImpuestos
	{
		[XmlArrayItem("Traslado", IsNullable = false)]
		public ComprobanteConceptoImpuestosTraslado[] Traslados { get; set; }

		[XmlArrayItem("Retencion", IsNullable = false)]
		public ComprobanteConceptoImpuestosRetencion[] Retenciones { get; set; }
	}
}