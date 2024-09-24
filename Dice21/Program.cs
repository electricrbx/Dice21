namespace Dice21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to 21");
            Console.WriteLine("Do you wanna Hit or Stop");


            string anwser = Console.ReadLine();
            Random rand = new Random();
            Random rand2 = new Random();
            int dealer = 0;
            int player = 0;
      
            while (anwser == "hit")
            {
                if (player <= 21 )
                {
                    if (dealer <= 17)
                    {
                        int randomNumber2 = rand2.Next(1, 7);
                        dealer += randomNumber2;
                        int DealerTotal = dealer;
                        Console.WriteLine("Dealern slog " + randomNumber2);
                        Console.WriteLine("Dealern har " + DealerTotal);

                       
                    }

                    int randomNumber = rand.Next(1, 7);
                    player += randomNumber;
                    int playerTotal = player;
                    Console.WriteLine("du slog " + randomNumber);
                    Console.WriteLine("Du har " + playerTotal);
                    Console.WriteLine("Do you wanna Hit or Stop");
                    anwser = Console.ReadLine();



                    while (anwser == "stop" && dealer <= 17)
                    {
                        int randomNumber3 = rand.Next(1, 7);
                        dealer += randomNumber3;
                        int DealerTotal2 = dealer;
                        Console.WriteLine("Dealern slog " + randomNumber3);
                        Console.WriteLine("Dealern har " + DealerTotal2);
                    }


                }
                while (dealer <= player && player <= 22)
                {
                    Console.WriteLine("you won");
                    break;
                }
                while  (player <= dealer && player >= 21)
                {
                    Console.WriteLine("you lost");
                    break;
                }
            }
        }
    }
}
