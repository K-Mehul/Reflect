using System.Collections;
using UnityEngine;

public class Treasure : MonoBehaviour, IInteract
{
    public void Collectibles()
    {
        GameManager.Instance.IsTotalEventsComplete = false;
        Debug.Log("You win");
    }
}