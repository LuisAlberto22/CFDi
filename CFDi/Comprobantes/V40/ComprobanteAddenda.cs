using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteAddenda
	{
		private XmlElement[] _any;

		[XmlAnyElement]
		public XmlElement[] Any
		{
			get
			{
				return _any;
			}
			set
			{
				_any = value;
			}
		}
	}
}