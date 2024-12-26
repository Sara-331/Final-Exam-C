public class Animal{
    public string name{ get; set; }
    private int Health{ get; set; }

    public static int TotalAnimals;
    public Animal(string name, int health){
        this.name = name;
        this.Health = Health;
        TotalAnimals++;

    }
    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound!");
    }
    public virtual void TakeDamage(int damage) {
        Health=damage;
        Console.WriteLine(name + " health : " + Health);
    }
    public int GetHealth(){
        return Health;
    }
}