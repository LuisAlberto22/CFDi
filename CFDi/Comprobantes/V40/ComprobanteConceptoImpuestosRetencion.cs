using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteConceptoImpuestosRetencion
	{
		private decimal baseField;

		private string impuestoField;

		private string tipoFactorField;

		private decimal tasaOCuotaField;

		private decimal importeField;

		[XmlAttribute]
		public decimal Base
		{
			get
			{
				return baseField;
			}
			set
			{
				baseField = value;
			}
		}

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
		public string TipoFactor
		{
			get
			{
				return tipoFactorField;
			}
			set
			{
				tipoFactorField = value;
			}
		}

		[XmlAttribute]
		public decimal TasaOCuota
		{
			get
			{
				return tasaOCuotaField;
			}
			set
			{
				tasaOCuotaField = value;
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