using CFDi.Comprobantes;
using CFDi.Serialization;
using System;
using CFDi.Comprobantes.V40;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFDi
{
	public class CFDiV40Factory : AbstractCFDiFactory
	{
		public override ComprobanteBase CreateCFDi()
		{
			return new Comprobante();
		}

		public override CFDiLoader CreateLoader()
		{
			return new CFDiLoader(typeof(Comprobante), "http://www.sat.gob.mx/cfd/4");
		}
	}
}