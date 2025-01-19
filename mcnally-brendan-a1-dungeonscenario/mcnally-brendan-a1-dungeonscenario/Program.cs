
using System.Security.Principal;

// Introduction to the game
Console.WriteLine("Welcome to the game...");
Console.WriteLine("Please enter your Username below");


// Getting Players username
Console.WriteLine();
string playername = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Interesting... {playername} now tell me.. If you had to choose a number right now ... What would it be?");
Console.WriteLine();

// Getting Gold amount aka your lucky number! 
string input = Console.ReadLine();
int gold = int.Parse(input);
float playerhealth = 100f;

Console.WriteLine();
Console.WriteLine($" Hopefully you chose wise! You have {gold} gold!");
Console.WriteLine("Please press Enter to continue...");
Console.WriteLine();
Console.ReadLine();

// Health Information 
Console.WriteLine();
Console.WriteLine($"Before you start... Here is your current health stat ---> {playerhealth} \n As you go along your adventure you might encounter scenarios that could make you lose that health");
Console.WriteLine();

// Enter to continue
Console.WriteLine("Please press Enter to continue...");
Console.WriteLine();
Console.ReadLine();
Console.WriteLine();

// Start of the First Scenario
Console.WriteLine(" 'You are thrown into a different dimension and tossed into what seems to be a dungeon..' ");
Console.WriteLine();
Console.Write("A massive spider comes crawling out of the darkness... You see a sword to your right... ");
Console.WriteLine();

// Asking the First Question
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
    string question1 = "Where do you Attack?! \n 1. 'Legs' 2. 'Stomach' ";
    Console.WriteLine($"{question1}");
    Console.WriteLine();
    string option1answer = Console.ReadLine();


    if (option1answer == "1")
    {
        spiderhealth -= sworddamage;
        //all of these console.writeline(); are to space out the program in the terminal and make it more readable for the user.
        Console.WriteLine();
        Console.WriteLine("You sprint and quickly slash several of the Spider's Legs!");
        Console.WriteLine();
        Console.WriteLine($"The Spider now has {spiderhealth} health!");
        Console.WriteLine();
        Console.WriteLine("Type to continue!");
        Console.WriteLine();
        Console.ReadLine();

        //Question 2 for 'option1answer'
        Console.WriteLine();
        Console.WriteLine("The Spider is furious! It charges straight for you! What do you do?");
        Console.WriteLine();
        Console.WriteLine(" 1. 'Stick your sword out and Pray' 2. 'Dodge!' ");
        Console.WriteLine();
        string question2answer = Console.ReadLine();
        if (question2answer == "1")
        {

            //dialogue 
            Console.WriteLine();
            Console.WriteLine("You stick your sword out and pray as the Spider charges right at you showing its disgusting 8 eyes and venomous fangs!");
            Console.WriteLine();
            Console.WriteLine("In the blink of an eye your sword pierces through the front of the spider");
            Console.WriteLine();
            Console.WriteLine("Its lifeless body falls infront of you... But you notice a sharp pain coming from your forearm...");
            Console.WriteLine();
            Console.WriteLine("Please type to continue");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You look down and see a fang deep in your forearm...");
            Console.WriteLine();
            Console.WriteLine("You pull out the spider-fang and feel its venom rushing through your body...");
            Console.WriteLine();
            Console.WriteLine("Please type to continue");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("A Mysterious figure approaches out of the darkness...");
            Console.WriteLine();
            Console.WriteLine("You seem to be needing this... *Holding out an Antidote*");
            Console.WriteLine();
            Console.WriteLine("Remember at the start of the game... When I asked you about your favourite number... Like ever...?");
            Console.WriteLine();
            string response = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Now we will see if your favourite number is also your lucky one...");
            Console.WriteLine();
            Console.WriteLine("This Antidote has a cost.. Y'know?");
            Console.WriteLine();
            Console.WriteLine("The amount? I can't tell... Thats for the Game to decide....");
            Console.WriteLine();
            Console.WriteLine("Are you Ready...?");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();

            if (gold >= 25)
            {
                Console.WriteLine($"It seems {gold} really is your lucky number.");

                Console.WriteLine();

                Console.WriteLine("You drink the antidote and feel a sense of relief as you fall back and close your eyes....");
                Console.WriteLine();
                Console.WriteLine("Thanks for playing!");
            }
            else
            {
                Console.Write($"It seems {gold} might not be so lucky... You are unable to afford the Antidote");
                playerhealth -= 10000;

            }
        }
    }


    else if (playeranswer1 == "2")
    {
        // playerhealth -10.5 from the spiderweb shot
        Console.WriteLine("You look to the left into the darkness and try to sprint as fast as you can \n but before you can escape the spider hits you with a web!");
        Console.WriteLine();
        playerhealth -= 10.5f;
        Console.WriteLine($"You now have {playerhealth} health!");

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
        else if (question1response == "2")
        {

            Console.WriteLine("You try to Run again but the Spider Jumps on top of you!");
            Console.WriteLine();
            Console.WriteLine("You manage to wiggle out and escape! But your cornered...");
            Console.WriteLine();
            Console.WriteLine("The Spider silkily crawls up to you.. standing so very tall and menacing as it comes to your forefront..");
            Console.WriteLine();
            Console.WriteLine("Please type to continue...");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Its 8 eyes all focus upon you.. drool slathering from its disgusting hairy mouth...");
            Console.WriteLine();
            Console.WriteLine("Quivering in fear you look as the spider opens its mouth revealing its large venomous fangs");
            Console.WriteLine();
            Console.WriteLine("Nows your chance to scream!!");
            Console.WriteLine();
            string scream = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"{scream} + {scream} + {scream} + {scream} + {scream} + {scream}");


        }
    }
}