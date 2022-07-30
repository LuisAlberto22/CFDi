using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteCfdiRelacionados
	{
		private ComprobanteCfdiRelacionadosCfdiRelacionado[] cfdiRelacionadoField;

		private string tipoRelacionField;

		[XmlElement("CfdiRelacionado")]
		public ComprobanteCfdiRelacionadosCfdiRelacionado[] CfdiRelacionado
		{
			get
			{
				return cfdiRelacionadoField;
			}
			set
			{
				cfdiRelacionadoField = value;
			}
		}

		[XmlAttribute]
		public string TipoRelacion
		{
			get
			{
				return tipoRelacionField;
			}
			set
			{
				tipoRelacionField = value;
			}
		}
	}
}