using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CFDi.Comprobantes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteCfdiRelacionados
	{
		[XmlAttribute] public string Periodicidad {get;set;}
		[XmlAttribute] public string Meses {get;set;}
		[XmlAttribute] public short Año{ get; set; }
	}
}