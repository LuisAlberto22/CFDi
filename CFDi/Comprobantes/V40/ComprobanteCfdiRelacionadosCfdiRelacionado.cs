using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteCfdiRelacionadosCfdiRelacionado
	{
		private string uUIDField;

		[XmlAttribute]
		public string UUID
		{
			get
			{
				return uUIDField;
			}
			set
			{
				uUIDField = value;
			}
		}
	}
}