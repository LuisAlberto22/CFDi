using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteConceptoACuentaTerceros
	{
		private string rfcACuentaTercerosField;

		private string nombreACuentaTercerosField;

		private string regimenFiscalACuentaTercerosField;

		private string domicilioFiscalACuentaTercerosField;

		[XmlAttribute]
		public string RfcACuentaTerceros
		{
			get
			{
				return rfcACuentaTercerosField;
			}
			set
			{
				rfcACuentaTercerosField = value;
			}
		}

		[XmlAttribute]
		public string NombreACuentaTerceros
		{
			get
			{
				return nombreACuentaTercerosField;
			}
			set
			{
				nombreACuentaTercerosField = value;
			}
		}

		[XmlAttribute]
		public string RegimenFiscalACuentaTerceros
		{
			get
			{
				return regimenFiscalACuentaTercerosField;
			}
			set
			{
				regimenFiscalACuentaTercerosField = value;
			}
		}

		[XmlAttribute]
		public string DomicilioFiscalACuentaTerceros
		{
			get
			{
				return domicilioFiscalACuentaTercerosField;
			}
			set
			{
				domicilioFiscalACuentaTercerosField = value;
			}
		}
	}
}