using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using CFDi.Comprobantes;

namespace CFDi
{
	[Serializable]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	[XmlRoot(Namespace = "http://www.sat.gob.mx/cfd/4", IsNullable = false)]
	public class CFDi
	{
		public ComprobanteInformacionGlobal InformacionGlobal { get; set; } = new ComprobanteInformacionGlobal();
		public  ComprobanteCfdiRelacionados[] CfdiRelacionados { get; set; }
		public  ComprobanteEmisor Emisor { get; set; } = new ComprobanteEmisor();
		public  ComprobanteReceptor Receptor { get; set; }
		[XmlArrayItem("Concepto", IsNullable = false)]
		public  ComprobanteConcepto[] Conceptos { get; set; }
		public  ComprobanteImpuestos Impuestos { get; set; }
		public  ComprobanteComplemento Complemento { get; set; }
		public  ComprobanteAddenda Addenda { get; set; }

		[XmlAttribute] public string Version { get; set; } = "4";
		[XmlAttribute] public string Serie { get; set; }
		[XmlAttribute] public string Folio { get; set; }
		[XmlAttribute] public DateTime Fecha { get; set; }
		[XmlAttribute] public string Sello { get; set; }
		[XmlAttribute] public string FormaPago { get; set; }
		[XmlIgnore] public bool FormaPagoSpecified { get; set; }
		[XmlAttribute] public string NoCertificado { get; set; }
		[XmlAttribute] public string Certificado { get; set; }
		[XmlAttribute] public string CondicionesPago { get; set; }
		[XmlAttribute] public decimal SubTotal { get; set; }
		[XmlAttribute] public decimal Descuento { get; set; }
		[XmlIgnore] public bool DescuentoSpecified { get; set; }
		[XmlAttribute] public string Moneda { get; set; }
		[XmlAttribute] public decimal TipoCambio { get; set; }
		[XmlIgnore] public bool TipoCambioSpecified { get; set; }
		[XmlAttribute] public decimal Total { get; set; }
		[XmlAttribute] public string TipoDeComprobante { get; set; }
		[XmlAttribute] public string Exportacion { get; set; }
		[XmlAttribute] public string MetodoPago { get; set; }
		[XmlIgnore] public bool MetodoPagoSpecified { get; set; }
		[XmlAttribute] public string LugarExpedicion { get; set; }
		[XmlAttribute] public string Confirmacion { get; set; }
	}
}