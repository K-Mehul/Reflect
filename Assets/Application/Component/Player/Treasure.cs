using UnityEngine;

public class Treasure : MonoBehaviour, IInteract
{
    public FloatVar Levels;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<IInteract>() != null)
        {
            UIManager.Instance.ActivateScreen("YouLose");
        }
    }

    public void Interactables()
    {
        GameManager.Instance.IsTotalEventsComplete = false;
        UIManager.Instance.ActivateScreen("YouWIn");
        if(GameManager.Instance.CurrentSceneIndex == Levels.floatVariable + 1)
            GameManager.Instance.levelLoader.LevelUnlock();
    }
}