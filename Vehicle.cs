using System.Drawing;
namespace WindowsApplication1
{
    public abstract class Vehicle
    {
		private Color c;

		public Color Color
		{
			get { return c; }
			set { c = value; }
		}

		private int p;

		public int NrOfPassengers
		{
			get { return p; }
			set { p = value; }
		}
	}
}
