using UnityEngine;

[CreateAssetMenu(menuName = "Level")]
public class LevelDetails : ScriptableObject
{
    public string LevelName;
    public GameEventListener[] listener;
}