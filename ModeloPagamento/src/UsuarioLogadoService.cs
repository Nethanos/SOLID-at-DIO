using Lime.Protocol;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ModeloPagamento.src
{
	[DataContract]
	class UsuarioLogadoService
	{
		public static string GetUsuarioLogado()
		{
			return "n.santos1897@gmail.com";
		}
	}
}
