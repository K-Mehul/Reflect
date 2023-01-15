using UnityEngine;

[CreateAssetMenu(menuName = "SimpleUIEvent")]
public class SimpleUIEvent : UIEvent
{
    public GameObject[] Screens;

    public override void SetUI(int screenIndex)
    {
        for (int i = 0; i < Screens.Length; i++)
        {
            Screens[i].SetActive(false);
        }

        Screens[screenIndex].SetActive(true);
    }

}
