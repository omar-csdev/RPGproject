//Room 1 == Your house
//Room 2 == Town Square
//Room 3 == Farmer
//Room 4= Farmers Field
//Room 5 = Alchemists hut
//6: Alchemist’s garden​
//7: Guard post​
//8: Bridge​
//9: Spider forest



using System;

int room = 1;
int prompt = 0;
Console.WriteLine("Useful commands:\r\n- (/N/E/S/W)  \r\n- inspect compass \r\n-quit");

bool asking = true;
while (asking)
{
    while (room == 1)
    {
        if (prompt == 0)
        {
            Console.WriteLine("Your house");
            Console.WriteLine("This is where you live.");
            Console.WriteLine(">>  ");
            string room1 = Console.ReadLine();
            if (room1.ToLower() == "inspect compass")
            {
                Console.WriteLine("    N\r\n    |");
            }
            else if (room1.ToUpper() == "N")
            {
                room = 2;
                prompt = 0;
            }
            else if (room1.ToUpper() == "E" || room1.ToUpper() == "S" || room1.ToUpper() == "W")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I Dont understand that command");
            }
        }
    }
    while (room == 2)
    {
        if (prompt == 0)
        {
            Console.WriteLine("TownSquare");
            Console.WriteLine("This is the townsquare.");
            Console.WriteLine(">>  ");
            string room1 = Console.ReadLine();
            if (room1.ToLower() == "inspect compass")
            {
                Console.WriteLine("    N\r\n    |\r\nW---|---E\r\n    |\r\n    S");
            }
            if (room1.ToUpper() == "N")
            {
                room = 5;
                prompt = 0;
            }
            else if (room1.ToUpper() == "E")
            {
                room = 7;
                prompt = 0;
            }
            else if (room1.ToUpper() == "S")
            {
                room = 1;
                prompt = 0;
            }
            else if (room1.ToUpper() == "W")
            {
                room = 3;
                prompt = 0;
                Console.WriteLine("Farmer's place");
            }
            else if (room1.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I Dont understand that command");
            }
        }
    }

    while (room == 3)
    {
        if (prompt == 0)
        {
            Console.WriteLine("Farmer's place");
            Console.WriteLine("This is the Farmer's place");
            Console.WriteLine(">>  ");
            string room1 = Console.ReadLine();
            if (room1.ToLower() == "isnpect compass")
            {
                Console.WriteLine("W---|---E");
            }
            else if (room1.ToUpper() == "N")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToUpper() == "E")
            {
                room = 2;
                prompt = 0;
            }
            else if (room1.ToUpper() == "S")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToUpper() == "W")
            {
                Console.WriteLine("There is a Field over here.");
                room = 4;
                prompt = 0;
            }
            else if (room1.ToLower() == "quit")
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("I Dont understand that command");
            }
        }
    }
    while (room == 4)
    {
        if (prompt == 0)
        {
            Console.WriteLine("Farmer's Field");
            Console.WriteLine("This looks like a harvest field. Maybe u cand do something here.");
            Console.WriteLine(">>  ");
            string room1 = Console.ReadLine();
            Console.WriteLine(room1);
            if (room1.ToLower() == "isnpect compass")
            {
                Console.WriteLine("    |---E");
            }
            else if (room1.ToUpper() == "N")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToUpper() == "E")
            {
                Console.WriteLine("Farmer's place");
                room = 3; 
                prompt = 0;
            }
            else if (room1.ToUpper() == "S")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToUpper() == "W")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I Dont understand that command");
            }
        }
    }

    while (room == 5)
    {
        if (prompt == 0)
        {
            Console.WriteLine("Alchemist’s hut");
            Console.WriteLine("There seems to be a alchemist over here. Let's check this place out");
            Console.WriteLine(">>  ");
            string room1 = Console.ReadLine();
            Console.WriteLine(room1);
            if (room1.ToLower() == "isnpect compass")
            {
                Console.WriteLine("    N\r\n    |\r\n    |\r\n    |\r\n    S");
            }
            else if (room1.ToUpper() == "N")
            {
                room = 6;
                prompt = 0;
            }
            else if (room1.ToUpper() == "E")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToUpper() == "S")
            {
                room = 2;
                prompt = 0;
            }
            else if (room1.ToUpper() == "W")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I Dont understand that command");
            }
        }
    }

    while (room == 6)
    {
        if (prompt == 0)
        {
            Console.WriteLine("Alchemist’s garden");
            Console.WriteLine(">>  ");
            string room1 = Console.ReadLine();
            Console.WriteLine(room1);
            if (room1.ToLower() == "isnpect compass")
            {
                Console.WriteLine("    |\r\n    S");
            }
            else if (room1.ToUpper() == "N")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToUpper() == "E")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToUpper() == "S")
            {
                room = 5;
                prompt = 0;
            }
            else if (room1.ToUpper() == "W")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I Dont understand that command");
            }
        }
    }

    while (room == 7)
    {
        if (prompt == 0)
        {
            Console.WriteLine("Guard post");
            Console.WriteLine(">>  ");
            string room1 = Console.ReadLine();
            Console.WriteLine(room1);
            if (room1.ToLower() == "isnpect compass")
            {
                Console.WriteLine("W---|---E");
            }
            else if (room1.ToUpper() == "E")
            {
                room = 8;
                prompt = 0;
            }
            else if (room1.ToUpper() == "W") 
            {
                room = 6;
                prompt = 0;
            }
            else if (room1.ToUpper() == "S" || room1.ToUpper() == "N")
            {
                Console.WriteLine("There is a river here, you can't walk onto that.");
            }
            else if (room1.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I Dont understand that command");
            }
        }
    }

    while (room == 8)
    {
        if (prompt == 0)
        {
            Console.WriteLine("Bridge");
            Console.WriteLine(">>  ");
            string room1 = Console.ReadLine();
            Console.WriteLine(room1);
            if (room1.ToLower() == "isnpect compass")
            {
                Console.WriteLine("W---|---E");
            }
            else if (room1.ToUpper() == "N")
            {
                Console.WriteLine("The road seems to be blocked by fallen trees and rocks. U can't go here.");
            }
            else if (room1.ToUpper() == "E")
            {
                Console.WriteLine("There seems to be a spider forest ");
                room = 9;
                prompt = 0;
            }
            else if (room1.ToUpper() == "S")
            {
                Console.WriteLine("The road seems to be blocked by fallen trees and rocks. U can't go here.");
            }
            else if (room1.ToUpper() == "W")
            {
                Console.WriteLine("You went back to the Guards post");
                room = 7;
                prompt = 0;
            }
            else if (room1.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I Dont understand that command");
            }
        }
    }
    while (room == 9)
    {
        if (prompt == 0)
        {
            Console.WriteLine("Spider forest");
            Console.WriteLine(">>  ");
            string room1 = Console.ReadLine();
            Console.WriteLine(room1);
            if (room1.ToLower() == "isnpect compass")
            {
                Console.WriteLine("W---|");
            }
            else if (room1.ToUpper() == "N")
            {
                Console.WriteLine("You can't go here");
            }
            else if (room1.
                ToUpper() == "E")
            {
                Console.WriteLine("There seems to be a large forest blocking the road.");
            }
            else if (room1.ToUpper() == "S")
            {
                Console.WriteLine("The road seems to be blocked by fallen trees and rocks. U can't go here.");
            }
            else if (room1.ToUpper() == "W")
            {
                
                Console.WriteLine("You went back to the bridge");
                room = 8;
                prompt = 0;
            }
            else if (room1.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I Dont understand that command");
            }
        }
    }
}



