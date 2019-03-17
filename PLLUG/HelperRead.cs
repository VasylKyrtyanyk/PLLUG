using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLLUG
{
	public static class HelperRead
	{
		public static Refrigerator InputDataRef()
		{
			Refrigerator _ref = new Refrigerator();

			Console.Write("Enter size refrigerator:  Height =  ");
			_ref.Height = Convert.ToDouble(Console.ReadLine());
			Console.Write(" Width = ");
			_ref.Width = Convert.ToDouble(Console.ReadLine());
			Console.Write(" Length = ");
			_ref.Length = Convert.ToDouble(Console.ReadLine());
			return _ref;
		}

		public static ISubject InputDataDoor()
		{
			Console.WriteLine("Data Door");
			double width, height;
			Console.Write(" Width = ");
			width = Convert.ToDouble(Console.ReadLine());
			Console.Write(" Height = ");
			height = Convert.ToDouble(Console.ReadLine());

			return new SipmleDoor(width,height);
		}

		public static ISubject InputDataOculus()
		{
			Console.WriteLine("Data Oculus");

			return new Oculus(Convert.ToDouble(Console.ReadLine()));
		}
	}
}
