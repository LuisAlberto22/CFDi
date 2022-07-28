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
	public class ComprobanteConcepto
	{
		private decimal valorUnitarioField;

		private decimal importeField;

		public ComprobanteConceptoImpuestos Impuestos { get; set; }

		public ComprobanteConceptoACuentaTerceros ACuentaTerceros { get; set; }

		[XmlElement("InformacionAduanera")]
		public ComprobanteConceptoInformacionAduanera[] InformacionAduanera { get; set; }

		[XmlElement("CuentaPredial")]
		public ComprobanteConceptoCuentaPredial[] CuentaPredial { get; set; }
		public ComprobanteConceptoComplementoConcepto ComplementoConcepto { get; set; }
		[XmlElement("Parte")]
		public ComprobanteConceptoParte[] Parte { get; set; }
		[XmlAttribute]
		public string ClaveProdServ { get; set; }

		[XmlAttribute]
		public string NoIdentificacion { get; set; }

		[XmlAttribute]
		public decimal Cantidad { get; set; }

		[XmlAttribute]
		public string ClaveUnidad { get; set; }

		[XmlAttribute]
		public string Unidad { get; set; }

		[XmlAttribute]
		public string Descripcion { get; set; }

		[XmlAttribute]
		public decimal ValorUnitario { get => valorUnitarioField; set => valorUnitarioField = decimal.Parse(value.ToString("###,###,###0.00")); }

		[XmlAttribute]
		public decimal Importe { get => importeField; set => importeField = decimal.Parse(value.ToString("###,###,###0.00")); }

		[XmlAttribute]
		public decimal Descuento { get; set; }

		[XmlIgnore]
		public bool DescuentoSpecified { get; set; }

		[XmlAttribute]
		public string ObjetoImp { get; set; }
	}
}
