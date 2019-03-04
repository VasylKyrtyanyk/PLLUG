using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLLUG
{
	public class Refrigerator
	{
		private double _width;
		private double _height;
		private double _length;


		public double Width
		{
			get => _width;
			set => _width = value;
		}
		public double Height
		{
			get => _height;
			set => _height = value;
		}
		public double Length
		{
			get => _length;
			set => _length = value;
		}



		public Refrigerator()
		{
		}

		public Refrigerator(double width, double height, double length)
		{
			this._width = width;
			this._height = height;
			this._length = length;
		}
	}
}
