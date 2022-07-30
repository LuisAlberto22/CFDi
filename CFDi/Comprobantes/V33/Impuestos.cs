using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V33
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Impuestos
    {
        [XmlAttribute]
        public string TotalImpuestosTrasladados { get; set; }
        [XmlArray("Traslados"), XmlArrayItem("Traslado")]
        public Traslado[] Traslado { get; set; }
        [XmlArray("Retenciones"), XmlArrayItem("Retencion")]
        public Retencion[] Retencion { get; set; }
    }
}