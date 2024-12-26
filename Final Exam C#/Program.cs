public class Program{
    public static void Main(string[] args){
        Animal[] animals = new Animal[3];

        Dog D  = new Dog("Dog",1);
        Cat C  = new Cat("Cat",2);
        Bird B = new Bird("Bird",3);

         animals[0]=D;
         animals[1]=C;
         animals[2]=B;

    for (int i = 0 ; i < animals.Length ; i++){
        animals[i].MakeSound();
         }

         animals[0].TakeDamage(45);
         animals[1].TakeDamage(30);
         animals[2].TakeDamage(20);
    
    for (int i = 0 ; i < animals.Length ; i++){
       animals[i].GetHealth();
       }

    Console.WriteLine("Total animals created : " + Animal.TotalAnimals);

    
} 
}