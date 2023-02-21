public class PlayerQuest
{
    public Quest TheQuest;
    public bool isCompleted;

    public PlayerQuest(Quest theQuest)
    {
        this.TheQuest = theQuest;
    }

    public void CompleteQuest()
    {
        this.isCompleted = true;
    }
}