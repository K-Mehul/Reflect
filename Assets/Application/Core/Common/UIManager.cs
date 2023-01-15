using UnityEngine;
using UnityEngine.UI;

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

    public void ActivateScreen(int screenIndex)
    {
        for (int i = 0; i < Screens.Length; i++)
        {
            Screens[i].SetActive(false);
        }

        Screens[screenIndex].SetActive(true);

        if(Level.floatVariable == 4)
        {
            NextLevelBtn.gameObject.SetActive(false);
        }
    }
}
