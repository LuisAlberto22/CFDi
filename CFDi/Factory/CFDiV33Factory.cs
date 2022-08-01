using CFDi.Comprobantes;
using CFDi.Serialization;
using CFDi.Comprobantes.V33;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFDi.Factory
{
	public class CFDiV33Factory : AbstractCFDiFactory
	{
		public override ComprobanteBase CreateCFDi()
		{
			return new Comprobante(); 
		}

		public override CFDiLoader CreateLoader()
		{
			return new CFDiLoader(typeof(Comprobante), "http://www.sat.gob.mx/cfd/3",3);
		}
	}
}