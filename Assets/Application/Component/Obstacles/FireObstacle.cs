using UnityEngine;

public class FireObstacle : MonoBehaviour,IInteract
{
    public void Interactables()
    {
        GameManager.Instance.IsTotalEventsComplete = false;
        UIManager.Instance.ActivateScreen(3);
    }
}
