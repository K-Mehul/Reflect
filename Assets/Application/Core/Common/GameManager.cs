using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    public GameManager()
    {
        if (Instance == null)
            Instance = this;
    }

    #region PrivateVariables
    private bool _isTotalEventsComplete;
    private int _totalNumberOfEvents;
    private int _currentSceneIndex;
    #endregion

    #region Properties

    public bool IsTotalEventsComplete
    {
        get { return _isTotalEventsComplete; }
        set { _isTotalEventsComplete = value; }
    }

    public int TotalNumberOfEvents
    {
        get { return _totalNumberOfEvents;}
        set { _totalNumberOfEvents = value; }
    }

    public int CurrentSceneIndex
    {
        get { return _currentSceneIndex; }
        set { _currentSceneIndex = value; }
    }
    #endregion

    #region Public Variable
    public LevelLoader levelLoader = new LevelLoader();
    public SimpleAudioEvent _audio;
    public AudioSource _source;
    #endregion


    private void Awake()
    {
        //_audio.PlayAudio(_source);
        levelLoader.Level();
        UIManager.Instance.ActivateScreen("LevelHolder");
    }


    public void CheckTotalEventComplete()
    {
        if(TotalNumberOfEvents <= 0)
        {
            IsTotalEventsComplete = true;
        }
    }
}
