public class Cat : Animal
{
    public Cat(string name, int health) : base(name, health){}
     public override void MakeSound(){
        Console.WriteLine("The cat meows softly!");
    }
    public override void TakeDamage(int damage) {
        base.TakeDamage(damage);
    }
    
}