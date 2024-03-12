namespace ThingsToDoWithOOP;

class Dog : Animal
{

    // Fields/Attributes
    private string _breed;
    private bool _tail;


    // Constructor
    public Dog(string name, int age, string breed, bool tail, string sound = "woof") : base(name, age, sound)
    {

        this._breed = breed;
        this._tail = tail;
    }

    // Getters and setters
    public string Breed { get { return this._breed; } }
    public bool Tail
    {
        get
        {
            return this._tail;
        }

        set
        {
            this._tail = value;
        }
    }

    public void displayInfo()
    {
        Console.WriteLine($"""
            =======================================
            Name: {this.Name}
            Age: {this.Age}
            Breed: {this.Breed}
            Has Tail?: {this.Tail}
            Sound: {this.Sound}
            =======================================
            """);
    }


    public override void sleep()
    {
        Console.WriteLine("Zzzz...");
    }
}
