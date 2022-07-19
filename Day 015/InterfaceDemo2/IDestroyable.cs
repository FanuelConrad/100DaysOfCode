namespace InterfaceDemo2
{
    interface IDestroyable
    {
        //property to store the audio file of the destruction sound
        string DestructionSound{get;set;}

        //method to destroy an object
        void Destroy();
    }
}