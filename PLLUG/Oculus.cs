using System;

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
			return diameter < diagonal;
		}
	}
}
