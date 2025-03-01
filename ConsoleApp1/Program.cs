using System;

class Programm
{
    static void Main()
    {
        Console.Write("Hello, please enter your name: ");

        string name = Console.ReadLine();
        bool valid = IsValidName(name);

        if (valid)
        {
            try
            {
                int namelength = name.Length;
                char firstletter = name[0];

                Console.WriteLine("Hello " + char.ToUpper(name[0]) + name.Substring(1) + "!");
                Console.WriteLine("Your name has " + namelength + " letters.");
                Console.Write("The first letter is " + firstletter + ".");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        else
        {
            Console.WriteLine("That's not a name!");
        }
    }
    static bool IsValidName(string name)
    {
        foreach (char letter in name)
        {
            if (!char.IsLetter(letter))
            {
                return false;
            }
        }                 
        return true;
    }
}