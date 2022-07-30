using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V33
{
    [Serializable]
    [DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Concepto
    {
        [XmlAttribute]
        public string ClaveProdServ { get; set; }
        [XmlAttribute]
        public string Cantidad { get; set; }
        [XmlAttribute]
        public string Unidad { get; set; }
        [XmlAttribute]
        public string ClaveUnidad { get; set; }
        [XmlAttribute]
        public string Descripcion { get; set; }
        [XmlAttribute]
        public string ValorUnitario { get; set; }
        [XmlAttribute]
        public string Importe { get; set; }
        [XmlAttribute]
        public string NoIdentificacion { get; set; }
        [XmlElement]
        public Impuestos Impuestos { get; set; }
    }
}