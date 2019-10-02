namespace WindowsApplication1
{
    public class Truck : Vehicle
    {
		public int LoadCapacity { get; set; }

		public override string ToString()
		{
			return Color.Name.ToString() + " Truck " + LoadCapacity.ToString() + " loadcapacity";
		}
	}
	
}