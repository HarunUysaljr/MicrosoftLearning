internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();

        int roll1 = rnd.Next(1, 7);
        int roll2 = rnd.Next(1, 14);
        int roll3 = rnd.Next(1, 5);


        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if(total > 15){
            System.Console.WriteLine("Win");
        }
        if(total < 14){
            System.Console.WriteLine("lose");
        }
 
   }
}