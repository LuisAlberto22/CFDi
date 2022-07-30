using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteConceptoImpuestos
	{
		private ComprobanteConceptoImpuestosTraslado[] trasladosField;

		private ComprobanteConceptoImpuestosRetencion[] retencionesField;

		[XmlArrayItem("Traslado", IsNullable = false)]
		public ComprobanteConceptoImpuestosTraslado[] Traslados
		{
			get
			{
				return trasladosField;
			}
			set
			{
				trasladosField = value;
			}
		}

		[XmlArrayItem("Retencion", IsNullable = false)]
		public ComprobanteConceptoImpuestosRetencion[] Retenciones
		{
			get
			{
				return retencionesField;
			}
			set
			{
				retencionesField = value;
			}
		}
	}
}