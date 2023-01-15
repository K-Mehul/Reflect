using UnityEngine;

public class LevelData : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.TotalNumberOfEvents = GameObject.FindObjectsOfType<GameEventListener>().Length;
        Debug.Log(GameManager.Instance.TotalNumberOfEvents);

    }
}
