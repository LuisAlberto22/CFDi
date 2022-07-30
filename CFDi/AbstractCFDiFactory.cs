using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CFDi.Comprobantes;

namespace CFDi
{
	public abstract class AbstractCFDiFactory
	{
		public abstract Serialization.CFDiLoader CreateLoader();
		public abstract ComprobanteBase CreateCFDi();
	}
}