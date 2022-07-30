using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V33
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
	public class Complemento
	{
		[XmlElement(Namespace = "http://www.sat.gob.mx/Pagos")]
		public Pagos Pagos { get; set; }
	}
}