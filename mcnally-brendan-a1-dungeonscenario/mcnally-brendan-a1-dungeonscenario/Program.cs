// Introduction to the game
Console.WriteLine("Welcome to the game...");
Console.WriteLine("Please enter your Username below");


// Getting Players username
Console.WriteLine();
string playername = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Interesting {playername} now tell me.. If you had to choose a number right now ... What would it be?");
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
Console.WriteLine();

// Choice 1
if (playeranswer1 == "1")
{
    Console.WriteLine("You grab the sword and ready yourself to attack.");

    // Sword Damage and Spider Health.
    int sworddamage = 200;
    int spiderhealth = 400;

    // Spider Approaches
    Console.WriteLine();
    Console.WriteLine("The Spider approaches... Standing tall above you it readys itself to attack!");
    Console.WriteLine();

    // Attack the Spider's legs or stomach
    string question1 = "Where do you Attack?! \n 1. 'Legs' 2. 'Stomach' ";
    Console.WriteLine($"{question1}");
    Console.WriteLine();
    string option1answer = Console.ReadLine();

    // Answer 1 for Question1
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

            //Dialogue 
            Console.WriteLine();
            Console.WriteLine("You stick your sword out and pray as the Spider charges right at you showing its disgusting 8 eyes and venomous fangs!");
            Console.WriteLine();
            Console.WriteLine("In the blink of an eye your sword pierces through the front of the spider");
            Console.WriteLine();
            spiderhealth -= 10000;
            Console.WriteLine("Its lifeless body falls infront of you... But you notice a sharp pain coming from your forearm...");
            Console.WriteLine();
            Console.WriteLine("Please type to continue");
            Console.WriteLine();
            Console.ReadLine();

            //Breaks in code for readability
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


            // This Scenario Killed the Spider so its presence is hereby False.
            bool spider = spiderhealth <= 0;
            bool alive = playerhealth <= 0;


            //Lets see that lucky number!
            if (gold >= 25)
            {

                //Your number was Greater than 25
                Console.WriteLine($"It seems {gold} really is your lucky number.");
                Console.WriteLine();
                Console.WriteLine("You drink the antidote and feel a sense of relief as you fall back and close your eyes....");
                Console.WriteLine();

                //End Game Stats for this choicepath...
                int score = gold * gold;
                Console.WriteLine($"Did you kill the Spider:{spider}");
                Console.WriteLine();
                Console.WriteLine($"Heres your score.......:{score}");
                Console.WriteLine();
                Console.WriteLine($"Did you Surive:........:{!alive}");
                Console.WriteLine();
                Console.WriteLine("Thanks for playing!");
            }

            // Unlucky Ending
            else
            {
                //
                bool spider2 = spiderhealth <= 0;
                int score = gold * gold;
                Console.WriteLine();
                Console.Write($"It seems {gold} might not be so lucky... You are unable to afford the Antidote");
                Console.WriteLine();
                playerhealth -= 10000;

                Console.WriteLine($"Did you kill the Spider:{spider}");
                Console.WriteLine();
                Console.WriteLine($"Heres your score.......:{score}");
                Console.WriteLine();
                Console.WriteLine($"Did you Surive:........:{alive}");
                Console.WriteLine();
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}

//If Player chooses to Run
else if (playeranswer1 == "2")
{
    int daggerdamage = 100;
    int spiderhealth2 = 400;

    // Start of Scenario 2
    Console.WriteLine("After getting hit by the Spider you see a Dagger entangled in a web next to you");
    Console.WriteLine();

    // Using some Interpolation for fun here :) 
    string question2 = "1. 'Fight' 2. 'Run'";
    Console.WriteLine($"{question2}");
    Console.WriteLine();
    Console.WriteLine("Enter 1 or 2");
    Console.WriteLine();
    string question1response = Console.ReadLine();


    if (question1response == "1")
    {
        spiderhealth2 -= daggerdamage;

        Console.WriteLine();
        Console.WriteLine("You hit the Spider with your dagger and slash one of its hairy legs open!");
        Console.WriteLine();
        Console.WriteLine($"The Spider now has {spiderhealth2} health!");
        Console.WriteLine();
        Console.WriteLine("You stand to the side of the giant Arachnid as its legs begin to wobble ");


        Console.WriteLine();
        Console.WriteLine("You look up to the beast... Its Now or Never! ");
        Console.WriteLine();
        Console.WriteLine(" 1. Attack the Stomach 2. Scream and Run in Circles ");
        Console.WriteLine();
        string question2response = Console.ReadLine();

        if (question2response == "1")
        {
            spiderhealth2 -= 1000;
            Console.WriteLine();
            Console.WriteLine("You dive underneath the beast and Swing your sword with all your might into the Spiders stomach!");
            Console.WriteLine();
            Console.WriteLine("The Spider almost falls untop of you but you swiftly move away before it can.");
            Console.WriteLine();
            Console.WriteLine("You notice a figure approaching out of the darkness...");
            Console.WriteLine();
            Console.WriteLine("Please type Enter to continue");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("I see you have completed your first test... ");
            Console.WriteLine();
            Console.WriteLine("Your bravery deserves a reward...");
            Console.WriteLine();
            Console.WriteLine("Take these coins, Traveller.. They could be of great use to you on the way");
            int addedcoins = 25;
            addedcoins += gold;
            Console.WriteLine($"You Gained {addedcoins} coins!");
            Console.WriteLine();
            Console.WriteLine($"You now have {gold} gold!");
            Console.WriteLine();
            Console.WriteLine("I'll see you on the next adventure...");
            Console.WriteLine();
            Console.WriteLine("The Mysterious Figure Vanishes");

            int score = gold * gold;
            bool isspideralive = spiderhealth2 <= 0;
            bool isplayeralive = playerhealth <= 0;
            Console.WriteLine();
            Console.WriteLine("You Survived!");
            Console.WriteLine();
            Console.WriteLine($"Your Score was..........:{score}");
            Console.WriteLine();
            Console.WriteLine($"Did you kill the Spider?:{isspideralive}");
            Console.WriteLine();
            Console.WriteLine($"Did you survive?........:{!isplayeralive}");


        
        }
        else if (question2response == "2")
        {
            Console.WriteLine();
            Console.WriteLine("You Start manically screaming and sprinting in circles around the Spider!");
            Console.WriteLine();
            Console.WriteLine("The Spider is startled by your Actions and Scurrys back into its den!");
            Console.WriteLine();
            Console.WriteLine("A Mysterious Figure approaches");
            Console.WriteLine()


    }
    else if (question1response == "2")
    {

        // Option 2 Dialogue
        Console.WriteLine();
        Console.WriteLine("You try to Run again but the Spider Jumps on top of you!");
        Console.WriteLine();
        Console.WriteLine("You manage to wiggle out and escape! But your cornered...");
        Console.WriteLine();
        Console.WriteLine("The Spider silkily crawls up to you.. standing so very tall and menacing as it comes to your forefront..");
        Console.WriteLine();
        Console.WriteLine("Please press Enter to continue...");
        Console.WriteLine();
        Console.ReadLine();

        // Oh boy! Lets show this user that the Spider isn't playing games...
        Console.WriteLine();
        Console.WriteLine("All 8 eyes focus upon you.. drool slathering from its disgusting hairy mouth...");
        Console.WriteLine();
        Console.WriteLine("Quivering in fear you look as the spider opens its mouth revealing its large venomous fangs");
        Console.WriteLine();
        Console.WriteLine("Nows your chance to scream!!");
        Console.WriteLine();


        string scream = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{scream} {scream}  {scream}  {scream}  {scream}  {scream}");


        //Final Stats for this Choice path

        int score = gold * gold;
        bool isspideralive = spiderhealth2 <= 0;
        bool isplayeralive = playerhealth <= 0;
        Console.WriteLine();
        Console.WriteLine("You Died!");
        Console.WriteLine();
        Console.WriteLine($"Your Score was..........:{score}");
        Console.WriteLine();
        Console.WriteLine($"Did you kill the Spider?:{isspideralive}");
        Console.WriteLine();
        Console.WriteLine($"Did you survive?........:{isplayeralive}");

    }
}




