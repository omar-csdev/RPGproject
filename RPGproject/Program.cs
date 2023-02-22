//Room 1 == Your house
//Room 2 == Town Square
//Room 3 == Farmer
//Room 4= Farmers Field
//Room 5 = Alchemists hut
//6: Alchemist’s garden​
//7: Guard post​
//8: Bridge​
//9: Spider forest



int room = 1;
int prompt = 0;
Console.WriteLine("Useful commands:\r\n- (/N/E/S/W) , inspect map, quit");
while (room == 1)
{
    if (prompt == 0)
    {
        Console.WriteLine("Your house");
        Console.WriteLine("This is where you live.");
        prompt = 1;
        Console.WriteLine(">>  ");
        string room1 = Console.ReadLine();
        Console.WriteLine(room1);
        if (room1.ToLower() == "N")
        {
            room = 2;
            prompt = 0;
        }
        else if (room1.ToLower() == "E" || room1.ToLower() == "S" || room1.ToLower() == "W")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "quit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("I Dont understand that commend");
        }
    }
}
while (room == 2)
{
    if (prompt == 0)
    {
        Console.WriteLine("TownSquare");
        Console.WriteLine("This is the townsquare.");
        prompt = 1;
        Console.WriteLine(">>  ");
        string room1 = Console.ReadLine();
        if (room1.ToLower() == "N")
        {
            room = 5;
            prompt = 0;
        }
        else if (room1.ToLower() == "E")
        {
            room = 7;
            prompt = 0;
        }
        else if (room1.ToLower() == "S")
        {
            room = 1;
            prompt = 0;
        }
        else if (room1.ToLower() == "W")
        {
            room = 3;
            prompt = 0;
            Console.WriteLine("Farmer's place");
        }
        else if (room1.ToLower() == "quit")
        {
            Environment.Exit(0);
        }
    }
}
while (room == 3)
{
    if (prompt == 0)
    {
        Console.WriteLine("Farmer's place");
        Console.WriteLine("This is the Farmer's place");
        prompt = 1;
        Console.WriteLine(">>  ");
        string room1 = Console.ReadLine();
        if (room1.ToLower() == "N")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "E")
        {
            room = 2;
            prompt = 0;
        }
        else if (room1.ToLower() == "S")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "W")
        {
            Console.WriteLine("There is a Field over here.");
            room = 4;
            prompt = 0;
        }
        else if (room1.ToLower() == "quit")
        {
            Environment.Exit(0);
        }
    }
}
while (room == 4)
{
    if (prompt == 0)
    {
        Console.WriteLine("Farmer's Field");
        Console.WriteLine("This looks like a harvest field. Maybe u cand do something here.");
        prompt = 1;
        Console.WriteLine(">>  ");
        string room1 = Console.ReadLine();
        Console.WriteLine(room1);
        if (room1.ToLower() == "N")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "E")
        {
            Console.WriteLine("Farmer's place");
        }
        else if (room1.ToLower() == "S")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "W")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "quit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("I Dont understand that commend");
        }
    }
}

while (room == 5)
{
    if (prompt == 0)
    {
        Console.WriteLine("Alchemist’s hut");
        Console.WriteLine("There seems to be a alchemist over here. Let's check this place out");
        prompt = 1;
        Console.WriteLine(">>  ");
        string room1 = Console.ReadLine();
        Console.WriteLine(room1);
        if (room1.ToLower() == "N")
        {
            room = 6;
            prompt = 0;
        }
        else if (room1.ToLower() == "E")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "S")
        {
            room = 2;
            prompt = 0;
        }
        else if (room1.ToLower() == "W")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "quit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("I Dont understand that commend");
        }
    }
}

while (room == 6)
{
    if (prompt == 0)
    {
        Console.WriteLine("Alchemist’s garden");
        prompt = 1;
        Console.WriteLine(">>  ");
        string room1 = Console.ReadLine();
        Console.WriteLine(room1);
        if (room1.ToLower() == "N")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "E")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "S")
        {
            room = 5;
            prompt = 0;
        }
        else if (room1.ToLower() == "W")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "quit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("I Dont understand that commend");
        }
    }
}

while (room == 7)
{
    if (prompt == 0)
    {
        Console.WriteLine("Guard post");
        prompt = 1;
        Console.WriteLine(">>  ");
        string room1 = Console.ReadLine();
        Console.WriteLine(room1);
        if (room1.ToLower() == "E")
        {
            room = 8;
            prompt = 0;
        }
        else if (room1.ToLower() == "S" || room1.ToLower() == "N" || room1.ToLower() == "W")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "quit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("I Dont understand that commend");
        }
    }
}

while (room == 8)
{
    if (prompt == 0)
    {
        Console.WriteLine("Bridge");
        prompt = 1;
        Console.WriteLine(">>  ");
        string room1 = Console.ReadLine();
        Console.WriteLine(room1);
        if (room1.ToLower() == "N")
        {
            room = 2;
            prompt = 0;
        }
        else if (room1.ToLower() == "E")
        {
            Console.WriteLine("There seems to be a spider forest ");
        }
        else if (room1.ToLower() == "S")
        {
            Console.WriteLine("The road seems to be blocked by fallen trees and rocks. U can't go here.");
        }
        else if (room1.ToLower() == "W")
        {
            Console.WriteLine("There is a river here, you can't walk onto that.");
        }
        else if (room1.ToLower() == "quit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("I Dont understand that commend");
        }
    }
}
while (room == 9)
{
    if (prompt == 0)
    {
        Console.WriteLine("Spider forest");
        prompt = 1;
        Console.WriteLine(">>  ");
        string room1 = Console.ReadLine();
        Console.WriteLine(room1);
        if (room1.ToLower() == "N")
        {
            Console.WriteLine("You can't go here");
        }
        else if (room1.ToLower() == "E")
        {
            Console.WriteLine("There seems to be a large forest blocking the road.");
        }
        else if (room1.ToLower() == "S")
        {
            Console.WriteLine("The road seems to be blocked by fallen trees and rocks. U can't go here.");
        }
        else if (room1.ToLower() == "W")
        {
            Console.WriteLine("You went back to the bridge");
        }
        else if (room1.ToLower() == "quit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("I Dont understand that commend");
        }
    }
}

