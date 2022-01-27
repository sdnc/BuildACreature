using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      RandomMode();
    }

    static void BuildACreature(string head, string body, string feet)
    {
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);

      SwitchCase(headNum, bodyNum, feetNum);
    }

    static void RandomMode()
    {
      Random randomNumber = new Random();
      int head = randomNumber.Next(1, 4);
      int body = randomNumber.Next(1, 4);
      int feet = randomNumber.Next(1, 4);

      SwitchCase(head, body, feet);
    }

    static void SwitchCase(int head, int body, int feet)
    {
      switch (head)
      {
        case 1:
        GhostHead();
        break;
        case 2:
        MonsterHead();
        break;
        case 3:
        BugHead();
        break;
      }
      switch (body)
      {
        case 1:
        GhostBody();
        break;
        case 2:
        MonsterBody();
        break;
        case 3:
        BugBody();
        break;
      }
      switch (feet)
      {
        case 1:
        GhostFeet();
        break;
        case 2:
        MonsterFeet();
        break;
        case 3:
        BugFeet();
        break;
      }
    }
    
    static int TranslateToNumber(string creature)
    {
      switch (creature)
      {
        case "ghost":
        return 1;
        break;
        case "monster":
        return 2;
        break;
        case "bug":
        return 3;
        break;
        default:
        return 1;
        break;
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}

/*
TO-DO's:
- Extend the BuildACreature() method so that all of its parameters are optional. 
It should assign a random body part if a parameter is not specified.

- Recreate this program so that rather than outputting a creature immediately, 
it prompts a user to select which parts of each creature to use to build a new creature.

- Add a starting mode, so a user can select whether to randomly generate a creature or create one manually.

- Use this ASCII art archive to add other body parts to the program.
https://www.asciiart.eu/animals
*/