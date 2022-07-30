using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V33
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Traslado
    {
        [XmlAttribute]
        public string Base { get; set; }
        [XmlAttribute]
        public string Impuesto { get; set; }
        [XmlAttribute]
        public string TipoFactor { get; set; }
        [XmlAttribute]
        public string TasaOCuota { get; set; }
        [XmlAttribute]
        public double Importe { get; set; }
    }
}