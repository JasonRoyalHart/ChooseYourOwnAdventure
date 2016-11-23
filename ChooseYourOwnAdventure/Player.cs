using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Player
    {
        string name;
        string bandName;
        int score;
        int location;
        bool isPlaying;
        bool bankRobbed;
        bool fishCaught;
        bool foundKeys;
        bool hairCut;
        bool gameWon;
        bool steveKicked;


        public Player()
        {
            this.score = 1000;
            this.location = 1;
            this.isPlaying = true;
            this.bankRobbed = false;
            this.fishCaught = false;
            this.foundKeys = false;
            this.hairCut = false;
            this.gameWon = false;
            this.steveKicked = false;
        }
        public bool getIsPlaying()
        {
            return isPlaying;
        }
        public bool getGameWon()
        {
            return gameWon;
        }
        public void setIsPlaying(bool setting)
        {
            isPlaying = setting;
        }
        public void setLocation(int newLocation)
        {
            location = newLocation;
        }
        public void setGameWon(bool won)
        {
            gameWon = won;
            isPlaying = false;
        }

        public void setName()
        {
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("What is your band's name? ");
            bandName = Console.ReadLine();
        }
        public string getName()
        {
            return name;
        }
        public int getLocation()
        {
            return location;
        }
        public string getBandName()
        {
            return bandName;
        }
        public bool getBankRobbed()
        {
            return bankRobbed;
        }
        public void setBankRobbed(bool robbed)
        {
            bankRobbed = robbed;
        }
        public bool getFishCaught()
        {
            return fishCaught;
        }
        public void setFishCaught(bool caught)
        {
            fishCaught = caught;
        }
        public bool getHairCut()
        {
            return hairCut;
        }
        public void setHairCut(bool cut)
        {
            hairCut = cut;
        }
        public bool getfoundKeys()
        {
            return foundKeys;
        }
        public bool getSteveKicked()
        {
            return steveKicked;
        }
        public void setFoundKeys(bool found)
        {
            foundKeys = found;
        }
        public void setSteveKicked(bool kicked)
        {
           steveKicked = kicked;
        }
        public void adjustScore(int points)
        {
            score += points;
        }
        public void setScore(int points)
        {
            score = points;
        }
        public int getScore()
        {
            return score;
        }
    }
}
