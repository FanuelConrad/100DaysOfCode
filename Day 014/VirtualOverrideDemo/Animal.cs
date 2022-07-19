class Animal
{
    public string Name{get;set;}
    public int Age{get;set;}
    public bool IsHungry{get;set;}

    //constructor
    public Animal(string name, int age)
    {
        Name=name;
        Age=age;
        //in our case the animal is hungry by default
        IsHungry=true;
    }

    //an empty virtual method MakeSound for other classes to override
    public virtual void MakeSound()
    {

    }

    public virtual void Eat()
    {
        //check if animal is hungry
        if (IsHungry)
        {
            System.Console.WriteLine($"{Name} is eating");
        }
        else
        {
            //otherwise print that the animal is not hungry
            System.Console.WriteLine($"{Name} is not hungry");
        }
    }

    //virtual method Play
    public virtual void Play()
    {
        System.Console.WriteLine($"{Name} is playing");
    }

}