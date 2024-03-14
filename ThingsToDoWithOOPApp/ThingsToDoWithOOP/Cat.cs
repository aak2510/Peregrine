namespace ThingsToDoWithOOP;

class Cat : Animal
{

    private string _breed;

    public Cat(string name, int age, string breed, string sound = "Meow") : base(name, age, sound)
    {
        this._breed = breed;
    }

    public override void sleep()
    {
        Console.WriteLine("Purrrr..."); ;
    }
}
