using System;
using System.Resources;

namespace PLLUG
{
	public class Oculus : ISubject
	{
		public Oculus()
		{

		}

		public Oculus(double radius)
		{
			Radius = radius;
			diameter = radius * 2;
		}

		public double Radius { get; set; }

		private double diameter;
		
		public bool MoveRef()
		{
			var _ref = HelperRead.InputDataRef();
			var diagonal = Math.Sqrt(Math.Pow(_ref.Width, 2) + Math.Pow(_ref.Length, 2));
			return diameter > diagonal;
		}

		public bool MoveSphere()
		{
			var sphere = HelperRead.InputDataSphere();
			if (this.diameter > sphere.Diameter)
			{
				return true;
			}

			return false;
		}

		public bool MoveCylinder()
		{
			var cyl = HelperRead.InputDataCyl();
			if (cyl.Diameter < this.diameter)
			{
				return true;
			}
			else if (this.diameter > cyl.Height && this.diameter > cyl.Diameter)
			{
				return true;
			}

			return false;
			}
	}
}
