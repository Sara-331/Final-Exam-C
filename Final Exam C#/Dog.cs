public class Dog : Animal
{
    public Dog(string name, int health) : base(name, health){}
    public int HasLeash{get; set;}
    
    public override void MakeSound(){
        Console.WriteLine("The dog barks loudly!");
    }
}