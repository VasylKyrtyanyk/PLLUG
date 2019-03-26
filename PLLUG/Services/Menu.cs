using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLLUG.Services
{
	public static class Menu
	{
		public static void ConsoleSelect()
		{
			Console.WriteLine("Enter 1 - Rectangle , 2 - Oculus");

			int k = Convert.ToInt32(Console.ReadLine());

			ISubject sub = null;
			switch (k)
			{
				case 1: sub = HelperRead.InputDataDoor();
					break;
				case 2:
					sub = HelperRead.InputDataOculus();
					break;
			}



			Console.WriteLine("Enter 1 - Sphere , 2 - Cylinder, 3 - Refrigerator");
			int k1 = Convert.ToInt32(Console.ReadLine());

			switch (k1)
			{
				case 1:
					Console.WriteLine(sub.MoveSphere());
					break;
				case 2:
					Console.WriteLine(sub.MoveCylinder());
					break;
				case 3:
					Console.WriteLine(sub.MoveRef());
					break;
			}




		}
	}
}
