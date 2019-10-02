namespace WindowsApplication1
{
    public class Bus : Vehicle
    {
		public override string ToString()
		{
			return Color.Name.ToString() + " Bus " + NrOfPassengers.ToString() + " passangers";
		}
	}
}