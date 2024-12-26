public class Bird : Animal
{
    public Bird(string name, int health) : base(name, health){}

    public int InCage{ get; set; }

    public override void MakeSound(){
        Console.WriteLine("The bird chirps melodiously!");
    }
    
}