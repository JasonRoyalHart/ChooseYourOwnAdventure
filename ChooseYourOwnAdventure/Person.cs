using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Person
    {
        string name;
        string questStartSpeech;
        int id;
        string questFinishSpeech;
        bool questCompleted;

        public Person(int id, string name, string questStartSpeech, string questFinishSpeech)
        {
            this.id = id;
            this.name = name;
            this.questStartSpeech = questStartSpeech;
            this.questFinishSpeech = questFinishSpeech;
            this.questCompleted = false;
        }
        public string talk()
        {
            if (!questCompleted)
            {
                return questStartSpeech;
            }
            else
            {
                return questFinishSpeech;
            }
        }
        public string getName()
        {
            return name;
        }
        public string getQuestStartSpeech()
        {
            return questStartSpeech;
        }
        public string getQuestFinishSpeech()
        {
            return questFinishSpeech;
        }
        public bool getQuestComplete()
        {
            return questCompleted;
        }
        public void setQuestCompleted(bool complete)
        {
            questCompleted = complete;
        }
    }

}
