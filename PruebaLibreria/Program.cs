using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFDi;

namespace PruebaLibreria
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CFDi.Serialization.CFDiSerializer cFDiSerializer = new CFDi.Serialization.CFDiSerializer();
			var cfdi = cFDiSerializer.DeSerialize(@"C:\Users\guich\OneDrive\Escritorio\pruebaComprobantes\REPR0000001435 ZENTRIX INDUSTRIES LIMITED.xml");
			Console.WriteLine(cfdi.Folio);
		}
	}
}
