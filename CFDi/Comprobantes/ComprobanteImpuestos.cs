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
	public class ComprobanteImpuestos
	{

		[XmlArrayItem("Retencion", IsNullable = false)]
		public ComprobanteConceptoImpuestosRetencion[] Retenciones { get; set; }

		[XmlArrayItem("Traslado", IsNullable = false)]
		public ComprobanteConceptoImpuestosTraslado[] Traslados{ get; set; }
		
		[XmlAttribute]
		public decimal TotalImpuestosRetenidos { get; set; }

		[XmlIgnore]
		public bool TotalImpuestosRetenidosSpecified { get; set; }
		[XmlAttribute]
		public decimal TotalImpuestosTrasladados { get; set; }

		[XmlIgnore]
		public bool TotalImpuestosTrasladadosSpecified { get; set; }
	}
}