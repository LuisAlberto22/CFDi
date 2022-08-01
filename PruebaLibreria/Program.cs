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
			CFDi.Factory.AbstractCFDiFactory cFDiV40Factory = new CFDi.Factory.CFDiV33Factory();
			var cfdi = (Comprobante)cFDiV40Factory.CreateLoader().LoadCFDi(@"C:\Users\guich\OneDrive\Escritorio\pruebaComprobantes", "BB0000020691.xml");
		}
	}
}
