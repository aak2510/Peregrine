namespace ThingsToDoWithOOP;
internal abstract class Animal
{

    // Attributes
    private string _name;
    private int _age;
    private string _sound;

    // Constructor
    public Animal(string name, int age, string sound)
    {
        this._name = name;
        this._age = age;
        this._sound = sound;
    }


    // Getters and Setters
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Sound
    {
        get { return _sound; }
        set { _sound = value; }
    }
    
    public int Age
    {
        get{return _age;}

    }

    // Methods
    public void growsOlder()
    {
        _age++;
    }


    public void makeSound()
    {
        Console.WriteLine($"{_name} makes a {_sound} sound.");
    }

    public abstract void sleep();
}

