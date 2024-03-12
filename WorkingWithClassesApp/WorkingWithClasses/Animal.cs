using System;


namespace WorkingWithClasses
{
    //class Animal
    //{

    //    // The get and set means that we can get and set, regardless of it being private or public. If its private then we can only set them using methods, as normal.
    //    private string Name { get; set; }
    //    public string? TypeOfAnimal { get; set; }
    //    private int Age { get;  set; }
    //    public string Colour { get; set; }
    //    public decimal Price { get; set; }
    //    public decimal Cost { get; set; }

    //    public Animal(string name, string typeOfAnimal, int age, string colour, decimal price, decimal cost)
    //    {
    //        Name = name ?? throw new ArgumentNullException(nameof(name));
    //        TypeOfAnimal = typeOfAnimal;
    //        Age = age;
    //        Colour = colour ?? throw new ArgumentNullException(nameof(colour));
    //        Price = price;
    //        Cost = cost;
    //    }

    //    public Animal()
    //    {
    //        Name = "No Name";
    //        TypeOfAnimal = "No Type";
    //        Age = 0;
    //        Colour = "No Colour";
    //        Price = 0m;
    //        Cost = 0;
    //    }

    //    public string getName()
    //    {
    //        return Name;
    //    }

    //    public void setName(string name)
    //    {
    //        Name = name;
    //    }


    //    //public int getAge()
    //    //{
    //    //    return Age;

    //    //}

    //    //public void increaseAge()
    //    //{
    //    //    this.Age++;
    //    //}

    //}

    class Animal  // Base class (parent) 
    {
        public string hi = "meow";
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            //myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            //Console.WriteLine(myPig.hi);
            //Console.WriteLine(myDog.hi);
            //Console.WriteLine((myPig is Animal));
            //Console.WriteLine((myDog is Animal));


            List<Animal> newList = new List<Animal>();
            newList.Add(myAnimal);
            newList.Add(myPig);
            newList.Add(myDog);

            foreach (Animal animal in newList)
            {
                animal.animalSound();
            }
        }
    }

}
