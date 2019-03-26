using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PLLUG.TypeObject;

namespace PLLUG
{
	public static class HelperRead
	{
		public static Refrigerator InputDataRef()
		{
			var _ref = new Refrigerator();
			try
			{
				Console.Write("Enter size refrigerator:  Height =  ");
				_ref.Height = Convert.ToDouble(Console.ReadLine());

				Console.Write(" Width = ");
				_ref.Width = Convert.ToDouble(Console.ReadLine());

				Console.Write(" Length = ");
				_ref.Length = Convert.ToDouble(Console.ReadLine());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}


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
			var door = new SipmleDoor();
			double width = 0;
			double height = 0;
			try
			{
				Console.WriteLine("Data Door");

				Console.Write(" Width = ");
				width = Convert.ToDouble(Console.ReadLine());

				Console.Write(" Height = ");
				height = Convert.ToDouble(Console.ReadLine());
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
	

			return new SipmleDoor(width,height);
		}

		public static ISubject InputDataOculus()
		{
			Console.WriteLine("Data Oculus");
			double s = 0;
			try
			{
				s = Convert.ToDouble(Console.ReadLine());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			
			return new Oculus(s);
		}
	}
}
