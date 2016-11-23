using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Map
    {
        Square[] locations = new Square[12];
        public Map()
        {
            Square yourHouse = new Square(1, 2, 0, 0, 0, "You see your house. It is very messy. Pizza is stuck to the ceiling.",0);
            locations[1] = yourHouse;
            Square theStreet = new Square(2, 3, 4, 5, 1, "You are in the street. The street is black and freshly paved.",0);
            locations[2] = theStreet;
            Square billsHouse = new Square(3, 0, 0, 0, 2, "You are in Bill's House.",1);
            locations[3] = billsHouse;
            Square theStreetTwo = new Square(4, 6, 7, 2, 8, "You are in the street. This part of the street is full of potholes and weeds.",0);
            locations[4] = theStreetTwo;
            Square theGarage = new Square(5, 0, 2, 0, 0, "You are in the garage. Your van is here.",0);
            locations[5] = theGarage;
            Square junipersHouse = new Square(6, 0, 0, 0, 4, "You are in Juniper's House.",2);
            locations[6] = junipersHouse;
            Square theStreetThree = new Square(7, 9, 10, 4, 11, "You are in the street. The street here has broken down into gravel and bits of concrete.",4);
            locations[7] = theStreetThree;
            Square theBank = new Square(8, 4, 0, 0, 0, "You are in the bank. Seems like this place would be pretty easy to rob.",5);
            locations[8] = theBank;
            Square kellysHouse = new Square(9, 0, 0, 0, 7, "You are in Kelly's house.",3);
            locations[9] = kellysHouse;
            Square thePond = new Square(10, 0, 0, 7, 0, "You are at the pond. It looks like you could catch a fish here.",6);
            locations[10] = thePond;
            Square barberShop = new Square(11, 7, 0, 0, 0, "You are in the DIY Barber Shop. A pair of scissors waits for you to use on yourself.",0);
            locations[11] = barberShop;



        }
        public void displayLocation(int location, Person[] people)
        {
            Console.WriteLine(locations[location].displayLocation());
            if (locations[location].getPerson() != 0)
            {
                int thePerson = locations[location].getPerson();
                Console.WriteLine(people[thePerson].getName() + " is here.");
            }
        }

        public bool canTravel(int location, string direction)
        {
            bool answer;
            switch (direction)
            {
                case "n":
                    if (locations[location].getNorth() != 0)
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }
                    break;
                case "e":
                    if (locations[location].getEast() != 0)
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }
                    break;
                case "w":
                    if (locations[location].getWest() != 0)
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }
                    break;
                case "s":
                    if (locations[location].getSouth() != 0)
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }
                    break;
                default:
                    answer = false;
                    break;
            }
            return answer;
        }
        public void travel (Player player, string direction)
        {
            switch (direction)
            {
                case "n":
                    player.setLocation(locations[player.getLocation()].getNorth());
                    break;
                case "e":
                    player.setLocation(locations[player.getLocation()].getEast());
                    break;
                case "w":
                    player.setLocation(locations[player.getLocation()].getWest());
                    break;
                case "s":
                    player.setLocation(locations[player.getLocation()].getSouth());
                    break;
            }
        }
        public void talkToPerson(int location, Person[] people)
        {
            int thePerson = locations[location].getPerson();
            if (thePerson != 0)
            {
                Person personTalking = people[thePerson];
                if (personTalking.getQuestComplete())
                {
                    Console.WriteLine(personTalking.getQuestFinishSpeech());
                }
                else
                {
                    Console.WriteLine(personTalking.getQuestStartSpeech());
                }
            }
        }
    }
}
