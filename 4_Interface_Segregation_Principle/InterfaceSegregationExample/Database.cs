using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregationExample
{
	public class Database
	{
		public static void save(object value)
		{
			Console.WriteLine("Recurso salvo");
		}
	}
}
