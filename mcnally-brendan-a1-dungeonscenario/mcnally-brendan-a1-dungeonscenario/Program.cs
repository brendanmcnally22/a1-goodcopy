// Introduction to the game
using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Welcome to the game...");
Console.WriteLine("Please enter your Username below");


// Getting Players username
Console.WriteLine();
string playerName = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Interesting {playerName} now tell me.. If you had to choose a number right now ... What would it be?");
Console.WriteLine();


// Getting Gold amount aka your lucky number! 
string playerInput = Console.ReadLine();
int playerGold = int.Parse(playerInput);
float playerHealth = 100f;

//All of the Console.Writeline(); are used for spacing our text in the terminal and making it more legible 
Console.WriteLine();
Console.WriteLine($" Hopefully you chose wise! You have {playerGold} gold!");
Console.WriteLine("Please press Enter to continue...");
Console.WriteLine();
Console.ReadLine();

// Health Information 
Console.WriteLine();
Console.WriteLine($"Before you start... Here is your current health stat ---> {playerHealth} \n As you go along your adventure you might encounter scenarios that could make you lose that health");
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


string playerAnswer1 = Console.ReadLine();
Console.WriteLine();

// Choice 1
if (playerAnswer1 == "1")
{
    Console.WriteLine("You grab the sword and ready yourself to attack.");

    // Sword Damage and Spider Health.
    int swordDamage = 200;
    int spiderHealth = 400;

    // Spider Approaches
    Console.WriteLine();
    Console.WriteLine("The Spider approaches... Standing tall above you it gears up to attack!");
    Console.WriteLine();
    Console.WriteLine($"The Spider has {spiderHealth} Health!");
    Console.WriteLine();


    // Attack the Spider's legs or stomach
    string question1 = "Where do you Attack?! \n 1. 'Legs' 2. 'Stomach' ";
    Console.WriteLine($"{question1}");
    Console.WriteLine();
    string option1Answer = Console.ReadLine();


    // Answer 1  Going for the Legs
    if (option1Answer == "1")
    {
        spiderHealth -= swordDamage;
        //all of these console.writeline(); are to space out the program in the terminal and make it more readable for the user.
        Console.WriteLine();
        Console.WriteLine("You sprint and quickly slash several of the Spider's Legs!");
        Console.WriteLine();
        Console.WriteLine($"The Spider now has {spiderHealth} health!");
        Console.WriteLine();
        Console.WriteLine("Please press Enter to continue!");
        Console.WriteLine();
        Console.ReadLine();

        //Question 2 for 'option1answer'
        Console.WriteLine();
        Console.WriteLine("The Spider is furious! It charges straight for you! What do you do?");
        Console.WriteLine();
        Console.WriteLine(" 1. 'Stick your sword out and Pray' 2. 'Dodge!' ");
        Console.WriteLine();
        string question2answer = Console.ReadLine();

        //Stick your sword out and Pray?!
        if (question2answer == "1")
        {

            //Dialogue 
            Console.WriteLine();
            Console.WriteLine("You stick your sword out and pray as the Spider charges right at you showing its disgusting 8 eyes and venomous fangs!");
            Console.WriteLine();
            Console.WriteLine("In the blink of an eye your sword pierces through the front of the spider");
            Console.WriteLine();
            spiderHealth -= 10000;
            Console.WriteLine("Its lifeless body falls infront of you... But you notice a sharp pain coming from your forearm...");
            Console.WriteLine();
            Console.WriteLine("Please press Enter to continue");
            Console.WriteLine();
            Console.ReadLine();

            // Ouch, A spider fang definitely hurts.
            Console.WriteLine("You pull a spider fang from deep in your forearm and feel its venom rushing through you.");
            Console.WriteLine();
            Console.WriteLine("A mysterious figure offers you an Antidote.. But it will cost you.. Do you have enough gold?");
            Console.WriteLine();
            Console.WriteLine("Hopefully your Number was Lucky..");
            Console.WriteLine();

            // Not enough Gold
            if (playerGold <= 25)
            {


                //Sorry you didn't have enough gold!
                Console.WriteLine();
                Console.WriteLine("You do not have enough Gold traveller... Looks like your fate has been sealed...");
                Console.WriteLine();


                // Here we are getting the Final Stats for the player 
                bool spider = spiderHealth <= 0;
                bool isplayeralive = playerHealth <= 0;
                int score = playerGold * playerGold;


                //Player Died because they couldn't afford the antidote so we subtract health points
                playerHealth -= 10000;


                Console.WriteLine();
                Console.WriteLine($"Did you kill the Spider:{spider}");
                Console.WriteLine();
                Console.WriteLine($"Heres your score.......:{score}");
                Console.WriteLine();
                Console.WriteLine($"Did you Surive:........:{isplayeralive}");
                Console.WriteLine();
                Console.WriteLine("Thanks for playing!");
            }


            // Enough Gold
            else if (playerGold >= 26)
            {
                playerGold -= 26;
                Console.WriteLine();
                Console.WriteLine($"You Had enough for the Antidote! you now have {playerGold} Gold!");
                Console.WriteLine();

                bool spider = spiderHealth <= 0;
                bool isplayeralive = playerHealth <= 0;
                int score = playerGold * playerGold;
                //Console.WriteLine(); is to space out our text on the terminal and make it more legible
                Console.WriteLine();
                Console.WriteLine($"Did you kill the Spider:{spider}");
                Console.WriteLine();
                Console.WriteLine($"Heres your score.......:{score}");
                Console.WriteLine();
                Console.WriteLine($"Did you Surive:........:{!isplayeralive}");
                Console.WriteLine();
                Console.WriteLine("Thanks for playing!");
            }
            
        }
// Trying to Dodge the Spider, Definitely more logical! But that Doesn't mean it'll help you!
        else if (question2answer == "2")
        {
            //Trying to Dodge the Spider
            Console.WriteLine();
            Console.WriteLine("You try to dodge the spider But it gets you with its web! ");
            Console.WriteLine();
            Console.WriteLine("It Jumps on top of you and starts sinking its fangs deep into your stomach!");
            playerHealth -= 1000;
            Console.WriteLine("Everything fades to black as the venom knocks you out...");
            Console.WriteLine("Please Press Enter to Continue"); 
            Console.ReadLine();

            // End Game Message
            Console.WriteLine();
            Console.WriteLine("You hear a voice in the darkness");
            Console.WriteLine();
            Console.WriteLine("You tried your best... Traveller");
            Console.WriteLine();

            
            //Final Stats
            bool spider = spiderHealth <= 0; 
            bool isplayeralive = playerHealth <= 0;
            int score = playerGold * playerGold;
        
            Console.WriteLine();
            Console.WriteLine($"Did you kill the Spider:{spider}");
            Console.WriteLine();
            Console.WriteLine($"Heres your score.......:{score}");
            Console.WriteLine();
            Console.WriteLine($"Did you Surive:........:{!isplayeralive}");
            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");

        }
    }

    // Choosing to Dodge the Spider
    else if (option1Answer == "2")
    {

        // Slicing the Spiders Stomach
        spiderHealth -= 1000;
        Console.WriteLine();
        Console.WriteLine("You dive underneath the spider slashing through its stomach... GUTS flying all over the place!");
        Console.WriteLine();
        Console.WriteLine("You stand up infront of the Arachnids dead body... and see a Mysterious Figure approach");
        Console.WriteLine();
        Console.WriteLine("You did well traveller... I admire your bravery");
        Console.WriteLine();
        Console.WriteLine("I will see you on your next adventure");
        Console.WriteLine();
        Console.WriteLine("Please Press Enter to Continue");
        Console.ReadLine();


        //Do Final stat math
        bool isspiderAlive = spiderHealth <= 0;
        bool isplayerAlive = playerHealth <= 0;
        int finalScore = playerGold * playerGold;


        //Final Stats Dialogue
        Console.WriteLine();
        Console.WriteLine($"Did you kill the Spider:{isspiderAlive}");
        Console.WriteLine();
        Console.WriteLine($"Heres your score.......:{finalScore}");
        Console.WriteLine();
        Console.WriteLine($"Did you Surive:........:{!isplayerAlive}");
        Console.WriteLine();
        Console.WriteLine("Thanks for playing!");
      

    }


    // Unlucky Ending
    else
    {


        //Final Stats
        bool isspiderAlive = spiderHealth <= 0;
        bool isplayeralive = playerHealth <= 0;
        int finalScore = playerGold * playerGold;


        Console.WriteLine();
        Console.Write($"It seems {playerGold} might not be so lucky... You are unable to afford the Antidote");
        Console.WriteLine();
        playerHealth -= 10000;


        // Final Stats Written out to the User
        Console.WriteLine($"Did you kill the Spider:{isspiderAlive}");
        Console.WriteLine();
        Console.WriteLine($"Heres your score.......:{finalScore}");
        Console.WriteLine();
        Console.WriteLine($"Did you Surive:........:{isplayeralive}");
        Console.WriteLine();
        Console.WriteLine("Thanks for playing!");
    }
        }
    


