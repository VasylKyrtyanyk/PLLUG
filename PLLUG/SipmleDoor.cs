namespace PLLUG
{
	public class SipmleDoor:ISubject
	{
		private double _width;
		private double _height;

		public SipmleDoor()
		{
		}

		public SipmleDoor(double width, double height)
		{
			this._width = width;
			this._height = height;
		}

		public bool MoveRef()
		{
			var _ref = HelperRead.InputDataRef();

			if ((_ref.Width < this._width) || (_ref.Height < this._height)  )
			{
				return true;
			}
			else
			{
				return false;
			}	
		}

		public bool MoveSphere()
		{
			var sphere = HelperRead.InputDataSphere();

			if (this._height > sphere.Diameter && this._width > sphere.Diameter)
			{
				return true;
			}

			return false;
		}

		public bool MoveCylinder()
		{
			var cyl = HelperRead.InputDataCyl();

			if (this._height > cyl.Height && this._width > cyl.Diameter)
			{
				return true;
			}
			else if (this._height > cyl.Diameter && this._width > cyl.Diameter)
			{
				return true;
			}
			else if (this._width > cyl.Height && this._height > cyl.Diameter)
			{
				return true;
			}

			return false;
		}
	}
}
