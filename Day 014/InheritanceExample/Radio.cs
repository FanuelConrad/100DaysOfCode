namespace InheritanceExample
{
    //child class
    class Radio : ElectricalDevice
    {

        public Radio(bool isOn,string brand):base(isOn,brand)
        {
  
        }

        //method to listen to the radio
        public void  ListenRadio()
        {
            if (IsOn)
            {
                //listen to the radio
                System.Console.WriteLine("Listening to the Radio");
            }
            else
            {
                //print error message
                System.Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}