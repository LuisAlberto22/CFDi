using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V40
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
	public class ComprobanteConceptoParte
	{
		private ComprobanteConceptoParteInformacionAduanera[] informacionAduaneraField;

		private string claveProdServField;

		private string noIdentificacionField;

		private decimal cantidadField;

		private string unidadField;

		private string descripcionField;

		private decimal valorUnitarioField;

		private bool valorUnitarioFieldSpecified;

		private decimal importeField;

		private bool importeFieldSpecified;

		[XmlElement("InformacionAduanera")]
		public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera
		{
			get
			{
				return informacionAduaneraField;
			}
			set
			{
				informacionAduaneraField = value;
			}
		}

		[XmlAttribute]
		public string ClaveProdServ
		{
			get
			{
				return claveProdServField;
			}
			set
			{
				claveProdServField = value;
			}
		}

		[XmlAttribute]
		public string NoIdentificacion
		{
			get
			{
				return noIdentificacionField;
			}
			set
			{
				noIdentificacionField = value;
			}
		}

		[XmlAttribute]
		public decimal Cantidad
		{
			get
			{
				return cantidadField;
			}
			set
			{
				cantidadField = value;
			}
		}

		[XmlAttribute]
		public string Unidad
		{
			get
			{
				return unidadField;
			}
			set
			{
				unidadField = value;
			}
		}

		[XmlAttribute]
		public string Descripcion
		{
			get
			{
				return descripcionField;
			}
			set
			{
				descripcionField = value;
			}
		}

		[XmlAttribute]
		public decimal ValorUnitario
		{
			get
			{
				return valorUnitarioField;
			}
			set
			{
				valorUnitarioField = value;
			}
		}

		[XmlIgnore]
		public bool ValorUnitarioSpecified
		{
			get
			{
				return valorUnitarioFieldSpecified;
			}
			set
			{
				valorUnitarioFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public decimal Importe
		{
			get
			{
				return importeField;
			}
			set
			{
				importeField = value;
			}
		}

		[XmlIgnore]
		public bool ImporteSpecified
		{
			get
			{
				return importeFieldSpecified;
			}
			set
			{
				importeFieldSpecified = value;
			}
		}
	}
}