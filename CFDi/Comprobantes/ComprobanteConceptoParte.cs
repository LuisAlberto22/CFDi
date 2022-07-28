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
	public class ComprobanteConceptoParte
	{
		[XmlElement("InformacionAduanera")]
		public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera { get; set; }

		[XmlAttribute]
		public string ClaveProdServ { get; set; }

		[XmlAttribute]
		public string NoIdentificacion { get; set; }

		[XmlAttribute]
		public decimal Cantidad { get; set; }

		[XmlAttribute]
		public string Unidad { get; set; }

		[XmlAttribute]
		public string Descripcion { get; set; }

		[XmlAttribute]
		public decimal ValorUnitario { get; set; }

		[XmlIgnore]
		public bool ValorUnitarioSpecified{ get; set; }

		[XmlAttribute]
		public decimal Importe { get; set; }

		[XmlIgnore]
		public bool ImporteSpecified { get; set; }
	}
}