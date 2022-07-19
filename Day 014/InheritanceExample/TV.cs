namespace InheritanceExample
{
    class TV : ElectricalDevice
    {
 
        public TV(bool isOn,string brand):base(isOn,brand)
        {
   
        }

        //method to listen to the TV
        public void  WatchTV()
        {
            if (IsOn)
            {
                //listen to the TV
                System.Console.WriteLine("Listening to the TV");
            }
            else
            {
                //print error message
                System.Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}