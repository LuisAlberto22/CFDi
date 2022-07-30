using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteImpuestosRetencion
	{
		private string impuestoField;

		private decimal importeField;

		[XmlAttribute]
		public string Impuesto
		{
			get
			{
				return impuestoField;
			}
			set
			{
				impuestoField = value;
			}
		}

		[XmlAttribute]
		public decimal Importe
		{
			get
			{
				return importeField;
			}
			set
			{
				importeField = value;
			}
		}
	}
}