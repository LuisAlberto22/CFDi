using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteReceptor
	{
		private string rfcField;

		private string nombreField;

		private string domicilioFiscalReceptorField;

		private string residenciaFiscalField;

		private bool residenciaFiscalFieldSpecified;

		private string numRegIdTribField;

		private string regimenFiscalReceptorField;

		private string usoCFDIField;

		[XmlAttribute]
		public string Rfc
		{
			get
			{
				return rfcField;
			}
			set
			{
				rfcField = value;
			}
		}

		[XmlAttribute]
		public string Nombre
		{
			get
			{
				return nombreField;
			}
			set
			{
				nombreField = value;
			}
		}

		[XmlAttribute]
		public string DomicilioFiscalReceptor
		{
			get
			{
				return domicilioFiscalReceptorField;
			}
			set
			{
				domicilioFiscalReceptorField = value;
			}
		}

		[XmlAttribute]
		public string ResidenciaFiscal
		{
			get
			{
				return residenciaFiscalField;
			}
			set
			{
				residenciaFiscalField = value;
			}
		}

		[XmlIgnore]
		public bool ResidenciaFiscalSpecified
		{
			get
			{
				return residenciaFiscalFieldSpecified;
			}
			set
			{
				residenciaFiscalFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public string NumRegIdTrib
		{
			get
			{
				return numRegIdTribField;
			}
			set
			{
				numRegIdTribField = value;
			}
		}

		[XmlAttribute]
		public string RegimenFiscalReceptor
		{
			get
			{
				return regimenFiscalReceptorField;
			}
			set
			{
				regimenFiscalReceptorField = value;
			}
		}

		[XmlAttribute]
		public string UsoCFDI
		{
			get
			{
				return usoCFDIField;
			}
			set
			{
				usoCFDIField = value;
			}
		}
	}
}