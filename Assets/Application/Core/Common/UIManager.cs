using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public UIManager()
    {
        if (Instance == null)
            Instance = this;
    }

    
    public GameObject[] Screens;
    public Button NextLevelBtn;
    public FloatVar Level;

    public void ActivateScreen(string screenName)
    {
        for (int i = 0; i < Screens.Length; i++)
        {
            Screens[i].SetActive(false);

            if(Screens[i].name == screenName)
            {
                Screens[i].SetActive(true);
            }

        }


        if(Level.floatVariable == 4)
        {
            NextLevelBtn.gameObject.SetActive(false);
        }
    }
}
