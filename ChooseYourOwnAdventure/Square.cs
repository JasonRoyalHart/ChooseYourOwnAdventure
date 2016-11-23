using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Square
    {
        int id;
        int north;
        int east;
        int west;
        int south;
        int person;
        string description;

        public Square(int id, int north, int east, int west, int south, string description, int person)
        {
            this.id = id;
            this.north = north;
            this.east = east;
            this.west = west;
            this.south = south;
            this.description = description;
            this.person = person;

        }
        public string displayLocation()
        {
            string returnString = description + " | Exits: ";
            if (this.north != 0)
            {
                returnString += "N ";
            }
            if (this.east != 0)
            {
                returnString += "E ";
            }
            if (this.west != 0)
            {
                returnString += "W ";
            }
            if (this.south != 0)
            {
                returnString += "S ";
            }

            return returnString;
        }
        public int getNorth()
        {
            return north;
        }
        public int getEast()
        {
            return east;
        }
        public int getWest()
        {
            return west;
        }
        public int getSouth()
        {
            return south;
        }
        public int getPerson()
        {
            return person;
        }
    }

}
