namespace ThingsToDoWithOOP;

class Seagull : Animal, IFly, ISwim
{
    private string _colour;

    public Seagull(string name, int age, string sound, string colour) : base(name, age, sound)
    {
        this._colour = colour;

    }

    public string Colour
    {
        get { 
            return _colour; 
        }

        set { 
            _colour = value; 
        }
    }


    public override void sleep()
    {
        Console.WriteLine("I rest my wings...");
    }



    public void fly()
    {
        Console.WriteLine("Flap, Flap and away.. ");
    }

    public void swim()
    {
        Console.WriteLine("A SEAgull can swim too... who knew?!");
    }
}
