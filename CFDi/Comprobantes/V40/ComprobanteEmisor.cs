using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteEmisor
	{
		private string rfcField;

		private string nombreField;

		private string regimenFiscalField;

		private string facAtrAdquirenteField;

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
		public string RegimenFiscal
		{
			get
			{
				return regimenFiscalField;
			}
			set
			{
				regimenFiscalField = value;
			}
		}

		[XmlAttribute]
		public string FacAtrAdquirente
		{
			get
			{
				return facAtrAdquirenteField;
			}
			set
			{
				facAtrAdquirenteField = value;
			}
		}
	}
}