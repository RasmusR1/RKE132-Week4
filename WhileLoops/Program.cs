
Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while(loopActive)
{
    cpuRandom = rnd.Next(1, 3);
    Console.WriteLine("Enter a number 1-3: ");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Nice");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Try again");
    }
}
Console.WriteLine("Hyva päeva");
