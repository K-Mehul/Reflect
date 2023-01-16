using UnityEngine;

public class LevelData : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.TotalNumberOfEvents = GameObject.FindObjectsOfType<GameEventListener>().Length;
    }

    //private float _maxTimer = 5f;
    //private float _timer = 0;

    //private void Update()
    //{
    //    if(_timer < _maxTimer && !GameManager.Instance.IsTotalEventsComplete)
    //    {
    //        _timer += Time.deltaTime;
    //    }

    //    if(_timer >= _maxTimer && !GameManager.Instance.IsTotalEventsComplete)
    //    {
    //        UIManager.Instance.ActivateScreen("YouLose");
    //        _timer = 0;
    //    }

    //    if (GameManager.Instance.IsTotalEventsComplete) _timer = 0;
    //}
}
