using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* The Mysterious Noise */

      // Input - User's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

    // Introduction - Noise Choice

     Console.WriteLine(
        "It begins on a cold rainy night. You're sitting next to your campfire in the open woods trying to keep warm. You hear a sudden noise coming from the bushes. Do you go investigate?");

     Console.Write("Type YES or NO: ");
     string noiseChoice = 
Console.ReadLine();
      noiseChoice = 
noiseChoice.ToUpper();
      
    if (noiseChoice == "NO")
    {
      Console.WriteLine("Not much of an adventure!");

      Console.WriteLine("THE END");
    }
      else if (noiseChoice == "YES")
      {
        Console.WriteLine(
            "You walk towards the bushes on the edge of your campsite. You notice a light flickering in the distance. Strange, these woods are supposed to be abandoned..");
        Console.WriteLine(
            "You start walking towards the light, but then you hesitate. Do you continue up the path?");

    // Path Choice 

        Console.Write("Type YES or NO: ");
        string pathChoice = 
  Console.ReadLine();
        pathChoice = 
  pathChoice.ToUpper();
      
      if (pathChoice == "NO")
      {
        Console.WriteLine(
            "Probably the safest option.");
        Console.WriteLine(
            "THE END");
      }
      else if (pathChoice == "YES")
      {
        Console.WriteLine(
            "You continue venturing up the path. You now find yourself standing before a creaking shack. The light is flickering through the window. Do you knock on the door?");
    
    // Door Choice

      Console.Write("Type OPEN or KNOCK: ");
      string doorChoice =
  Console.ReadLine();
      doorChoice =
  doorChoice.ToUpper();

      if (doorChoice == "KNOCK")
      {
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \""
        );
        Console.WriteLine("\"What has roots as nobody sees, is taller than trees, up it goes, and yet never grows?\"");
        Console.Write("Typer your answer: ");
        string riddleAnswer = 
Console.ReadLine();
        riddleAnswer = 
riddleAnswer.ToUpper();

// Correct answer - Mountain

        if (riddleAnswer == "MOUNTAIN")
        {
          Console.WriteLine(
            "The light goes out and the door creaks open. You hear a cackle and see a pair of glowing red eyes staring back at you.");
          Console.WriteLine(
            "You suddenly wake up, back in your tent. Maybe it was just a bad dream...");
          Console.WriteLine(
            "THE END");
        }
        else 
        {
          Console.WriteLine(
            "You answered incorrectly. The door doesn't open.");
          Console.WriteLine(
            "THE END");
        }
      }

// Key Choice - Switch Statement

      else if (doorChoice == "OPEN")
      {
        Console.WriteLine(
            "The door is locked! You notice three keys sitting on the window pane. Let's see if one of these will open it.");
        Console.Write(
            "Enter a number (1-3): ");
        string keyChoice = 
Console.ReadLine();

        switch(keyChoice)
        {
          case "1":
          Console.WriteLine(
            "You choose the first key. Correct choice!");
          Console.WriteLine(
            "The light goes out and the door creaks open. You hear a cackle and see a pair of glowing red eyes staring back at you.");
          Console.WriteLine(
            "THE END.");
          break;
          
          case "2":
          Console.WriteLine(
            "You choose the second key. The door doesn't open.");
          Console.WriteLine(
            "THE END");
          break;

          case "3":
          Console.WriteLine(
            "You choose the third key. The door doesn't open.");
          Console.WriteLine(
            "THE END");
          break;
        }
      }
    }
  }
    }
  }
}



