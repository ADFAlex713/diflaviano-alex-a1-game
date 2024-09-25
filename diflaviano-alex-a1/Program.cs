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
    Console.WriteLine("");
    Console.WriteLine("You chose to head towards the fire on the mountain.");
    progress = true;
}
// (right) village
else if (direction == "village")
{
    Console.WriteLine("");
    Console.WriteLine("You chose to head towards the village.");
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
    Console.WriteLine("");
    Console.WriteLine("You come across a wandering traders camp.");
    Console.WriteLine("They greet you and offer you to trade.");
    // showing the player their options for purchase
    Console.WriteLine("Potion - 500 shards");
    Console.WriteLine("Axe - 2500 shards");
    Console.WriteLine("Map - 300 shards");
    purchase = Console.ReadLine();
    purchase.ToLower(); // taking the players input and forcing the string into all lower case

    // handling each purchase
    if (purchase == "potion")
    {
        playerCurrency -= 500; // subtracting the price of the item from the players currency
        Console.WriteLine("");
        Console.WriteLine("You have purchased a potion!");
        Console.WriteLine($"You have {playerCurrency} left.");
        Console.WriteLine("");
        Console.WriteLine("After making your purchase you decide to make camp in a cave and rest for the night.");
    }
    else if (purchase == "axe")
    {
        playerCurrency -= 2500; // subtracting the price of the item from the players currency
        Console.WriteLine("");
        Console.WriteLine("You have purchased an axe!");
        Console.WriteLine($"You have {playerCurrency} left.");
        Console.WriteLine("After making your purchase you decide to make camp in a cave and rest for the night.");
    }
    else if (purchase == "map")
    {
        playerCurrency -= 300; // subtracting the price of the item from the players currency
        Console.WriteLine("");
        Console.WriteLine("You have purchased a map!");
        Console.WriteLine($"You have {playerCurrency} left.");
        Console.WriteLine("");
        Console.WriteLine("You start to inspect the map. Do you follow it?");
        decision = Console.ReadLine();
        decision = decision.ToLower(); // taking the players input and forcing the string into all lower case

        // if you decide to follow the map
        if (decision == "yes")
        {
            Console.WriteLine("");
            Console.WriteLine("You decide to follow the map and it leads you to a hidden room in a small building in the village.");
            Console.WriteLine("You find a large amount of shards and treasure");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("You decide not to follow the map today and make camp in a cave and rest for the night.");
        }
    }
    else // get kicked out of purchase for not giving correct input
    {
        Console.WriteLine("");
        Console.WriteLine("Dont waste my time");
    }
}

// checking if the the bool is set to true and the player chose to go towards the village
if (progress == true && direction == "village")
{
    progress = false;
    Console.WriteLine("");
    Console.WriteLine("You meet a outgoing villager who recognizes that you are from out of town, and pulls you into his shop.");
    Console.WriteLine("They show you what they have for purchase.");
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

