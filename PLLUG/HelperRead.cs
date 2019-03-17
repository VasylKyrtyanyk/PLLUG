using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLLUG.TypeObject;

namespace PLLUG
{
	public static class HelperRead
	{
		public static Refrigerator InputDataRef()
		{
			var _ref = new Refrigerator();

			Console.Write("Enter size refrigerator:  Height =  ");
			_ref.Height = Convert.ToDouble(Console.ReadLine());

			Console.Write(" Width = ");
			_ref.Width = Convert.ToDouble(Console.ReadLine());

			Console.Write(" Length = ");
			_ref.Length = Convert.ToDouble(Console.ReadLine());

			return _ref;
		}

		public static Cylinder InputDataCyl()
		{
			var cylinder = new Cylinder();

			Console.Write("Enter size cylinder:  Height =  ");
			cylinder.Height = Convert.ToDouble(Console.ReadLine());

			Console.Write(" Diameter = ");
			cylinder.Diameter = Convert.ToDouble(Console.ReadLine());

			return cylinder;
		}

		public static Sphere InputDataSphere()
		{
			Console.WriteLine("Input diameter sphere ");
			var diameter = Convert.ToDouble(Console.ReadLine());

			return new Sphere(diameter);
		}

		public static ISubject InputDataDoor()
		{
			Console.WriteLine("Data Door");

			Console.Write(" Width = ");
			var width = Convert.ToDouble(Console.ReadLine());

			Console.Write(" Height = ");
			var height = Convert.ToDouble(Console.ReadLine());

			return new SipmleDoor(width,height);
		}

		public static ISubject InputDataOculus()
		{
			Console.WriteLine("Data Oculus");

			return new Oculus(Convert.ToDouble(Console.ReadLine()));
		}
	}
}
