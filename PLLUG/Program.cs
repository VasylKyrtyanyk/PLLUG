using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLLUG
{
	class Program
	{
		static void Main(string[] args)
		{
			//var _obj = HelperRead.InputDataDoor();
			//_obj.MoveRef();
			var obj = HelperRead.InputDataOculus();
			Console.WriteLine(obj.MoveRef());
			Console.ReadKey();
		}
	}
}
