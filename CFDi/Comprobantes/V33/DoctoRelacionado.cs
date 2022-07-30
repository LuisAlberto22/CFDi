using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V33
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class DoctoRelacionado
    {
        [XmlAttribute]
        public string IdDocumento { get; set; }
        [XmlAttribute]
        public string MonedaDR { get; set; }
        [XmlAttribute]
        public string TipoCambioDR { get; set; }
        [XmlAttribute]
        public string MetodoDePagoDR { get; set; }
        [XmlAttribute]
        public string NumParcialidad { get; set; }
        [XmlAttribute]
        public string ImpSaldoAnt { get; set; }
        [XmlAttribute]
        public string ImpPagado { get; set; }
        [XmlAttribute]
        public string ImpSaldoInsoluto { get; set; }
    }
}