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
	}
}
