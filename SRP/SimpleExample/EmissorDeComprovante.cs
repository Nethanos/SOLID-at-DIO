using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.SimpleExample
{
	public class EmissorDeComprovante {
	
		public void EmitirComprovante(double valor)
		{
		Comprovante comprovante = new Comprovante($"Comprovante emitido em {new DateTime().ToString()}", valor.ToString());
			
		}
		
	}
}
