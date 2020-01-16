// https://scottlilly.com/build-a-cwpf-rpg/lesson-06-2-using-quests-in-the-game/

namespace Engine.Models
{
    public class QuestStatus
    {
        public Quest PlayerQuest { get; set; }
        public bool IsComplete { get; set; }

        public QuestStatus(Quest quest)
        {
            PlayerQuest = quest;
            IsComplete = false;
        }
    }
}
