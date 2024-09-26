using System.Reflection.Metadata.Ecma335;

Console.WriteLine("You come up to a small cliff edge.");
Console.WriteLine("to the left you can see a fire going just up the mountain.");
Console.WriteLine("To the right just down the cliff you see a village.");

// which way to go?
Console.WriteLine("");
Console.WriteLine("Do you want to go towards the fire on the MOUNTAIN or VILLAGE.");
string direction = Console.ReadLine();
bool progress = false;
string purchase;
int playerCurrency = 5000;
string decision;

direction = direction.ToLower();
// (left) mountain
if (direction == "mountain")
{    
    progress = true;
}
// (right) village
else if (direction == "village")
{ 
    progress = true;
}
// handles input that isnt left or right
else
{
    Console.WriteLine("");
    Console.WriteLine("You fell off the cliff and didnt make it");
    progress = false;
}

// checking if the the bool is set to true and the player chose to go towards the mountain
if (progress == true && direction == "mountain")
{
    progress = false;
    Console.Clear();
    Console.WriteLine("You chose to head towards the fire on the mountain.");
    Console.WriteLine();
    Console.WriteLine("You come across a small camp.");
    Console.WriteLine("");
    Console.WriteLine("An old man greets you and offers for you to sit down and have a drink with them.");
    Console.WriteLine("After talking and having a drink, they offer you a really old looking map.");
    Console.WriteLine("");
    Console.WriteLine("Do you take the map?");
    decision = Console.ReadLine();
    decision.ToLower(); // taking the players input and forcing the string into all lower case

    if (decision == "yes")
    {
        Console.Clear();
        Console.WriteLine("You take the map.");
        Console.WriteLine("After taking the map the old man says that: An adventure awaits you. Be safe.");
        
        Console.WriteLine("");
        Console.WriteLine("You follow the map and it leads you to a cave");
        Console.WriteLine("");
        Console.WriteLine("Do you enter?");
        decision = Console.ReadLine();
        decision = decision.ToLower(); // taking the players input and forcing the string into all lower case

        // if you decide to follow the map
        if (decision == "yes")
        {
            Console.Clear();
            Console.WriteLine("After entering you continue following the map which leads to you a hole in the wall with a lever inside.");
            Console.WriteLine("");
            Console.WriteLine("Do you pull the lever?");
            decision = Console.ReadLine();
            decision = decision.ToLower();

            if(decision == "yes")
            {
                // pull lever
                Console.Clear();
                Console.WriteLine("You pull the lever and a giant stone door opens.");
                Console.WriteLine("This reaveals a grand room filled with ancient artifacts.");
            }
            else
            {
                // turn back and go to inn
                Console.Clear();
                Console.WriteLine("You decide not to enter and head down to the village to sleep at the inn.");
            }
        }
        // not following map
        else
        {
            Console.Clear();
            Console.WriteLine("You decide not to enter and head down to the village to sleep at the inn.");
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Thats quite alright. Have a nice day.");
    }
}

// checking if the the bool is set to true and the player chose to go towards the village
if (progress == true && direction == "village")
{
    progress = false;
    Console.Clear();
    Console.WriteLine("You chose to head towards the village.");
    Console.WriteLine("");
    Console.WriteLine("You meet a outgoing villager who recognizes that you are from out of town, and pulls you into his shop.");
    Console.WriteLine("They show you what they have for purchase.");
    Console.WriteLine("");
    Console.WriteLine("Sword - 3500");
    Console.WriteLine("Armor - 4500");
    Console.WriteLine("Gaunlet - 1500");
    purchase = Console.ReadLine();
    purchase = purchase.ToLower();

    // handling each purchase
    if (purchase == "sword")
    {
        playerCurrency -= 3500; // subtracting the price of the item from the players currency
        Console.WriteLine("");
        Console.WriteLine("You have purchased a sword.");
        Console.WriteLine($"You have {playerCurrency} left.");
        Console.WriteLine("After making your purchase you decide to stay at the village inn to rest for the night.");
    }
    else if (purchase == "armor")
    {
        playerCurrency -= 4500; // subtracting the price of the item from the players currency
        Console.WriteLine("");
        Console.WriteLine("You have purchased armor");
        Console.WriteLine($"You have {playerCurrency} left.");
        Console.WriteLine("After making your purchase you decide to stay at the village inn to rest for the night.");
    }
    else if (purchase == "gauntlet")
    {
        playerCurrency -= 1500; // subtracting the price of the item from the players currency
        Console.WriteLine("");
        Console.WriteLine("You have purchased a gauntlet");
        Console.WriteLine($"You have {playerCurrency} left.");
        Console.WriteLine("After making your purchase you decide to stay at the village inn to rest for the night.");
    }
    else // get kicked out of purchase for not giving correct input
    {
        Console.WriteLine("");
        Console.WriteLine("Dont waste my time");
    }
}

