namespace InheritanceDemo
{
    //parent class
    class ElectricalDevice
    {
        //boolean to determine the state of the ElectricalDevice
        public bool IsOn{get;set;}
        //string for the brand name for the ElectricalDevice
        public string Brand{get;set;}

        public ElectricalDevice(bool isOn,string brand)
        {
            IsOn=isOn;
            Brand=brand;
        }

        //switch on the ElectricalDevice
        public void SwitchOn()
        {
            IsOn=true;
        }

        //switch off the ElectricalDevice
        public void SwitchOff()
        {
            IsOn=false;
        }

        //method to listen to the ElectricalDevice
        public void  ListenElectricalDevice()
        {
            if (IsOn)
            {
                //listen to the ElectricalDevice
                System.Console.WriteLine("Listening to the ElectricalDevice");
            }
            else
            {
                //print error message
                System.Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}