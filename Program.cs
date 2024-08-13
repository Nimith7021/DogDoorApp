using DogDoorApp.Models;

namespace DogDoorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            BarkRecognizer barkRecognizer = new BarkRecognizer(door);
             Remote remote = new Remote(door);
             Console.WriteLine("Tommy barks to go outside ....");
             barkRecognizer.Recognize("Woof");
             Console.WriteLine("Tommy goes outside");
             Console.WriteLine("Tommy is done with his work");

            try
            {
                Thread.Sleep(7000);
                Thread.CurrentThread.Abort();
            }
            catch(Exception ex)
            {

                Console.WriteLine("...But Tommy is stuck behind");
                Console.WriteLine("He barks again");
                barkRecognizer.Recognize("Woof"); 
                Console.WriteLine("He's back inside");
            }

             Console.ReadLine();
        }
    }
}












