using System;

namespace Exercice2
{
    class Program
    {    /*
           The code provided in exercice #2 has an if/else smell. It's not easy to  read, test and maintain.
           If in the future another class called one or many Messages objects are added, then 1 or many if/else statement will be added as well.
           To fix this issue, we will use Polymorphisme. In my case, I prefered to add one more abstract layer through a Stratgey pattern. 
           It could be also be combined with a factory/builder but it will be an overkill. 
        */
        static void Main(string[] args)
        {

            var messageDirector = new MessageStrategyDirector(new MessageA());
            messageDirector.CustomMessage();

            messageDirector = new MessageStrategyDirector(new MessageB());
            messageDirector.CustomMessage();

            messageDirector = new MessageStrategyDirector(new MessageC());
            messageDirector.CustomMessage();

            Console.WriteLine("Please press any key to exit");
            Console.ReadLine();


        }
      }
    }
