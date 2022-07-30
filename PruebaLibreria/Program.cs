using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFDi.Comprobantes.V40;

namespace PruebaLibreria
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CFDi.AbstractCFDiFactory cFDiV40Factory = new CFDi.CFDiV40Factory();
			var cfdi = (Comprobante)cFDiV40Factory.CreateLoader().LoadCFDi(@"C:\Users\guich\OneDrive\Escritorio\pruebaComprobantes\FF0001168383 TRAJES INTERNACIONALES SA DE CV.xml");
		}
	}
}
