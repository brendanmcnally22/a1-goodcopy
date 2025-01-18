//This is my test commit Adding our visual studio project.

// Introduction to the Game.

//introduction to the game...
Console.WriteLine("Welcome to the game...");
Console.WriteLine("Please enter your Username below");
//getting the players username
Console.WriteLine();
string playername = Console.ReadLine();

Console.WriteLine();

Console.WriteLine($"Interesting... {playername} now tell me.. If you had to choose a number right now ... What would it be?");
Console.WriteLine();

string input = Console.ReadLine();
int gold = int.Parse(input);
float playerhealth = 100f;

Console.WriteLine();
Console.WriteLine($" Hopefully you chose wise! You have {gold} gold!");
Console.WriteLine("Type to continue...");
Console.WriteLine();
Console.ReadLine();

//space
Console.WriteLine();


Console.WriteLine($"Before you start... Here is your current health stat ---> {playerhealth} \n As you go along your adventure you might encounter scenarios that could make you lose that health");

//if the player dies... even though they cant! haha
if (playerhealth <= 0)
{ Console.WriteLine("Your Health has fallen below zero... Please try again!"); }

//space
Console.WriteLine();


//enter to move on! 
Console.WriteLine("Please type to continue..");
Console.WriteLine();
Console.ReadLine();
Console.WriteLine();

//start of scenario 1 
Console.WriteLine(" 'You are thrown into a different dimension and tossed into what seems to be a dungeon..' ");
Console.WriteLine();
Console.Write("A massive spider comes crawling out of the darkness... You see a sword to your right... ");

//space

Console.WriteLine();

//space


Console.WriteLine("1. 'Grab Sword' 2. 'Run' ");

Console.WriteLine();

Console.WriteLine("Enter 1 or 2");

Console.WriteLine();

string playeranswer1 = Console.ReadLine();

//space
Console.WriteLine();

//conditional statements 
// here we get the players answer and figure out which path they take.
// 
if (playeranswer1 == "1")
{

    // here we go down option 1s rabbit hole!
    Console.WriteLine("You grab the sword and ready yourself to attack.");

    // we declare these values here so the computer remembers.
    int sworddamage = 200;
    int spiderhealth = 400;

    // scenario begins
    Console.WriteLine();
    Console.WriteLine("The Spider approaches... Standing tall above you it readys itself to attack!");
    Console.WriteLine();

    //question is presented
    string question1 = "Where do you Attack?! \n 1. Legs 2. Stomach";
    Console.WriteLine($"{question1}");
    Console.WriteLine();
    string option1answer = Console.ReadLine();






    if (option1answer == "1")
    {
        spiderhealth -= sworddamage;

        Console.WriteLine("You sprint and quickly slash several of the Spider's Legs!");
        Console.WriteLine();
        Console.WriteLine($"The Spider now has {spiderhealth} health!");
        Console.WriteLine();
        Console.WriteLine("Type to continue!");
        Console.ReadLine();
    }







    else if (playeranswer1 == "2")
    {
        // playerhealth -10.5 from the spiderweb shot
        Console.WriteLine("You look to the left into the darkness and try to sprint as fast as you can \n but before you can escape the spider hits you with a web!");
        Console.WriteLine();
        playerhealth -= 10.5f;
        Console.WriteLine($"You now have {playerhealth} health!");
    }
    else
    {
        Console.WriteLine("Invalid input... Please try again");
    }

    //answer 1 pathway i just like to seperate it 


    // answer 2 pathway
    if (playeranswer1 == "2")
    {
        int daggerdamage = 100;
       
        Console.WriteLine();
        Console.WriteLine("After getting hit by the Spider you see a Dagger entangled in a web next to you");

        Console.WriteLine();

        string question2 = "1. Fight 2. Run \n Enter 1. or  2.";
        Console.WriteLine();
        Console.WriteLine($"{question2}");
        Console.WriteLine();
        string question1response = Console.ReadLine();

        if (question1response == "1")
        {
            Console.WriteLine();
            spiderhealth -= daggerdamage;
            Console.WriteLine("You hit the Spider with your dagger and slash one of its hairy legs open!");
            Console.WriteLine();
            Console.WriteLine($"The Spider now has {spiderhealth} health!");

        }


    }
}