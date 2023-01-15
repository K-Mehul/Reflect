using UnityEngine;

public class Treasure : MonoBehaviour, IInteract
{
    public FloatVar Levels;

    public void Interactables()
    {
        GameManager.Instance.IsTotalEventsComplete = false;
        UIManager.Instance.ActivateScreen(2);
        if(GameManager.Instance.CurrentSceneIndex == Levels.floatVariable + 1)
            GameManager.Instance.levelLoader.LevelUnlock();
    }
}