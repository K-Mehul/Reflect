using UnityEngine.UI;

[System.Serializable]
public class LevelLoader
{
    public Button[] totalLevels;
    public FloatVar level;

    public void LevelUnlock()
    {
        level.floatVariable += 1;
        Level();
    }

    public void Level()
    {
        for (int i = 0; i < totalLevels.Length; i++)
        {
            totalLevels[i].interactable = false;
            if (i <= level.floatVariable)
            {
                totalLevels[i].interactable = true;
            }
        }
    }
}
