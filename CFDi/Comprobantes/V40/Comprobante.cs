using System;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	[XmlRoot(Namespace = "http://www.sat.gob.mx/cfd/4", IsNullable = false)]
	public class Comprobante : ComprobanteBase
	{
		private ComprobanteInformacionGlobal _informacionGlobal = new ComprobanteInformacionGlobal();
		private ComprobanteCfdiRelacionados[] _cfdiRelacionados;
		private ComprobanteEmisor _emisor = new ComprobanteEmisor();
		private ComprobanteReceptor _receptor;
		private ComprobanteConcepto[] _conceptos;
		private ComprobanteImpuestos _impuestos;
		private ComprobanteComplemento _complemento;
		private ComprobanteAddenda _addenda;
		private bool _formaPagoSpecified;
		private bool _descuentoSpecified;
		private bool _tipoCambioSpecified;
		private string _exportacion;
		private bool _metodoPagoSpecified;

		public Comprobante()
		{
			Version = "4.0";
		}

		public ComprobanteInformacionGlobal InformacionGlobal
		{
			get
			{
				return _informacionGlobal;
			}
			set
			{
				_informacionGlobal = value;
			}
		}

		public ComprobanteCfdiRelacionados[] CfdiRelacionados
		{
			get
			{
				return _cfdiRelacionados;
			}
			set
			{
				_cfdiRelacionados = value;
			}
		}

		public ComprobanteEmisor Emisor
		{
			get
			{
				return _emisor;
			}
			set
			{
				_emisor = value;
			}
		}

		public ComprobanteReceptor Receptor
		{
			get
			{
				return _receptor;
			}
			set
			{
				_receptor = value;
			}
		}

		[XmlArrayItem("Concepto", IsNullable = false)]
		public ComprobanteConcepto[] Conceptos
		{
			get
			{
				return _conceptos;
			}
			set
			{
				_conceptos = value;
			}
		}

		public ComprobanteImpuestos Impuestos
		{
			get
			{
				return _impuestos;
			}
			set
			{
				_impuestos = value;
			}
		}

		public ComprobanteComplemento Complemento
		{
			get
			{
				return _complemento;
			}
			set
			{
				_complemento = value;
			}
		}

		public ComprobanteAddenda Addenda
		{
			get
			{
				return _addenda;
			}
			set
			{
				_addenda = value;
			}
		}

		[XmlIgnore]
		public bool FormaPagoSpecified
		{
			get
			{
				return _formaPagoSpecified;
			}
			set
			{
				_formaPagoSpecified = value;
			}
		}

		[XmlIgnore]
		public bool DescuentoSpecified
		{
			get
			{
				return _descuentoSpecified;
			}
			set
			{
				_descuentoSpecified = value;
			}
		}

		[XmlIgnore]
		public bool TipoCambioSpecified
		{
			get
			{
				return _tipoCambioSpecified;
			}
			set
			{
				_tipoCambioSpecified = value;
			}
		}

		[XmlAttribute]
		public string Exportacion
		{
			get
			{
				return _exportacion;
			}
			set
			{
				_exportacion = value;
			}
		}


		[XmlIgnore]
		public bool MetodoPagoSpecified
		{
			get
			{
				return _metodoPagoSpecified;
			}
			set
			{
				_metodoPagoSpecified = value;
			}
		}

		public override string GetXmlName()
		{
			return $"{Folio} {Emisor.Nombre}.xml";
		}
	}
}
