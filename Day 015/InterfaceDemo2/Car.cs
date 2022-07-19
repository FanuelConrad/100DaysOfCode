namespace InterfaceDemo2
{
    class Car : Vehicle, IDestroyable
    {
        public string DestructionSound{get;set;}
        public List<IDestroyable>DestroyablesNearby;

        //simple constructor
        public Car(float speed, string color)
        {
            this.Speed=speed;
            this.Color=color;
            //initialise the interface's property with a value in the constructor
            DestructionSound="CarExplosion.mp3";
            //initialise list of destroyable objects
            DestroyablesNearby=new List<IDestroyable>();
        }

        public void Destroy()
        {
            //when a car gets destroyed we should play the destruction sound and create fire effect
            System.Console.WriteLine("Playing destruction sound {0}",DestructionSound);
            System.Console.WriteLine("Create fire");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}