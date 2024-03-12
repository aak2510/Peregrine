namespace ThingsToDoWithOOP;

class Fish : Animal
{
    private string _colour;

    public Fish(string name, int age, string sound, string colour) : base(name, age, sound)
    {
        this._colour = colour;
    }

    public override void sleep()
    {
        
    }
}
