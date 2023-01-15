using UnityEngine;

public abstract class AudioEvent : ScriptableObject
{
    public abstract void PlayAudio(AudioSource source);
}
