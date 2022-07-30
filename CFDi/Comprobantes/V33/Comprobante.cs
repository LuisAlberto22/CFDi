using CFDi.Comprobantes.V40;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V33
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    [XmlRoot("Comprobante", Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Comprobante : ComprobanteBase
    {   

        public Comprobante()
		{
            Version = "3.3";
		}

        [XmlElement]
        public Emisor Emisor { get; set; }
        [XmlElement]
        public Receptor Receptor { get; set; }

        [XmlArray("Conceptos"), XmlArrayItem("Concepto")]
        public Concepto[] Conceptos { get; set; }

        [XmlElement]
        public Complemento Complemento { get; set; }

        [XmlElement]
        public Impuestos Impuestos { get; set; }

		public override string GetXmlName()
		{
            return $"{Folio} {Receptor.Nombre}.xml";
		}
	}
}
