public class QuestList
{
    public List<PlayerQuest> QuestLog;

    public QuestList()
    {
        this.QuestLog = new List<PlayerQuest>();
    }

    public void AddQuest(PlayerQuest Quest)
    {
        int count = 0;
        foreach (PlayerQuest i in QuestLog) 
        {
            if (i.TheQuest.ID == Quest.TheQuest.ID) 
            {
                count++;
            }
        }

        if (count == 0)
        {
            this.QuestLog.Add(Quest);
        }
    }
}