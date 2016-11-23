using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Loop
    {
        public void mainLoop(Player player, Map map, Person[] people)
        {
            while (player.getIsPlaying())
            {
                map.displayLocation(player.getLocation(), people);
                if (player.getLocation() == 7 && !player.getSteveKicked())
                {
                    Console.WriteLine("Punk Rock Steve kicks you with his combat boots!");
                    Console.WriteLine("You lose 5 points!");
                    player.adjustScore(-5);
                }
                Console.Write("Score {0}. Enter command: ", player.getScore().ToString());
                string command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "l":
                    case "look":
                        {
                            map.displayLocation(player.getLocation(), people);
                        }
                        break;
                    case "q":
                    case "quit":
                        {
                            Console.WriteLine("You quit the game.");
                            player.setScore(1);
                            player.setIsPlaying(false);
                        }
                        break;
                    case "n":
                    case "north":
                        {
                            if (map.canTravel(player.getLocation(),"n"))
                            {
                                Console.WriteLine("You go north.");
                                map.travel(player, "n");
                            }
                            else
                            {
                                Console.WriteLine("You can't go north from here.");
                            }
                        }
                        break;
                    case "s":
                    case "south":
                        {
                            if (map.canTravel(player.getLocation(), "s"))
                            {
                                Console.WriteLine("You go south.");
                                map.travel(player, "s");
                            }
                            else
                            {
                                Console.WriteLine("You can't go south from here.");
                            }
                        }
                        break;
                    case "e":
                    case "east":
                        {
                            if (map.canTravel(player.getLocation(), "e"))
                            {
                                Console.WriteLine("You go east.");
                                map.travel(player, "e");
                            }
                            else
                            {
                                Console.WriteLine("You can't go east from here.");
                            }
                        }
                        break;
                    case "w":
                    case "west":
                        {
                            if (map.canTravel(player.getLocation(), "w"))
                            {
                                Console.WriteLine("You go west.");
                                map.travel(player, "w");
                            }
                            else
                            {
                                Console.WriteLine("You can't go west from here.");
                            }
                        }
                        break;
                    case "li":
                    case "list":
                        {
                            Console.WriteLine("Available commands: north, east, west, south, look, rob, fish, talk, search, cut, kick, list.");
                        }
                        break;
                    case "rob":
                    case "rob bank":
                    case "rob the bank":
                        {
                            if (player.getLocation() == 8 && !player.getBankRobbed())
                            {
                                Console.WriteLine("You rob the bank. You get exactly one million dollars.");
                                player.setBankRobbed(true);
                                people[1].setQuestCompleted(true);
                                people[5].setQuestCompleted(true);
                            }
                            else
                            {
                                Console.WriteLine("You can't rob anything right now.");
                            }
                            break;
                        }
                    case "fish":
                    case "catch":
                    case "catch fish":
                        {
                            if (player.getLocation() == 10 && !player.getFishCaught())
                            {
                                Console.WriteLine("You take out your trusty fishing pole and cast into the water. You catch a great big fish!");
                                player.setFishCaught(true);
                                people[2].setQuestCompleted(true);
                                people[6].setQuestCompleted(true);
                            }
                            else
                            {
                                Console.WriteLine("You can't go fishing right now.");
                            }

                        }
                        break;
                    case "search":
                    case "search house":
                    case "search for keys":
                        {
                            if (player.getLocation() == 1 && !player.getfoundKeys())
                            {
                                Console.WriteLine("You search your messy house. You don't find anything. Finally you peel the piece of pizza off the ceiling. Underneath, you find the key to your van!");
                                player.setFoundKeys(true);
                            }
                            else
                            {
                                Console.WriteLine("You search your surroundings, but find nothing of interest.");
                            }

                        }
                        break;
                    case "cut":
                    case "cut hair":
                    case "cut my hair":
                        {
                            if (player.getLocation() == 11 && !player.getHairCut())
                            {
                                Console.WriteLine("You take the pair of scissors and you give yourself a funky haircut.");
                                player.setHairCut(true);
                                people[3].setQuestCompleted(true);
                            }
                            else
                            {
                                Console.WriteLine("You can't cut anything here.");
                            }

                        }
                        break;
                    case "talk":
                    case "talk kelly":
                    case "talk juniper":
                    case "talk bill":
                        {
                            map.talkToPerson(player.getLocation(), people);
                        }
                        break;
                    case "start":
                    case "start van":
                    case "start the van":
                        {
                            if (!player.getfoundKeys())
                            {
                                Console.WriteLine("You don't have the key to your van. How can you start it?");
                                break;
                            }
                            if (!people[1].getQuestComplete())
                            {
                                Console.WriteLine("{0} hasn't agreed to play the gig yet. You can't go yet.", people[1].getName());
                                break;
                            }
                            if (!people[2].getQuestComplete())
                            {
                                Console.WriteLine("{0} hasn't agreed to play the gig yet. You can't go yet.", people[2].getName());
                                break;
                            }
                            if (!people[3].getQuestComplete())
                            {
                                Console.WriteLine("{0} hasn't agreed to play the gig yet. You can't go yet.", people[3].getName());
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You start the van and go to the gig!");
                                player.setGameWon(true);
                                break;
                            }
                        }
                    case "kick":
                    case "kick steve":
                    case "kick punk rock steve":
                        {
                            if (player.getLocation() == 7 && !player.getSteveKicked())
                            {
                                Console.WriteLine("You kick Punk Rock Steve. He falls over and starts to cry.");
                                player.setSteveKicked(true);
                                people[4].setQuestCompleted(true);
                            }
                            else
                            {
                                Console.WriteLine("You can't kick anything now.");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown command. Type list for a list of commands.");
                            break;
                        }
                }
                player.adjustScore(-1);
            }
        }
    }
}
