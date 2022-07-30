using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteImpuestos
	{
		private ComprobanteImpuestosRetencion[] retencionesField;

		private ComprobanteImpuestosTraslado[] trasladosField;

		private decimal totalImpuestosRetenidosField;

		private bool totalImpuestosRetenidosFieldSpecified;

		private decimal totalImpuestosTrasladadosField;

		private bool totalImpuestosTrasladadosFieldSpecified;

		[XmlArrayItem("Retencion", IsNullable = false)]
		public ComprobanteImpuestosRetencion[] Retenciones
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

		[XmlArrayItem("Traslado", IsNullable = false)]
		public ComprobanteImpuestosTraslado[] Traslados
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

		[XmlAttribute]
		public decimal TotalImpuestosRetenidos
		{
			get
			{
				return totalImpuestosRetenidosField;
			}
			set
			{
				totalImpuestosRetenidosField = value;
			}
		}

		[XmlIgnore]
		public bool TotalImpuestosRetenidosSpecified
		{
			get
			{
				return totalImpuestosRetenidosFieldSpecified;
			}
			set
			{
				totalImpuestosRetenidosFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public decimal TotalImpuestosTrasladados
		{
			get
			{
				return totalImpuestosTrasladadosField;
			}
			set
			{
				totalImpuestosTrasladadosField = value;
			}
		}

		[XmlIgnore]
		public bool TotalImpuestosTrasladadosSpecified
		{
			get
			{
				return totalImpuestosTrasladadosFieldSpecified;
			}
			set
			{
				totalImpuestosTrasladadosFieldSpecified = value;
			}
		}
	}
}