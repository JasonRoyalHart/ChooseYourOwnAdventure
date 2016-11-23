using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Game
    {
        public void introduction(Player player)
        {
            Console.WriteLine("Welcome {0}!", player.getName());
            Console.WriteLine("Your band, {0}, has booked the gig of its life, headlining at the Palace!", player.getBandName());
            Console.WriteLine("You must assemble your band and find your van in order to get to the gig on time.");
        }
        public void gameOver(Player player)
        {
            if (player.getGameWon())
            {
                Console.WriteLine("You got to the gig! You play a magnificent show. You get a record deal! You win!");
            }
            else
            {
                Console.WriteLine("You lost the game. :( :( :(");
            }
            Console.WriteLine("Your final score is {0}.", player.getScore().ToString());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public void makePeople(Person[] people)
        {
            Person bill = new Person(1, "Bill", "Bill says, 'I'll only play the gig if you give me a million dollars.'", "Bill says, 'Thanks for the cool mill, now I can pay off my gambling debts! I'll play the gig now.'");
            Person juniper = new Person(2, "Juniper", "Juniper says, 'Sure, I'll play the gig - if you bring me a fresh fish.'", "Juniper says, 'I'll totally play the gig with you now, as soon as I eat this fish.'");
            Person kelly = new Person(3, "Kelly", "Kelly says, 'I'd never play a gig with someone who has hair as horrible as yours. Get a haircut and I might consider it.'", "Kelly says, 'You got some funky fresh style now. Let's go to the gig!'");
            Person steve = new Person(4, "Punk Rock Steve", "Punk Rock Steve says, 'I hate rock and roll! Take this!'", "Punk Rock Steve says, 'Ugh! I'm done for.'");
            Person banker = new Person(5, "The Banker", "The Banker says, 'We have no security. Please don't rob us.'", "The Banker says, 'Why did you rob us? Now we're broke.'");
            Person fisher = new Person(6, "Jim", "Jim says, 'Fishing here is pretty great. I caught five already!'", "Jim says, 'Nice fish.'");
            people[1] = bill;
            people[2] = juniper;
            people[3] = kelly;
            people[4] = steve;
            people[5] = banker;
            people[6] = fisher;

        }
    }
    
}
