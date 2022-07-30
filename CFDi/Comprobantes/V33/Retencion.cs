using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CFDi.Comprobantes.V33
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Retencion
    {
        public double Base { get; set; }
        public string Impuesto { get; set; }
        public string TipoFactor { get; set; }
        public double TasaOCuota { get; set; }
        public double Importe { get; set; }
    }
}