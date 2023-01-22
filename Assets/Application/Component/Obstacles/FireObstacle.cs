using System.Collections;
using UnityEngine;

public class FireObstacle : MonoBehaviour,IInteract
{
    public void Interactables()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        GameManager.Instance.IsTotalEventsComplete = false;
        UIManager.Instance.ActivateScreen("YouLose");
    }
}
