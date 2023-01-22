using UnityEngine;
using System.Collections;

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
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        GameManager.Instance.IsTotalEventsComplete = false;
        UIManager.Instance.ActivateScreen("YouWIn");
        if(GameManager.Instance.CurrentSceneIndex == Levels.floatVariable + 1)
            GameManager.Instance.levelLoader.LevelUnlock();
    } 
}