//If Player chooses to Run
else if (playerAnswer1 == "2")
{
    int daggerDamage = 100;
    int spiderHealth2 = 400;

    // Start of Scenario 2
    Console.WriteLine("After getting hit by the Spider you see a Dagger entangled in a web next to you");
    Console.WriteLine();

    // Using some Interpolation for fun here :) 
    string questionTwo = "1. 'Fight' 2. 'Run'";
    Console.WriteLine($"{questionTwo}");
    Console.WriteLine();
    Console.WriteLine("Enter 1 or 2");
    Console.WriteLine();
    string question1Response = Console.ReadLine();


    if (question1Response == "1")
    {


        spiderHealth2 -= daggerDamage;


        // Player stabs the Spider
        Console.WriteLine();
        Console.WriteLine("You hit the Spider with your dagger and slash one of its hairy legs open!");
        Console.WriteLine();
        Console.WriteLine($"The Spider now has {spiderHealth2} health!");
        Console.WriteLine();
        Console.WriteLine("You stand to the side of the giant Arachnid as its legs begin to wobble ");


        Console.WriteLine();
        Console.WriteLine("You look up to the beast... Its Now or Never! ");
        Console.WriteLine();
        Console.WriteLine(" 1. 'Attack the Stomach' 2. 'Scream and Run in Circles' ");
        Console.WriteLine();
        string question2Response = Console.ReadLine();

        // Attack the Stomach Option
        if (question2Response == "1")
        {

            // Killing the Spider
            spiderHealth2 -= 1000;
            Console.WriteLine();
            Console.WriteLine("You dive underneath the beast and Swing your sword with all your might into the Spiders stomach!");
            Console.WriteLine();
            Console.WriteLine("The Spider almost falls untop of you but you swiftly move away before it can.");
            Console.WriteLine();
            Console.WriteLine("You notice a figure approaching out of the darkness...");
            Console.WriteLine();
            Console.WriteLine("Please type Enter to continue");
            Console.ReadLine();

            // Mysterious Figure Speaks
            Console.WriteLine();
            Console.WriteLine("I see you have completed your first test... ");
            Console.WriteLine();
            Console.WriteLine("Your bravery deserves a reward...");
            Console.WriteLine();
            Console.WriteLine("Take these coins, Traveller.. They could be of great use to you on the way");

            // Adding the coins to the Travellers piggy bank! 
            int addedCoins = 25;
            addedCoins += playerGold;

            // Add the Coins to the Purse
            Console.WriteLine();
            Console.WriteLine($"You Gained {addedCoins} coins!");
            Console.WriteLine();
            Console.WriteLine($"You now have {playerGold} gold!");
            Console.WriteLine();
            Console.WriteLine("I'll see you on the next adventure...");
            Console.WriteLine();
            Console.WriteLine("The Mysterious Figure Vanishes");

            // Final Stats display
            int finalScore = playerGold * playerGold;
            bool isspiderAlive = spiderHealth2 <= 0;
            bool isplayerAlive = playerHealth <= 0;
            Console.WriteLine();
            Console.WriteLine("You Survived!");
            Console.WriteLine();
            Console.WriteLine($"Your Score was..........:{finalScore}");
            Console.WriteLine();
            Console.WriteLine($"Did you kill the Spider?:{isspiderAlive}");
            Console.WriteLine();
            Console.WriteLine($"Did you survive?........:{!isplayerAlive}");


        }

        // Run in circles and scream??
        else if (question2Response == "2")
        {

            // Scream!!!
            Console.WriteLine("Scream!!!");
            Console.WriteLine();
            string playerScream2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"{playerScream2} {playerScream2} {playerScream2} {playerScream2} {playerScream2} {playerScream2} {playerScream2} {playerScream2}");

            // Scream Scenario
            Console.WriteLine();
            Console.WriteLine("You Start manically screaming and sprinting in circles around the Spider!");
            Console.WriteLine();
            Console.WriteLine("The Spider is startled by your Actions and Scurrys back into its den!");
            Console.WriteLine();
            Console.WriteLine("A Mysterious Figure approaches");
            Console.WriteLine();
            Console.WriteLine("Your choices were Interesting traveller... But here you are Alive and Well..");
            Console.WriteLine();
            Console.WriteLine("Your life is your gift... Take it as you wish, I'll see you on the next adventure.");

            //Final Stats
            int finalScore = playerGold * playerGold;
            bool isspiderAlive = spiderHealth2 <= 0;
            bool isplayerAlive = playerHealth <= 0;
            Console.WriteLine();
            Console.WriteLine("You Survived!");
            Console.WriteLine();
            Console.WriteLine($"Your Score was..........:{finalScore}");
            Console.WriteLine();
            Console.WriteLine($"Did you kill the Spider?:{isspiderAlive}");
            Console.WriteLine();
            Console.WriteLine($"Did you survive?........:{!isplayerAlive}");


        }
    }
    else if (question1Response == "2")
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


        string playerScream = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{playerScream} {playerScream}  {playerScream}  {playerScream}  {playerScream}  {playerScream}");


        //Final Stats for this Choice path

        int finalScore = playerGold * playerGold;
        bool isspiderAlive = spiderHealth2 <= 0;
        bool isplayerAlive = playerHealth <= 0;
        Console.WriteLine();
        Console.WriteLine("You Died!");
        Console.WriteLine();
        Console.WriteLine($"Your Score was..........:{finalScore}");
        Console.WriteLine();
        Console.WriteLine($"Did you kill the Spider?:{isspiderAlive}");
        Console.WriteLine();
        Console.WriteLine($"Did you survive?........:{isplayerAlive}");

    }
    }





