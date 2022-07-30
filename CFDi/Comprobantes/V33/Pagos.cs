using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V33
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Pago
    {
        [XmlAttribute]
        public string FechaPago { get; set; }
        [XmlAttribute]
        public string FormaDePagoP { get; set; }
        [XmlAttribute]
        public string MonedaP { get; set; }
        [XmlAttribute]
        public string Monto { get; set; }
        [XmlAttribute]
        public string RfcEmisorCtaOrd { get; set; }
        [XmlAttribute]
        public string CtaOrdenante { get; set; }
        [XmlAttribute]
        public string RfcEmisorCtaBen { get; set; }
        [XmlAttribute]
        public string CtaBeneficiario { get; set; }

        //[XmlArrayItem("DoctoRelacionado")]
        [XmlElement("DoctoRelacionado")]
        public List<DoctoRelacionado> DoctoRelacionado { get; set; }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Pagos
    {
        [XmlAttribute]
        public string Version { get; set; }
        [XmlElement("Pago")]
        public List<Pago> Pago { get; set; }

        public Pagos()
        {
            Version = "1.0";
        }
    }
}